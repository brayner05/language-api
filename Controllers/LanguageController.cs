using Microsoft.AspNetCore.Mvc;
using languages_app.Services;
using languages_app.ViewModels;

namespace languages_app.Controllers;

public class LanguageController(ILanguageService languageService) : Controller  {
    private readonly ILanguageService _languageService = languageService;

    // GET: LanguageController
    public IActionResult Index() {
        var languages = _languageService.GetAllLanguages();

        var viewModel = new LanguageListViewModel {
            Languages = languages
        };

        return View(viewModel);
    }

}
