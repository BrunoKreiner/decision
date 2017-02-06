using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Decision.Models.DataModels
{
    public class Possibility
    {
        [Key]
        public int Id { get; set; }

        public String Name { get; set; }

        public int VoteCount { get; set; }
    }
}