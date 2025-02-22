
using languages_app.Data;
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

public class LanguageService(LanguageContext dbContext) : ILanguageService {
    private readonly LanguageContext _dbContext = dbContext;

    public ServiceResult<Language> AddLanguage(Language language) {
        throw new NotImplementedException();
    }

    public ServiceResult<Language> DeleteLanguageById(Guid languageId) {
        throw new NotImplementedException();
    }

    public List<Language> GetAllLanguages() {
        var languages = _dbContext.Languages.ToList();
        return languages;
    }

    public ServiceResult<Language> GetLanguageById(Guid languageId) {
        var language = _dbContext.Languages.Find(languageId);
        var success = language is not null;
        return new ServiceResult<Language>(success: success, value: language);
    }

    public ServiceResult<Language> UpdateLanguageById(Guid languageId, Language newValues) {
        throw new NotImplementedException();
    }
}