using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace CodeFirst
{
    public class AcademyGroupContext : DbContext
    {
        public AcademyGroupContext()
        {
           Database.EnsureCreated();
        }

        public DbSet<AcademyGroup> AcademyGroups { get; set; }
        public DbSet<Student> Students { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // метод UseLazyLoadingProxies() делает доступной ленивую загрузку.
            optionsBuilder
                .UseLazyLoadingProxies()
                .UseSqlServer(@"Server=localhost\SQLEXPRESS;Database=AcademyGroupDB;Integrated Security=SSPI;TrustServerCertificate=true")
                .LogTo((str) => Debug.WriteLine(str));

//            optionsBuilder.UseSqlServer(@"Server=localhost\SQLEXPRESS;Database=AcademyGroupDB;Integrated Security=SSPI;TrustServerCertificate=true");

        }
    }
}
