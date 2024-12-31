using Microsoft.EntityFrameworkCore;
using revision_ahmed_eklzzat.Models;

namespace revision_ahmed_eklzzat.Data
{
    public class DB_Connection : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            optionsBuilder.UseSqlServer("Server=LEVASCH-STD050;Database=zey;Trusted_Connection=True;TrustServerCertificate=True;");
        }

        DbSet<Student> Students {  get; set; }  

        DbSet<Assignment> Assignment { get; set; }

        DbSet<Department> Departments { get; set; }
    }
}
