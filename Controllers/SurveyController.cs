using Microsoft.AspNetCore.Mvc;
namespace DojoSurvey.Controllers;
public class Survey : Controller
{
    [HttpGet("")]
    public ViewResult Home()
    {
        return View("Home");
    }

    [HttpPost("survey")]
    public IActionResult Result(string name, string location, string language, string comment){
        ViewBag.name = name;
        ViewBag.location = location;
        ViewBag.language = language;
        ViewBag.comment = comment;
        return View("Result");
    }
}

