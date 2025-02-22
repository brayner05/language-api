using Microsoft.AspNetCore.Mvc;
using languages_app.Services;
using languages_app.ViewModels;

namespace languages_app.Controllers;

[Route("[controller]")]
public class LanguageController(ILanguageService languageService) : Controller  {
    private readonly ILanguageService _languageService = languageService;

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
        var result = _languageService.GetLanguageById(id);

        if (!result.Success) {
            return NotFound();
        }

        var language = result.Value!;

        var viewModel = new LanguageViewModel {
            Name = language.Name,
            LocalName = language.LocalName,
            SampleText = language.SampleText
        };

        return View(viewModel);
    }
}
