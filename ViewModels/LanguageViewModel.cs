using languages_app.Models;

namespace languages_app.ViewModels;

public class LanguageViewModel {
    public string Name { get; set; } = string.Empty;

    public string LanguageFamilyName { get; set; } = string.Empty;

    public string LocalName { get; set; } = string.Empty;

    public string SampleText { get; set; } = string.Empty;
}