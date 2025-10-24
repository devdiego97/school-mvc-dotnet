using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using school_mvc_dotnet.Models;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace school_mvc_dotnet.Database
{
	public class AppDbContext : DbContext


	{
		public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
		public DbSet<Student> Students { get; set; }
		public DbSet<Teacher> Teachers { get; set; }

		public override int SaveChanges()
		{
			UpdateTimestamps();
			return base.SaveChanges();
		}

       private void UpdateTimestamps()
        {
            var entries = ChangeTracker
                .Entries<BaseModel>()
                .Where(e => e.State == EntityState.Added || e.State == EntityState.Modified);

            var utcNow = DateTime.UtcNow;

            foreach (var entry in entries)
            {
                if (entry.State == EntityState.Added)
                {
                    entry.Entity.createdAt = utcNow;
                    entry.Entity.updatedAT = null; // opção
                }
                else if (entry.State == EntityState.Modified)
                {
                    // Opcional: evitar sobrescrever CriadoEm caso de atualização acidental
                    entry.Property(p => p.createdAt).IsModified = false;

                    entry.Entity.updatedAT = utcNow;
                }
            }
        }
	}
}