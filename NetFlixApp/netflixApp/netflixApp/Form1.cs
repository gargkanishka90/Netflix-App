// 
// N-Tier Netflix database application. 
// 
// <<KANISHKA GARG>> 
// U. of Illinois, Chicago 
// CS341, Spring 2014 
// Homework 8 
// 


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlServerCe;
using BusinessTier;

namespace netflixApp
{
    
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cmdDB_Click(object sender, EventArgs e)// Database Test Connection - done
        {
            listBox1.Items.Clear();
            BusinessTier.Business businesstier;
            string db_source = textBox12.Text;
            businesstier = new BusinessTier.Business("Data Source="+ db_source);
            if (businesstier.TestConnection())
                listBox1.Items.Add("Connection is good and using " + db_source);
            else
                listBox1.Items.Add("Connection is not good and using " + db_source);          
        }

        private void cmdAddMovie_Click(object sender, EventArgs e)// Add movie by Name - done
        {
            listBox1.Items.Clear();
            BusinessTier.Business businesstier;
            businesstier = new BusinessTier.Business("Data Source=" + textBox12.Text);
            string mov_name = (string)addMovieTextBox.Text;
            if (businesstier.AddMovie(mov_name))
            {
                listBox1.Items.Add("S U C C E S S");
                listBox1.Items.Add("");
                listBox1.Items.Add(mov_name + " is added to the database");
            }
            else
            {
                listBox1.Items.Add("F A I L U R E");
                listBox1.Items.Add("");
                listBox1.Items.Add(mov_name + " cannot be added to the database");
            }
            addMovieTextBox.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)// Search by ID - Done
        {
            listBox1.Items.Clear();
            BusinessTier.Business businesstier;
            businesstier = new BusinessTier.Business("Data Source=" + textBox12.Text);
            int movid = int.Parse((string)textBox1.Text);
            Movie m = businesstier.GetMovie(movid);
            if (m == null)
                {
                    listBox1.Items.Add("F A I L U R E");
                    listBox1.Items.Add("");
                    listBox1.Items.Add("Movie not found...");
                }
                else
                 {
                 listBox1.Items.Add("S U C C E S S");
                 listBox1.Items.Add("");
                 listBox1.Items.Add("MovieID " + movid + " is -->" + m.MovieName);
                 }
            textBox1.Text = "";
        }
        private void button2_Click(object sender, EventArgs e)//Search by Name - Done
        {
                listBox1.Items.Clear();
                BusinessTier.Business businesstier;
                businesstier = new BusinessTier.Business("Data Source=" + textBox12.Text);
                string mov_name = textBox2.Text;
                Movie m = businesstier.GetMovie(mov_name);
                if (m == null)
                {
                    listBox1.Items.Add("F A I L U R E");
                    listBox1.Items.Add("");
                    listBox1.Items.Add("MovieID not found...");
                }
                else
                {
                    listBox1.Items.Add("S U C C E S S");
                    listBox1.Items.Add("");
                    listBox1.Items.Add("ID for " + mov_name + " is -->" + m.MovieID);
                }
                textBox2.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)//Delete by ID. - done
        {
            listBox1.Items.Clear();
            BusinessTier.Business businesstier;
            businesstier = new BusinessTier.Business("Data Source=" + textBox12.Text);
            int mov_id = Convert.ToInt32(textBox4.Text);
            object m = businesstier.deleteMovie(mov_id);
            
                listBox1.Items.Add("S U C C E S S");
                listBox1.Items.Add("");
                listBox1.Items.Add("Movie ID " + mov_id + " is deleted...");
                textBox4.Text = "";
        }

        private void cmdARName_Click(object sender, EventArgs e)// Add review by name. 
                                                                //User ID can be of maximum 7 digits and 
                                                                 //cannot be a string/mix of characters and numbers. - done
        {
            
                listBox1.Items.Clear();
                BusinessTier.Business businesstier;
                businesstier = new BusinessTier.Business("Data Source=" + textBox12.Text);
                string usrid = (string)textBox3.Text;
                string mname = (string)textBox5.Text;
                int rate = (int)numericUpDown1.Value;
                if(businesstier.AddReview(mname,Convert.ToInt32(usrid),rate))
                    {
                        listBox1.Items.Add("S U C C E S S");
                        listBox1.Items.Add("");
                        listBox1.Items.Add("Review for " + mname + " is added to the database");
                    }
            else
                    {
                        listBox1.Items.Add("F A I L U R E");
                        listBox1.Items.Add("");
                        listBox1.Items.Add("Review for " + mname + " cannot be added to the database");
                    }                  
                textBox3.Text = "";
                textBox5.Text = "";
             }

        private void cmdARMN_Click(object sender, EventArgs e) // Average Rating by Movie Name - done. 
        {
                string mname = (string)textBox6.Text;
                listBox1.Items.Clear();
                BusinessTier.Business businesstier;
                businesstier = new BusinessTier.Business("Data Source=" + textBox12.Text);
                Reviews review;
                review = businesstier.GetReviewsforAverage(mname);
                if (review == null)
                {
                    listBox1.Items.Add("F A I L U R E");
                    listBox1.Items.Add("");
                    listBox1.Items.Add("Movie not found...");
                }
                else
                {
                    double avg_rate = review.AvgRating;
                    string art = Convert.ToString(Math.Round(avg_rate,2));
                    listBox1.Items.Add("S U C C E S S");
                    listBox1.Items.Add("");
                    listBox1.Items.Add("Average Rating for " + mname + " is: " + art);
                }
                textBox6.Text = "";
        }

        private void cmdERMN_Click(object sender, EventArgs e) // Each Rating by Movie Name - Done
        {
            listBox1.Items.Clear();
            BusinessTier.Business businesstier;
            businesstier = new BusinessTier.Business("Data Source=" + textBox12.Text);
            string mname = (string)textBox7.Text;
            int total=0;
            Reviews review;
            review = businesstier.GetReviews(mname);
            if (review == null)
            {
                listBox1.Items.Add("F A I L U R E");
                listBox1.Items.Add("");
                listBox1.Items.Add("Movie not found...");
            }
            else
            {
                listBox1.Items.Add("S U C C E S S");
                listBox1.Items.Add("");
                listBox1.Items.Add("Each Rating for " + mname + " are: ");
                listBox1.Items.Add("");
                foreach (Review r in review)
                {
                    listBox1.Items.Add(r.Rating.ToString() + ":" + r.RatingCount.ToString());
                    total = total + r.RatingCount;
                }
                listBox1.Items.Add("Total: " + total.ToString());
            }
            textBox7.Text = "";            
        }

        private void button4_Click(object sender, EventArgs e) // Top-N Movies by Average Rating - done
        {
            listBox1.Items.Clear();
            BusinessTier.Business businesstier;
            businesstier = new BusinessTier.Business("Data Source=" + textBox12.Text);
            Movies m;
            int N = Convert.ToInt32(textBox8.Text);
            if (N > 0)
            {
                m = businesstier.GetTopMoviesByAvgRating(N);
                if (m == null)
                {
                    listBox1.Items.Add("**Error, or database is empty?!");
                }
                else
                {
                    listBox1.Items.Add("S U C C E S S");
                    listBox1.Items.Add("");
                    listBox1.Items.Add("The top " + N + " Movies in the database are: ");
                    listBox1.Items.Add("");
                    foreach (Movie r in m)
                    {
                        listBox1.Items.Add(r.MovieName.ToString() + ":" + Math.Round(r.AvgRating, 2).ToString());
                    }
                }
            }
            else listBox1.Items.Add("**Error, N cannot be negative**");
            textBox8.Text = "";
        }

        private void button5_Click(object sender, EventArgs e) // Top-N Prolific Users - done
        {
            listBox1.Items.Clear();
            BusinessTier.Business businesstier;
            businesstier = new BusinessTier.Business("Data Source=" + textBox12.Text);
            Users u;
            int N = Convert.ToInt32(textBox9.Text);
            if (N > 0)
            {
                u = businesstier.GetTopUsersByNumReviews(N);
                if (u == null)
                {
                    listBox1.Items.Add("**Error, or database is empty?!");
                }
                else
                {
                    listBox1.Items.Add("S U C C E S S");
                    listBox1.Items.Add("");
                    listBox1.Items.Add("The top " + N + " Prolific users in the database are: ");
                    listBox1.Items.Add("");
                    foreach (User r in u)
                    {
                        listBox1.Items.Add(r.UserID.ToString() + ":" + r.NumReviews.ToString());
                    }
                }
            }
            else
                listBox1.Items.Add("**Error, N cannot be negative**");
            textBox9.Text = "";
        }

        private void button6_Click(object sender, EventArgs e) // Top-n Reviewed Movies - done
        {
                listBox1.Items.Clear();
                BusinessTier.Business businesstier;
                businesstier = new BusinessTier.Business("Data Source=" + textBox12.Text);
                Movies m;
                int N = Convert.ToInt32(textBox10.Text);
                if (N > 0)
                {
                    m = businesstier.GetTopMoviesByNumReviews(N);
                    if (m == null)
                    {
                        listBox1.Items.Add("**Error, or database is empty?!");
                    }
                    else
                    {
                        listBox1.Items.Add("S U C C E S S");
                        listBox1.Items.Add("");
                        listBox1.Items.Add("The top " + N + " reviewed movies in the database are: ");
                        listBox1.Items.Add("");
                        foreach (Movie r in m)
                        {
                            listBox1.Items.Add(r.MovieID.ToString() + ":" + r.NumReviews.ToString());
                        }
                    }
                }
                else listBox1.Items.Add("**Error, N cannot be negative**");
                textBox10.Text = "";            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e) // Get Reviews by Movie ID - done
        {
            listBox1.Items.Clear();
            BusinessTier.Business businesstier;
            businesstier = new BusinessTier.Business("Data Source=" + textBox12.Text);
            int mov_id = Convert.ToInt32(textBox11.Text);
            Reviews review;
            review = businesstier.GetReviews(mov_id);
            if (review == null)
            {
                listBox1.Items.Add("F A I L U R E");
                listBox1.Items.Add("");
                listBox1.Items.Add("Movie not found...");
            }
            else
            {
                listBox1.Items.Add("S U C C E S S");
                listBox1.Items.Add("");
                listBox1.Items.Add("The Reviews for Movie with MovieID " + mov_id + " are: ");
                listBox1.Items.Add("");
                foreach (Review r in review)
                {
                    listBox1.Items.Add(r.UserID.ToString() + ":" + r.Rating.ToString());
                }
            }
            textBox11.Text = "";
        }
    }
}
