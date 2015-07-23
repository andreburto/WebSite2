using System;
using System.IO;
using System.Text;

namespace MyPoster
{
    /// <summary>
    /// Summary description for Post
    /// </summary>
    public class Post
    {
        private double _id;
        private string _text;
        private string _title;
        private DateTime _date;

        public double PostId { get { return _id; } }
        public string PostText { get { return _text; } }
        public string PostTitle { get { return _title; } }
        public DateTime PostDate { get { return _date; } }

        public Post(double id, string text, string title, DateTime date)
        {
            _id = id;
            _text = text;
            _title = title;
            _date = date;
        }
    }
}