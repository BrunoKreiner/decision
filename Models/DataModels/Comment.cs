using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Decision.Models.DataModels
{
    public class Comment
    {
        [Key]
        public int Id { get; set; }

        public String Text { get; set; }

        public int Depth { get; set; }

        public int VoteCount { get; set; }

        public Comment ChildComment { get; set; }
    }
}