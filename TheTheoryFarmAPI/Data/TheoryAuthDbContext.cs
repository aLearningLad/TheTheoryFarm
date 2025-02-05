using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace TheTheoryFarmAPI.Data
{
    public class TheoryAuthDbContext: IdentityDbContext
    {
        public TheoryAuthDbContext(DbContextOptions<TheoryAuthDbContext> options): base(options)
        {
        }

        // seeding data via onModelCreate method
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            var readerRoleId = "30ed823b-0e56-41e1-99ba-2f236cd967cb";
            var writerRoleId = "defb27d0-39cb-4b11-b8e0-e590e253931c";

            var roles = new List<IdentityRole>
            {
                new IdentityRole
                {
                    Id = readerRoleId,
                    ConcurrencyStamp = readerRoleId,
                    Name = "Reader",
                    NormalizedName = "Reader".ToUpper(),
                },
                new IdentityRole
                {
                    Id = writerRoleId,
                    ConcurrencyStamp = writerRoleId,
                    Name = "Writer",
                    NormalizedName = "Writer".ToUpper(),
                }
            };

            // seeding into builder object
            builder.Entity<IdentityRole>().HasData(roles);
        }

    }
}
