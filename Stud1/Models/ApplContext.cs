using Microsoft.EntityFrameworkCore;

namespace StudList.Models
{
    public class ApplContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<Subject> Subjects { get; set; }

        public ApplContext(DbContextOptions<ApplContext> options)
            : base(options)
        {
           //Database.EnsureDeleted();
           Database.EnsureCreated();
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>().HasData(
                    new Student { Id = 1, Name = "Нурлан", Surname = "Сабуров", MidName = "Алибекович", SubjectId= 4, Grade=5},
                    new Student { Id = 2, Name = "Алексей", Surname = "Щербаков", MidName = "Сергеевич", SubjectId = 3, Grade = 3 },
                    new Student { Id = 3, Name = "Арсенуко (Тамби)", Surname = "Масаев", MidName = "Мухамедович", SubjectId = 1, Grade = 4 },
                    new Student { Id = 4, Name = "Илья", Surname = "Макаров", MidName = "Андреевич", SubjectId = 2, Grade = 4 },
                    new Student { Id = 5, Name = "Сергей", Surname = "Детков", MidName = "Степанович", SubjectId = 5, Grade = 4 }
            );
            modelBuilder.Entity<Subject>().HasData(
                    new Subject { Id = 1, Name = "Математика" },
                    new Subject { Id = 2, Name = "Информатика" },
                    new Subject { Id = 3, Name = "География" },
                    new Subject { Id = 4, Name = "Физкультура" },
                    new Subject { Id = 5, Name = "Русский язык" }
            );
        }
    }
}
