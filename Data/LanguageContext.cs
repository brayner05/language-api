using languages_app.Models;
using Microsoft.EntityFrameworkCore;

namespace languages_app.Data;

public class LanguageContext(DbContextOptions<LanguageContext> options) : DbContext(options) {
    public DbSet<Language> Languages { get; set; }
    public DbSet<LanguageFamily> LanguageFamilies { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder) {
        var indoEuropeanId = Guid.NewGuid();

        modelBuilder.Entity<LanguageFamily>().HasData(
            new LanguageFamily { LanguageFamilyId = indoEuropeanId, Name = "Indo-European" }
        );

        modelBuilder.Entity<Language>().HasData(
            new Language { LanguageId = Guid.NewGuid(), Name = "English", LocalName = "English", LanguageFamilyId = indoEuropeanId },
            new Language { LanguageId = Guid.NewGuid(), Name = "Italian", LocalName = "Italiano", LanguageFamilyId = indoEuropeanId },
            new Language { LanguageId = Guid.NewGuid(), Name = "German", LocalName = "Deutsch", LanguageFamilyId = indoEuropeanId }
        );
    }
}