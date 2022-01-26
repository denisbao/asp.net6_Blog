using Blog.Models;
using Microsoft.EntityFrameworkCore;

namespace Blog.Data
{
  public class BlogDataContext : DbContext
  {
    // Definição da representação das tabelas:
    public DbSet<Category> Categories { get; set; }
    public DbSet<Post> Posts { get; set; }
    public DbSet<User> Users { get; set; }
    public DbSet<Role> Roles { get; set; }
    public DbSet<Tag> Tags { get; set; }


    // Definição da Conection String:
    protected override void OnConfiguring(DbContextOptionsBuilder options)
    {
      options.UseSqlServer("Server=localhost,1433;Database=Blog;User ID=sa;Password=1q2w3e4r@#$");
    }

  }
}