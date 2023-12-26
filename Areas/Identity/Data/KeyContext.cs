using Microsoft.AspNetCore.DataProtection.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Test.Areas.Identity.Data
{
    public class KeyContext : DbContext, IDataProtectionKeyContext
    {
        public KeyContext(DbContextOptions<KeyContext> options)
            : base(options) { }

        public DbSet<DataProtectionKey> DataProtectionKeys { get; set; }

    }
}