using Microsoft.EntityFrameworkCore;

namespace CoolHub.Entities
{
    public class CoolHubContext : DbContext, ICoolHubContext
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<Topic> Topics { get; set; }
        public DbSet<Resource> Resources { get; set; }
        public DbSet<User> Users { get; set; }

        public CoolHubContext() { }

        public CoolHubContext(DbContextOptions<CoolHubContext> options)
            : base(options) { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                var connectionString = @"Server=(localdb)\MSSQLLocalDB;Database=Kanban;Trusted_Connection=True;MultipleActiveResultSets=true";

                optionsBuilder.UseSqlServer(connectionString);
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // modelBuilder.Entity<TaskTag>()
                        // .HasKey(t => new { t.TaskId, t.TagId });

            // modelBuilder.Entity<Tag>()
            //             .HasIndex(t => t.Name)
            //             .IsUnique();

            // modelBuilder.Entity<User>()
            //             .HasIndex(t => t.EmailAddress)
            //             .IsUnique();

            modelBuilder.Entity<Category>()
                .HasMany(c => c.Topics)
                .WithOne(t => t.Category);
                // .IsRequired();

            modelBuilder.Entity<Topic>()
                .HasMany(t => t.Resources)
                .WithOne(r => r.Topic);
                // .IsRequired();
                
            modelBuilder.Entity<Resource>()
                .HasMany(r => r.Comments)
                .WithOne(c => c.Resource);
                // .IsRequired();

            modelBuilder.Entity<User>()
                .HasMany(u => u.Comments)
                .WithOne(c => c.User);
                // .IsRequired();

            modelBuilder.Entity<Category>()
                .HasIndex(c => c.Name)
                .IsUnique();

            modelBuilder.Entity<Topic>()
                .HasIndex(c => c.Name)
                .IsUnique();
        }
    }
}
