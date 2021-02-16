using ContactManagementSystemwebAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Contacts> Contacts { get; set; }
        public DbSet<ContactGroups> ContactGroups { get; set; }
        public DbSet<ContactTags> ContactTags { get; set; }
        public DbSet<Tags> Tags { get; set; }

    }
}