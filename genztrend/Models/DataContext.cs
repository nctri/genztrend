using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using MySql.Data.EntityFramework;


namespace genztrend.Models
{
    [DbConfigurationType(typeof(MySqlEFConfiguration))]
    public class DataContext : DbContext
    {

        public DataContext()
     : base("MySQLConnection") //This 'DefaultConnection' should be equal to the connection string name on Web.config.
        {
            this.Configuration.ValidateOnSaveEnabled = false;
        }

        protected override void OnModelCreating(System.Data.Entity.DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            // mapping naming between User entity and table tblUser.
            modelBuilder.Entity<User>()
                        .ToTable("tblUser");
            modelBuilder.Entity<News>()
             .ToTable("tblNews");

        }



        public DbSet<User> tblUser { get; set; }

        public DbSet<News> tblNews { get; set; }
    }
}