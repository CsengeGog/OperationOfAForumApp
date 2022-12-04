using Microsoft.EntityFrameworkCore;
using OperationOfAForumApp.Models;

namespace OperationOfAForumApp.Data
{
    public class DataContex:DbContext
    {
        public DataContex(DbContextOptions<DataContex> options):base(options)
        {

        }

        //Created tables
        public DbSet<Threads> Threads { get; set; }
        public DbSet<Posts> Posts { get; set; }

        public DbSet<ForbiddenWords> ForbiddenWords { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Posts>()
                .HasOne<Threads>()
                .WithMany()
                .HasForeignKey(x => x.ThreadName);
        }

    }
}
