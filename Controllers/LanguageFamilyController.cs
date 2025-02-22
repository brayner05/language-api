using languages_app.Services;
using Microsoft.AspNetCore.Mvc;

namespace languages_app.Controllers;

[Route("[controller]")]
public class LanguageFamilyController(LanguageFamilyService familyService) : Controller {
    private readonly ILanguageFamilyService _familyService = familyService;

    // GET: LanguageFamilyController
    [HttpGet("")]
    public ActionResult Index() {
        var families = _familyService.GetAllLanguageFamilies();
        return View(families);
    }

}
