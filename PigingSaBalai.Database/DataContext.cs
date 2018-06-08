using Microsoft.AspNet.Identity.EntityFramework;
using MyProject1.Database.Contracts;
using MyProject1.Database.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject1.Database
{
    public class DataContext : IdentityDbContext<Users>
    {
        public string UserId { get; set; }

        public DataContext()
          : base("DefaultConnection")
        {
        }

        public DataContext(string userId)
          : base("DefaultConnection")
        {
            UserId = userId;
        }

        public static DataContext Create()
        {
            return new DataContext();
        }

        #region Override Methods
        public override Task<int> SaveChangesAsync()
        {
            AuditChanges();
            return base.SaveChangesAsync();
        }

        public override int SaveChanges()
        {
            AuditChanges();
            return base.SaveChanges();
        }

        private void AuditChanges()
        {
            var changeSet = ChangeTracker.Entries<IAuditable>();
            if (changeSet != null)
            {
                foreach (var entry in changeSet.Where(c => c.State != EntityState.Unchanged))
                {
                    if (entry.State == EntityState.Added)
                    {
                        entry.Entity.CreatedDate = DateTime.UtcNow;
                        entry.Entity.CreatedBy = UserId;
                    }
                    entry.Entity.LastUpdatedDate = DateTime.UtcNow;
                    entry.Entity.LastUpdatedBy = UserId;
                }
            }
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Users>().ToTable("Users");
        }
        #endregion

        #region DBSets / Tables              
        // Add table here
        #endregion
    }
}
