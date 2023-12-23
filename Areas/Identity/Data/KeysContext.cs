using Microsoft.AspNetCore.DataProtection.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Test.Areas.Identity.Data
{
    public class KeysContext : DbContext, IDataProtectionKeyContext
    {
        public KeysContext(DbContextOptions<KeysContext> options)
            : base(options) { }

        public DbSet<DataProtectionKey> DataProtectionKeys { get; set; }
    }
}
