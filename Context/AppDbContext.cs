using Fulent_API.Configurations;
using Fulent_API.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fulent_API.Context
{
    internal class AppDbContext : DbContext
    {

        public DbSet<Book> Books { get; set; }
        public DbSet<Theme> Themes { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Press> Presses { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<T_Card> T_Cards { get; set; }
        public DbSet<S_Card> S_Cards { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Group> Groups { get; set; }
        public DbSet<Libs> Libs { get; set; }
        public DbSet<Faculty> Faculties { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-6E9TGOF\\SQLEXPRESS02;Initial Catalog=NewLibrary;Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False");
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration<Book>(new BookConfiguration());
            modelBuilder.ApplyConfiguration<Theme>(new ThemeConfiguration());
            modelBuilder.ApplyConfiguration<Teacher>(new TeacherConfiguration());
            modelBuilder.ApplyConfiguration<Group>(new GroupConfiguration());
            modelBuilder.ApplyConfiguration<S_Card>(new S_CardConfiguration());
            modelBuilder.ApplyConfiguration<T_Card>(new T_CardConfiguration());
            modelBuilder.ApplyConfiguration<Student>(new StudentConfiguration());
            modelBuilder.ApplyConfiguration<Teacher>(new TeacherConfiguration());

            base.OnModelCreating(modelBuilder);
        }
    }
}
