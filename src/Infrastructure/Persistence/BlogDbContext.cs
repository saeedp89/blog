using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Persistence;

public class BlogDbContext : DbContext
{
    public DbSet<Post>? Posts { get; set; }

    public BlogDbContext(DbContextOptions<BlogDbContext> context) : base(context)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        var post = builder.Entity<Post>();
        post.Property(x => x.Id).ValueGeneratedOnAdd();
        post.Property(x => x.Title).IsRequired();
        post.Property(x => x.Body).IsRequired();
        post.Property(x => x.CreatedAt)
            .ValueGeneratedOnAdd()
            .HasDefaultValueSql("GETUTCDATE()");
        base.OnModelCreating(builder);
    }
}