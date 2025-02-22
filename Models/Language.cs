namespace languages_app.Models;

public class Language {
    public Guid LanguageId { get; private set; } = Guid.NewGuid();

    public Guid LanguageFamilyId { get; set; } = Guid.Empty;

    public string Name { get; set; } = string.Empty;

    public string LocalName { get; set; } = string.Empty;

    public string SampleText { get; set; } = string.Empty;
}