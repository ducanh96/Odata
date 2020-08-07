using Microsoft.EntityFrameworkCore;
using odata.common;
using System;

namespace odata.server
{
    public class BlogContext : DbContext
    {
        public BlogContext(DbContextOptions<BlogContext> options) : base(options)
        {
        }

        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Post> Posts { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Blog>()
                .HasData
                (
                    new Blog()
                    {
                        BlogId = 2,
                        Name = "The second post",
                        Creation = DateTime.Now,
                        Url = "https://google.com.vn"
                    }
                );
        }
    }
}
