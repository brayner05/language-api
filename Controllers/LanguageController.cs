using Microsoft.AspNetCore.Mvc;
using languages_app.Services;
using languages_app.ViewModels;
using languages_app.Models;

namespace languages_app.Controllers;

[Route("[controller]")]
public class LanguageController(ILanguageService languageService, ILanguageFamilyService familyService) : Controller  {
    private readonly ILanguageService _languageService = languageService;
    private readonly ILanguageFamilyService _familyService = familyService;

    // GET: LanguageController
    [HttpGet("")]
    public IActionResult Index() {
        var languages = _languageService.GetAllLanguages();

        var viewModel = new LanguageListViewModel {
            Languages = languages
        };

        return View(viewModel);
    }

    // GET: LanguageController{id}
    [HttpGet("{id:guid}")]
    public IActionResult LanguageInfo(Guid id) {
        // Find the language with the given `LanguageId`
        var languageResult = _languageService.GetLanguageById(id);
        if (!languageResult.Success) {
            return NotFound();
        }

        var languageName = languageResult.Value!;

        // Find the name of the corresponding language family, or default to string.Empty
        var languageFamilyResult = _familyService.GetLanguageFamilyById(languageName.LanguageFamilyId);
        var languageFamilyName = string.Empty;
        if (languageFamilyResult.Success) {
            languageFamilyName = languageFamilyResult.Value!.Name;
        }

        // Configure the view model
        var viewModel = new LanguageViewModel {
            Name = languageName.Name,
            LanguageFamilyName = languageFamilyName,
            LocalName = languageName.LocalName,
            SampleText = languageName.SampleText
        };

        // Render the view
        return View(viewModel);
    }

    [HttpPost]
    public IActionResult CreateLanguage([FromBody] Language language) {
        var addLanguageResult = _languageService.AddLanguage(language);
        if (!addLanguageResult.Success) {
            return BadRequest();
        }
        return Ok(language);
    }
}
