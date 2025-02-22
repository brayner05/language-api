namespace languages_app.Models;

public class LanguageFamily {
    public Guid LanguageFamilyId { get; init; }

    public string Name { get; set; } = string.Empty;

    public List<Language> Languages { get; set; } = [];
}