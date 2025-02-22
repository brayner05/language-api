
using languages_app.Models;
using languages_app.Utilities;

namespace languages_app.Services;

public interface ILanguageService {
    List<Language> GetAllLanguages();
    ServiceResult<Language> GetLanguageById(Guid languageId);
    ServiceResult<Language> AddLanguage(Language language);
    ServiceResult<Language> UpdateLanguageById(Guid languageId, Language newValues);
    ServiceResult<Language> DeleteLanguageById(Guid languageId);
}

public class LanguageService : ILanguageService {
    public ServiceResult<Language> AddLanguage(Language language) {
        throw new NotImplementedException();
    }

    public ServiceResult<Language> DeleteLanguageById(Guid languageId) {
        throw new NotImplementedException();
    }

    public List<Language> GetAllLanguages() {
        return [];
    }

    public ServiceResult<Language> GetLanguageById(Guid languageId) {
        throw new NotImplementedException();
    }

    public ServiceResult<Language> UpdateLanguageById(Guid languageId, Language newValues) {
        throw new NotImplementedException();
    }
}