using languages_app.Models;
using languages_app.Utilities;

namespace languages_app.Services;

public interface ILanguageFamilyService {
    List<LanguageFamily> GetAllLanguageFamilies();
    ServiceResult<LanguageFamily> GetLanguageFamilyById(Guid familyId);
    ServiceResult<LanguageFamily> AddLanguageFamily(LanguageFamily languageFamily);
    ServiceResult<LanguageFamily> UpdateLanguageFamilyById(Guid familyId, LanguageFamily newValues);
    ServiceResult<LanguageFamily> DeleteLanguageFamilyById(Guid familyId);
}

public class LanguageFamilyService : ILanguageFamilyService {
    public ServiceResult<LanguageFamily> AddLanguageFamily(LanguageFamily languageFamily) {
        throw new NotImplementedException();
    }

    public ServiceResult<LanguageFamily> DeleteLanguageFamilyById(Guid familyId) {
        throw new NotImplementedException();
    }

    public List<LanguageFamily> GetAllLanguageFamilies() {
        throw new NotImplementedException();
    }

    public ServiceResult<LanguageFamily> GetLanguageFamilyById(Guid familyId) {
        throw new NotImplementedException();
    }

    public ServiceResult<LanguageFamily> UpdateLanguageFamilyById(Guid familyId, LanguageFamily newValues) {
        throw new NotImplementedException();
    }
}