using languages_app.Models;

namespace languages_app.Repositories;

public static class LanguageRepository {
    private static readonly List<Language> _languages = [
        new Language { Name = "Italian", LocalName = "Italiano", SampleText = "Padre nostro, che sei nei cieli, Sia santificato il tuo nome. " },
        new Language { Name = "German", LocalName = "Deutsch" }
    ];

    public static List<Language> GetAllLanguages() {
        return _languages;
    }

    public static Language? GetLanguageById(Guid languageId) {
        var language = _languages.Find(lang => lang.LanguageId == languageId);
        return language;
    }
}