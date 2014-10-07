// 
// N-Tier Netflix database application. 
// 
// <<KANISHKA GARG>> 
// U. of Illinois, Chicago 
// CS341, Spring 2014 
// Homework 8 
// 

//
// Data Access Tier:  interface between business tier and database.
//

using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlServerCe;


namespace DataAccessTier
{

  class Data
  {
    //
    // Fields:
    //
    private string _DBFile;

    //
    // constructor:
    //
    public Data(string DatabaseFilename)
    {
      _DBFile = DatabaseFilename;
    }

    //
    // TestConnection:  returns true if the database can be successfully opened and closed,
    // false if not.
    //
    public bool TestConnection()
    {
        SqlCeConnection db = new SqlCeConnection(_DBFile);
        try
        {
            db.Open();
            SqlCeCommand cmd = new SqlCeCommand();
            cmd.Connection = db;
            db.Close();
            return true;
        }
        catch (Exception ex)
        {
            return false;
        }
    }

    //
    // ExecuteScalarQuery:  executes a scalar Select query, returning the single result 
    // as an object.  
    //
    public object ExecuteScalarQuery(string sql)
    {
            SqlCeConnection db = new SqlCeConnection(_DBFile);
            db.Open();
            SqlCeCommand cmd = new SqlCeCommand();
            cmd.Connection = db;
            cmd.CommandText = sql;
            object maxRes = cmd.ExecuteScalar();
            if (maxRes == null || maxRes.ToString() == "")
                return null;
            db.Close();
            return maxRes;
    } //done

    // 
    // ExecuteNonScalarQuery:  executes a Select query that generates a temporary table,
    // returning this table in the form of a Dataset.
    //
    public DataSet ExecuteNonScalarQuery(string sql)
    {
                DataSet ds = new DataSet();
                SqlCeConnection db = new SqlCeConnection(_DBFile);
                db.Open();
                SqlCeCommand cmd = new SqlCeCommand();
                cmd.Connection = db;
                SqlCeDataAdapter adapter = new SqlCeDataAdapter(cmd);
                cmd.CommandText = sql;
                int result1 = cmd.ExecuteNonQuery();
                adapter.Fill(ds);
                db.Close(); 
                return ds;
    } //done

    //
    // ExecutionActionQuery:  executes an Insert, Update or Delete query, and returns
    // the number of records modified.
    //
    public int ExecuteActionQuery(string sql)
    {
      int rowsModified = 0;
      SqlCeConnection db = new SqlCeConnection(_DBFile);
      db.Open();
      SqlCeCommand cmd = new SqlCeCommand();
      cmd.Connection = db;
      cmd.CommandText = sql;
      rowsModified = cmd.ExecuteNonQuery();
      db.Close();
      return rowsModified;
    } //done

  }//class

}//namespace
