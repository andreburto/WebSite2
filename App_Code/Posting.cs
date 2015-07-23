using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace MyPoster
{
    /// <summary>
    /// Summary description for Posting
    /// </summary>
    public class Posting
    {
        private string _connection;

        public List<Post> GetPosts()
        {
            List<Post> posts = new List<Post>();
            string sql = "select PostId, PostText, PostTitle, PostDate from andrew.andrew.Posts order by PostDate desc";

            using (SqlConnection c = new SqlConnection(_connection))
            {
                SqlCommand cmd = new SqlCommand(sql, c);

                try
                {
                    c.Open();
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        posts.Add(new Post(reader.GetInt32(0),
                                           reader.GetString(1),
                                           reader.GetString(2),
                                           reader.GetDateTime(3)));
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Could not get names", ex);
                }
            }

            return posts;
        }

        public int CountPosts()
        {
            int counter = 0;
            string sql = "select andrew.andrew.CountPosts()";

            using (SqlConnection c = new SqlConnection(_connection))
            {
                SqlCommand cmd = new SqlCommand(sql, c);

                try
                {
                    c.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    reader.Read();
                    counter = reader.GetInt32(0);
                }
                catch (Exception ex)
                {
                    throw new Exception("Could not get post count", ex);
                }
            }

            return counter;
        }

        public bool NewPost(string title, string text)
        {
            bool yn = false;
            string sql = "NewPost";

            using (SqlConnection c = new SqlConnection(_connection))
            {
                SqlCommand cmd = new SqlCommand(sql, c);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@PostTitle", SqlDbType.VarChar, 50);
                cmd.Parameters["@PostTitle"].Value = title;

                cmd.Parameters.Add("@PostText", SqlDbType.Text);
                cmd.Parameters["@PostText"].Value = text;

                try
                {
                    c.Open();
                    cmd.ExecuteNonQuery();
                    yn = true;
                }
                catch (SqlException ex)
                {
                    throw new Exception("1. Could not add new post", ex);
                }
                catch (Exception ex)
                {
                    throw new Exception("2. Could not add new post", ex);
                }
            }

            return yn;
        }

        public Posting(string conn)
        {
            _connection = conn;
        }
    }
}