// 
// N-Tier Netflix database application. 
// 
// <<KANISHKA GARG>> 
// U. of Illinois, Chicago 
// CS341, Spring 2014 
// Homework 8 
// 

//
// BusinessTier:  business logic, acting as interface between UI and data store.
//

using System;
using System.Collections.Generic;
using System.Data;


namespace BusinessTier
{

  //
  // Business:
  //
  class Business
  {
    //
    // Fields:
    //
    private string _DBFile;
    private DataAccessTier.Data datatier;

    //
    // Constructor:
    //
    public Business(string DatabaseFilename)
    {
      _DBFile = DatabaseFilename;
      datatier = new DataAccessTier.Data(DatabaseFilename);
    }

    //
    // Methods:
    //
    public bool TestConnection()
    {
      return datatier.TestConnection();
    }

    public bool AddMovie(string MovieName) // done 
    {
        string sql1= "SELECT MAX(MovieID) FROM MOVIES;";
        object maxRes = datatier.ExecuteScalarQuery(sql1);
        string res = maxRes.ToString();
        int re = Convert.ToInt32(res);
        re = re + 1;
        string num = re.ToString();
        string sql2 = "INSERT INTO MOVIES(MovieID,MovieName) VALUES (" + num + "," + "'" + MovieName + "'" + ");";
        int rowModified = datatier.ExecuteActionQuery(sql2);
        if (rowModified == 1)
        {
            return true;
        }
        else if (rowModified == 0)
        {
            return false;
        }
        else return false;
    }

    public bool AddReview(int MovieID, int UserID, int Rating)
    {
      //
      // TODO:
      //

      return false;
    } // done

    public bool AddReview(string MovieName, int UserID, int Rating) // done.
    {
        string sql1 = "SELECT MovieID FROM MOVIES WHERE MovieName = '" + MovieName + "';";
        object result = datatier.ExecuteScalarQuery(sql1);
        string sql2 = "INSERT INTO REVIEWS(UserID,MovieID,Rating) VALUES ('" + UserID + "','" + result.ToString() + "','" + Rating.ToString() + "');";
        int rowsMod = datatier.ExecuteActionQuery(sql2);
        if (rowsMod == 1)
        {
            return true;
        }
        if (rowsMod == 0)
        {
            return false;
        }
      return false;
    }
    
    public Movie GetMovie(int MovieID)
    {
      Movie m;
      string sql = "SELECT MovieName FROM MOVIES WHERE MovieID = " + MovieID + ";";
      object res = datatier.ExecuteScalarQuery(sql);
      if (res == null)
          return null;
      m = new Movie(MovieID, res.ToString(), GetReviews(MovieID));
      return m;
    } //done

    public Movie GetMovie(string MovieName)
    {
      Movie m;
      string sql = "SELECT MovieID FROM MOVIES WHERE MovieName = '" + MovieName + "';";
      object res = datatier.ExecuteScalarQuery(sql);
      if (res == null)
          return null;
      int id = int.Parse(res.ToString());
      m = new Movie(id,MovieName, GetReviews(id));
      return m;
    } // done

    public Reviews GetReviews(int MovieID)
    {
      Reviews reviews = new Reviews();
      string sql = string.Format(@"SELECT UserID, Rating 
            FROM Reviews 
            WHERE MovieID={0}
            ORDER BY Rating Desc, UserID ASC;",
      MovieID);
      DataSet ds = datatier.ExecuteNonScalarQuery(sql);
      DataTable dt = ds.Tables["TABLE"];
      if (dt.Rows.Count == 0)
      {
          return null;
      }
      else
      {
          foreach (DataRow row in dt.Rows)
              reviews.Add(new Review(Convert.ToInt32(row["UserID"]), MovieID, Convert.ToInt32(row["Rating"])));
          return reviews;
      }
    } //done

    public Reviews GetReviews(string MovieName)
    {
        Reviews reviews = new Reviews();
        string sql2 = string.Format(@"SELECT Rating, COUNT(Rating) as RatingCount
          FROM Reviews
					INNER JOIN Movies ON Reviews.MovieID = Movies.MovieID
					WHERE Movies.MovieName='{0}'
          GROUP BY Rating
          ORDER BY Rating DESC;",
                MovieName);
        DataSet ds = datatier.ExecuteNonScalarQuery(sql2);
        DataTable dt = ds.Tables["TABLE"];
        if (dt.Rows.Count == 0)
        {
            return null;
        }
        else
        {
            foreach (DataRow row in dt.Rows)
                reviews.Add(new Review(Convert.ToInt32(row["Rating"]), Convert.ToInt32(row["RatingCount"])));
            return reviews;
        }
    } //done

    public Reviews GetReviewsforAverage(string MovieName) // int reviewid, int movieid, int userid, int rating)
    {
        Reviews reviews = new Reviews();
        string sql2 = string.Format(@"SELECT Reviews.ReviewID as rid, Reviews.MovieID as mid, Reviews.UserID as uid, Rating
          FROM Reviews
					INNER JOIN Movies ON Reviews.MovieID = Movies.MovieID
					WHERE Movies.MovieName='{0}';",
                MovieName);
        DataSet ds = datatier.ExecuteNonScalarQuery(sql2);
        DataTable dt = ds.Tables["TABLE"];
        if (dt.Rows.Count == 0)
        {
            return null;
        }
        else
        {
            foreach (DataRow row in dt.Rows)
                reviews.Add(new Review(Convert.ToInt32(row["rid"]), Convert.ToInt32(row["mid"]), Convert.ToInt32(row["uid"]), Convert.ToInt32(row["Rating"])));
            return reviews;
        }
    } //done


    public object deleteMovie(int movieid) // Method to delete movie by movieID.
    {
        string sql = "DELETE FROM MOVIES WHERE MovieID = '" + movieid + "';";
        object res = datatier.ExecuteScalarQuery(sql);
        return res;
    } // done

    public Movies GetTopMoviesByAvgRating(int N)
    {
      Movies movies = new Movies();
      string sql = string.Format(@"SELECT TOP {0} Movies.MovieName as mn, g.MovieID as kk, g.AvgRating 
            FROM Movies
            INNER JOIN 
              (
                SELECT MovieID, ROUND(AVG(CAST(Rating AS Float)), 2) as AvgRating 
                FROM Reviews
                GROUP BY MovieID
              ) g
            ON g.MovieID = Movies.MovieID
            ORDER BY g.AvgRating DESC, Movies.MovieName Asc;",
        N);
      DataSet ds = datatier.ExecuteNonScalarQuery(sql);
      DataTable dt = ds.Tables["TABLE"];
      if (dt.Rows.Count == 0)
      {
          return null;
      }
      else
      {
          foreach (DataRow row in dt.Rows)
              movies.Add(new Movie(Convert.ToInt32(row["kk"]), Convert.ToString(row["mn"]), GetReviews(Convert.ToInt32(row["kk"]))));
          return movies;
      }
    } // done

    public Movies GetTopMoviesByNumReviews(int N)
    {
      Movies movies = new Movies();
      string sql = string.Format(@"SELECT TOP {0} Movies.MovieName as mn, Movies.MovieID as kk, g.RatingCount as rc
            FROM Movies
            INNER JOIN 
              (
                SELECT MovieID, COUNT(*) as RatingCount 
                FROM Reviews
                GROUP BY MovieID
              ) g
            ON g.MovieID = Movies.MovieID
            ORDER BY g.RatingCount DESC, Movies.MovieName Asc;",
        N);
      DataSet ds = datatier.ExecuteNonScalarQuery(sql);
      DataTable dt = ds.Tables["TABLE"];
      if (dt.Rows.Count == 0)
      {
          return null;
      }
      else
      {
          foreach (DataRow row in dt.Rows)
              movies.Add(new Movie(Convert.ToInt32(row["kk"]), Convert.ToString(row["mn"]), GetReviews(Convert.ToInt32(row["kk"]))));
          return movies;
      }
    } //done

    public Users GetTopUsersByNumReviews(int N)
    {
      Users users = new Users();
      string sql = string.Format(@"SELECT TOP {0} UserID as uid, COUNT(*) AS RatingCount
            FROM Reviews
            GROUP BY UserID
            ORDER BY RatingCount DESC, UserID Asc;",
        N);
      DataSet ds = datatier.ExecuteNonScalarQuery(sql);
      DataTable dt = ds.Tables["TABLE"];
      if (dt.Rows.Count == 0)
      {
          return null;
      }
      else
      {
          foreach (DataRow row in dt.Rows)
              users.Add(new User(Convert.ToInt32(row["uid"]), Convert.ToInt32(row["RatingCount"])));
          return users;
      }
    } // done

  }//class

}//namespace
