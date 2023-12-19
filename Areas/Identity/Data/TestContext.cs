using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Emit;
using Test.Areas.Identity.Data;

namespace Test.Data;

public class TestContext : IdentityDbContext<TestUser>
{
    public TestContext(DbContextOptions<TestContext> options) : base(options)
	{
	}
	
	public virtual DbSet<TestUser> Users => Set<TestUser>();

	protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
		base.OnModelCreating(modelBuilder);
	}
}