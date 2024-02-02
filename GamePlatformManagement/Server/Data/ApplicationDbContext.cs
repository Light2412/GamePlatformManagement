using Duende.IdentityServer.EntityFramework.Options;
using GamePlatformManagement.Server.Configurations.Entities;
using GamePlatformManagement.Server.Models;
using GamePlatformManagement.Shared.Domain;
using Microsoft.AspNetCore.ApiAuthorization.IdentityServer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace GamePlatformManagement.Server.Data
{
    public class ApplicationDbContext : ApiAuthorizationDbContext<ApplicationUser>
    {
        public ApplicationDbContext(
            DbContextOptions options,
            IOptions<OperationalStoreOptions> operationalStoreOptions) : base(options, operationalStoreOptions)
        {
        }

        public DbSet<Game> Games { get; set; }
        public DbSet<Staff> Staffs { get; set;}

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.ApplyConfiguration(new GameSeedConfiguration());
        }
    }
}