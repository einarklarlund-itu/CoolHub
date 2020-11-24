using System;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace CoolHub.Entities
{
    public interface ICoolHubContext : IDisposable
    {
        DbSet<Category> Categories { get; set; }
        DbSet<Topic> Topics { get; set; }
        DbSet<Resource> Resources { get; set; }
        DbSet<User> Users { get; set; }
        // Do we need any Many-to-many classes (like tasktags)?
        int SaveChanges();
        Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
    }
}
