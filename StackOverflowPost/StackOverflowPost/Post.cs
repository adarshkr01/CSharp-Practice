using System;
using System.Collections.Generic;
using System.Text;

namespace StackOverflowPost
{
    class Post
    {
        private string _title;
        private string _description;
        private DateTime _createdAt;
        private int _upvotes;
        private int _downvotes;

        public Post(string title, string description)
        {
            _title = title;
            _description = description;
            _createdAt = DateTime.Now;
            _upvotes = 0;
            _downvotes = 0;
        }

        public void ShowPost()
        {
            Console.WriteLine("{0}\n{1}\n{2}\nUpvotes: {3} | Downvotes: {4}",
                _title, _description, _createdAt, _upvotes, _downvotes);
        }

        public void Upvote()
        {
            _upvotes += 1;
        }

        public void DownVote()
        {
            _downvotes += 1;
        }
    }
}
