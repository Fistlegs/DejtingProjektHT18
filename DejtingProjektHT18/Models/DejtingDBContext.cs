using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace DejtingProjektHT18.Models
{
    public class DejtingDBContext : DbContext
    {
        public DbSet<ProfileModel> Profiles { get; set; }
        public DbSet<PostModel> Posts { get; set; }

        public DejtingDBContext() : base("DejtingDB") { }
    }
}