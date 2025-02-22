using languages_app.Models;
using Microsoft.EntityFrameworkCore;

namespace languages_app.Data;

public class LanguageContext(DbContextOptions<LanguageContext> options) : DbContext(options) {
    public DbSet<Language> Languages { get; set; }
    public DbSet<LanguageFamily> LanguageFamilies { get; set; }
}