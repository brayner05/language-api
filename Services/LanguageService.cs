
using languages_app.Data;
using languages_app.Models;
using languages_app.Utilities;

namespace languages_app.Services;


/// <summary>
/// An interface for interacting with the Languages database context.
/// </summary>
public interface ILanguageService {
    List<Language> GetAllLanguages();
    ServiceResult<Language> GetLanguageById(Guid languageId);
    ServiceResult<Language> AddLanguage(Language language);
    ServiceResult<Language> UpdateLanguageById(Guid languageId, Language newValues);
    ServiceResult<Language> DeleteLanguageById(Guid languageId);
}


/// <summary>
/// Acts as an intermediary layer between the controller layer and the database layer. <c>LanguageService</c>
/// communicates with tha database and provides an interface to then get data from the database.
/// </summary>
/// <param name="dbContext">The database context to use.</param>
public class LanguageService(LanguageContext dbContext) : ILanguageService {
    public ServiceResult<Language> AddLanguage(Language language) {
        var existingLanguage = dbContext.Languages.Find(language.LanguageId);
        if (existingLanguage is not null) {
            return new ServiceResult<Language>(success: false, value: existingLanguage);
        }

        dbContext.Languages.Add(language);
        dbContext.SaveChanges();

        return new ServiceResult<Language>(success: true, value: language);
    }

    public ServiceResult<Language> DeleteLanguageById(Guid languageId) {
        throw new NotImplementedException();
    }

    public List<Language> GetAllLanguages() {
        dbContext.Database.EnsureCreated();
        var languages = dbContext.Languages.ToList();
        return languages;
    }

    public ServiceResult<Language> GetLanguageById(Guid languageId) {
        var language = dbContext.Languages.Find(languageId);
        var success = language is not null;
        return new ServiceResult<Language>(success: success, value: language);
    }

    public ServiceResult<Language> UpdateLanguageById(Guid languageId, Language newValues) {
        throw new NotImplementedException();
    }
}