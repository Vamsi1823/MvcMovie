using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace MvcMovie.Controllers;

// Defining a controller class named HelloWorldController that inherits from Controller class
public class HelloWorldController : Controller
{
    // Action method to handle requests to the default route
    public IActionResult Index()
    {
        return View();
    }

    // Action method to handle requests to the "Welcome" route with optional parameters
    public IActionResult Welcome(string name, int numTimes = 1)
    {
        ViewData["Message"] = "Hello " + name;
        ViewData["NumTimes"] = numTimes;
        return View();
    }
}