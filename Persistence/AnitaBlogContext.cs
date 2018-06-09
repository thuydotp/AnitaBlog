using AnitaBlog.Persistence.Entities;
using Microsoft.EntityFrameworkCore;

namespace AnitaBlog.Persistence
{
    public class AnitaBlogContext : DbContext
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<Article> Articles { get; set; }
        public DbSet<Account> Accounts { get; set; }

        public AnitaBlogContext(DbContextOptions options)
            :base(options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Category
            modelBuilder.Entity<Category>()
                .Property(cate => cate.ID)
                .ValueGeneratedOnAdd();

            modelBuilder.Entity<Category>()
                .Property(cate => cate.Name)
                .IsRequired();

            //Article
            modelBuilder.Entity<Article>()
                .Property(cate => cate.ID)
                .ValueGeneratedOnAdd();

            modelBuilder.Entity<Article>()
                .Property(cate => cate.Title)
                .IsRequired();

            modelBuilder.Entity<Article>()
                .Property(cate => cate.MainContent)
                .IsRequired();
            
            //Account
             modelBuilder.Entity<Account>()
                .Property(cate => cate.ID)
                .ValueGeneratedOnAdd();
                
            modelBuilder.Entity<Account>()
                .Property(cate => cate.Username)
                .IsRequired();
               
        }
    }
}