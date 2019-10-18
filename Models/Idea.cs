using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace BrightIdeas.Models
{
    public class Idea
    {
        [Key]
        public int IdeaId { get; set; }

        [Required]
        [MinLength(5)]
        public string Content {get; set; }

        public int CreatedBy { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;

        public List<Like> LikedBy { get; set; }

    }
}