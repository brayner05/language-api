using System.ComponentModel.DataAnnotations;

namespace languages_app.Models;

public class Language {
    [Key]
    public Guid LanguageId { get; set; }

    public Guid LanguageFamilyId { get; set; } = Guid.Empty;

    public string Name { get; set; } = string.Empty;

    public string LocalName { get; set; } = string.Empty;

    public string SampleText { get; set; } = string.Empty;
}