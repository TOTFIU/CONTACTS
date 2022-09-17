using Microsoft.EntityFrameworkCore;
using WORK.Domain;

namespace WORK.DataBase
{
    public class DataBaseContext : DbContext
    {
        public DbSet<Contact> Contacts { get; set; }
        public DataBaseContext(DbContextOptions<DataBaseContext>? options)
            : base(options)
        {
            Database.EnsureCreated();
        }
    }
}
