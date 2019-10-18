using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace BrightIdeas.Models
{
    public class Dashboard
    {
        public List<Idea> AllIdeas { get; set; }
        public List<User> AllUsers { get; set; }
        public Like Like { get; set; }
        public Idea Idea { get; set; }
        public int CurrentUserId { get; set; }
        public List<User> Likers { get; set; }

        public User ThisUser { get; set; }
    }
}