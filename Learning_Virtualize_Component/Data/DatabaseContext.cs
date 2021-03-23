using Data.Tools;

namespace Data
{
	public class DatabaseContext : Microsoft.EntityFrameworkCore.DbContext
	{
        public DatabaseContext
            (Microsoft.EntityFrameworkCore.DbContextOptions<DatabaseContext> options) : base(options)
        {
			//Database.EnsureCreated();
        }

        // **********
        public Microsoft.EntityFrameworkCore.DbSet<Models.User> Users { get; set; }
		// **********

		protected override void OnModelCreating
			(Microsoft.EntityFrameworkCore.ModelBuilder modelBuilder)
		{
			modelBuilder.Seed();

			modelBuilder.ApplyConfigurationsFromAssembly
				(System.Reflection.Assembly.GetExecutingAssembly());

			#region HasQueryFilter
			modelBuilder.Entity<Models.User>().HasQueryFilter(current => current.IsDeleted == false);
			#endregion

			base.OnModelCreating(modelBuilder);
		}
	}
}
