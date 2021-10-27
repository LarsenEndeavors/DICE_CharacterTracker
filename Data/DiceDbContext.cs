using DICE_CharacterTracker.Models;
using DICE_CharacterTracker.Models.Domain;
using IdentityServer4.EntityFramework.Options;
using Microsoft.AspNetCore.ApiAuthorization.IdentityServer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace DICE_CharacterTracker.Data
{
    public class DiceDbContext : ApiAuthorizationDbContext<ApplicationUser>
    {
        public DiceDbContext(
            DbContextOptions options,
            IOptions<OperationalStoreOptions> operationalStoreOptions) : base(options, operationalStoreOptions)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<CharacterSheetStateField>()
                .HasKey(c => new { c.CharacterSheetStateId, c.CharacterSheetTemplateFieldId });
        }

        public DbSet<Character> Characters { get; set; }
        public DbSet<CharacterSheetState> CharacterSheetStates { get; set; }
        public DbSet<CharacterSheetStateField> CharacterSheetStateFields { get; set; }
        public DbSet<CharacterSheetTemplate> CharacterSheetTemplates { get; set; }
        public DbSet<CharacterSheetTemplateField> CharacterSheetTemplateFieldss { get; set; }
        public DbSet<Game> Games { get; set; }
        
    }
}