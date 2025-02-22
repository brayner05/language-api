using languages_app.Models;
using languages_app.Utilities;
using languages_app.Data;

namespace languages_app.Services;

public interface ILanguageFamilyService {
    List<LanguageFamily> GetAllLanguageFamilies();
    ServiceResult<LanguageFamily> GetLanguageFamilyById(Guid familyId);
    ServiceResult<LanguageFamily> AddLanguageFamily(LanguageFamily family);
    ServiceResult<LanguageFamily> UpdateLanguageFamilyById(Guid familyId, LanguageFamily newValues);
}


public class LanguageFamilyService(LanguageContext dbContext) : ILanguageFamilyService {
    public List<LanguageFamily> GetAllLanguageFamilies() {
        dbContext.Database.EnsureCreated();
        var languageFamilies = dbContext.LanguageFamilies.ToList();
        return languageFamilies;
    }

    public ServiceResult<LanguageFamily> GetLanguageFamilyById(Guid familyId) {
        dbContext.Database.EnsureCreated();
        var languageFamily = dbContext.LanguageFamilies.Find(familyId);
        var success = languageFamily is not null;
        return new ServiceResult<LanguageFamily>(success: success, value: languageFamily);
    }

    public ServiceResult<LanguageFamily> AddLanguageFamily(LanguageFamily family) {
        throw new NotImplementedException();
    }

    public ServiceResult<LanguageFamily> UpdateLanguageFamilyById(Guid familyId, LanguageFamily newValues) {
        throw new NotImplementedException();
    }
}