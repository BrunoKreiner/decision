using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Decision.Models.DataModels
{
    public class Category
    {
        public Category()
        {
            Articles = new List<Article>();
        }
        [Key]
        public int Id { get; set; }

        public String Name { get; set; }

        public virtual ICollection<Article> Articles { get; set; }

    }
}