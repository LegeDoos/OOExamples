using KidsEventsIncorporated.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace KidsEventsIncorporated.DAL
{
    /// <summary>
    /// Database context for the model
    /// </summary>
    public class KEIDatabaseContext : DbContext
    {
        public KEIDatabaseContext() : base("KEIDatabaseContext")
        {
        }

        public DbSet<Event> Events { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}