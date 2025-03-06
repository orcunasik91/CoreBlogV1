using CoreBlogV1.WebUI.Models;
using Microsoft.EntityFrameworkCore;

namespace CoreBlogV1.WebUI.Context;
public class BlogAppContext : DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Data Source=127.0.0.1;Initial Catalog=CoreBlogV1;User ID=sa;Password=Password1;TrustServerCertificate=True;");
    }
    public DbSet<Blog> Blogs { get; set; }
    public DbSet<Comment> Comments { get; set; }
}