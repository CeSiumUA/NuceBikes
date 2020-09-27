using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace NuceBikes_Server.DataModels
{
    public class Review
    {
        [Key]
        public int Id { get; set; }
        public string ReviewText
        {
            get
            {
                return reviewText;
            }
            set
            {
                reviewText = value;
            }
        }
        public User User
        {
            get
            {
                return user;
            }
            set
            {
                user = value;
            }
        }
        public DateTime PostDate
        {
            get
            {
                return postDate;
            }
            set
            {
                postDate = value;
            }
        }
        private Review replyToReview { get; set; }
        private string reviewText { get; set; }
        private DateTime postDate { get; set; }
        private User user { get; set; }
    }
}
