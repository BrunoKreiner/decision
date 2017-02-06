using Decision.Models.DataModels;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Decision.DataAccess
{
    public class DecisionContext : IdentityDbContext<ApplicationUser>
    {
        public DecisionContext()
            : base("DecisionConnectionString", throwIfV1Schema: false)
        {
        }

        public DbSet<Comment> Comments { get; set; }
        public DbSet<Article> Articles { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Possibility> Possibilities { get; set; }


        public static DecisionContext Create()
        {
            return new DecisionContext();
        }
    }
}