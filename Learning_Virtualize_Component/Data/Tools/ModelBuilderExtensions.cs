namespace Data.Tools
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this Microsoft.EntityFrameworkCore.ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Models.User>().HasData(
                new Models.User
                {
                    Id = new System.Guid("5F1C219A-DC0D-4EE4-A8D6-2808E43232A7"),
                    IsActive = true,
                    FullName = "محسن فرخی",
                    CellPhoneNumber = "09120717168",
                    Username = "admin",
                    Password = "password",
                    Type = Models.Enums.UserType.Programmer,
                }
            );
        }
    }
}
