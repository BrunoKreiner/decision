using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Decision.Models.DataModels
{
    public class Article
    {
        public Article()
        {
            Categories = new List<Category>();
            Possibilities = new List<Possibility>();
            Comments = new List<Comment>();
        }

        [Key]
        public int Id { get; set; }

        public string Text { get; set; }

        public virtual ICollection<Category> Categories { get; set; }

        public virtual ICollection<Possibility> Possibilities { get; set; }
    
        public virtual ICollection<Comment> Comments { get; set; }
    }
}