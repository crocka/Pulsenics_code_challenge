using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Pulsenics_code_challenge
{

    public class ApplicationDbContext : DbContext
    {


        private string DbPath = @"C:\Users\chino\Desktop\db\testDb.db";
        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlite("FileName=pulsenicsDB", option =>
        //    {
        //        option.MigrationsAssembly(Assembly.GetExecutingAssembly().Name);

        //    });
        //    base.OnConfiguring(optionsBuilder);

        //}

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlite($"Data Source={DbPath}");
        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().ToTable("User");
            modelBuilder.Entity<User>(entity =>
            {
                entity.HasKey(x => x.Id);
                entity.HasIndex(entity => entity.Name).IsUnique();
                entity.HasIndex(entity => entity.Email).IsUnique();
                entity.HasIndex(entity => entity.Phone).IsUnique();
            });

            modelBuilder.Entity<File>().ToTable("File");
            modelBuilder.Entity<File>(entity =>
            {
                entity.HasKey(x => x.Id);
                entity.HasIndex(entity => entity.Name).IsUnique();

            });

            modelBuilder.Entity<User_file>(entity =>
            {
                entity.HasKey(x => new { x.Id, x.UserId, x.FileId });
                entity.HasOne(u => u.User).WithMany(uf => uf.Files).HasForeignKey(f => f.UserId);
                entity.HasOne(f => f.File).WithMany(uf => uf.Users).HasForeignKey(f => f.FileId);

            });

            //modelBuilder.Entity<User_file>()
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<User>? Users { get; set; }
        public DbSet<File>? Files { get; set; }
        public DbSet<User_file>? User_files { get; set; }

    }
}
