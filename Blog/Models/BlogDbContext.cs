using Microsoft.EntityFrameworkCore;

namespace Blog.Models
{
    internal class BlogDbContext : DbContext
    {
        public BlogDbContext() { }
        public BlogDbContext(DbContextOptions options) : base(options) { }

        public DbSet<Blogger> bloggers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql("server=localhost;database=blog;user=root;password=");
        }
    }
}
