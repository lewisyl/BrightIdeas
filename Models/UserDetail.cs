using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace BrightIdeas.Models
{
    public class UserDetail
    {
        public User User { get; set; }
        public int TotalPosts { get; set; }
        public int TotalLikes { get; set; }
    }
}