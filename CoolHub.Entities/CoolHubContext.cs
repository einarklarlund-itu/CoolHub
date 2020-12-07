using Microsoft.EntityFrameworkCore;
using System.Data.SQLite;
using System.Diagnostics;
using System.Threading.Tasks;

namespace CoolHub.Entities
{
    public class CoolHubContext : DbContext, ICoolHubContext
    {
        public static readonly string CategoriesDb = nameof(CategoriesDb).ToLower();

        public DbSet<Category> Categories { get; set; }
        public DbSet<Topic> Topics { get; set; }
        public DbSet<Resource> Resources { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Comment> Comments { get; set; }

        public CoolHubContext() 
        { 
            Debug.WriteLine($"{ContextId} context created.");
            Database.EnsureCreated();
        }

        public CoolHubContext(DbContextOptions<CoolHubContext> options)
            : base(options) 
        {
            Debug.WriteLine($"{ContextId} context created.");        
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                // Debug.WriteLine("OnConfiguring");

                // string cs = "Data Source=:memory:";
                // string stm = "SELECT SQLITE_VERSION()";

                // using var con = new SQLiteConnection(cs);
                // con.Open();

                var connectionString = @"Data Source=BINGUS\SQLEXPRESS;Initial Catalog=CoolHubDB;Integrated Security=True";

                optionsBuilder.UseSqlServer(connectionString);
            //    optionsBuilder.UseSqlite(@"Data Source=:memory:");
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
                
            modelBuilder.Entity<Resource>()
                .HasMany(r => r.Comments)
                .WithOne(c => c.Resource);

            modelBuilder.Entity<User>()
                .HasMany(u => u.Comments)
                .WithOne(c => c.User);

            modelBuilder.Entity<Category>()
                .HasIndex(c => c.Name)
                .IsUnique();

            modelBuilder.Entity<Topic>()
                .HasIndex(c => c.Name)
                .IsUnique();

            base.OnModelCreating(modelBuilder);
        }

        public override void Dispose()
        {
            Debug.WriteLine($"{ContextId} context disposed.");
            base.Dispose();
        }

        public override ValueTask DisposeAsync()
        {
            Debug.WriteLine($"{ContextId} context disposed async.");
            return base.DisposeAsync();
        }
    }
}
