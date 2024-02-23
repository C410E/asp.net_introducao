using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;


namespace MvcMovies.Controllers;
// dotnet watch run

public class HelloWorldController : Controller
{
    // GET: /HelloWorld/
    public string Index()
    {
        return "This is my default action...";
    }
    public string Welcome(string name, int ID = 1)
    {
        return HtmlEncoder.Default.Encode($"Hello {name}, ID: {ID}");
    }
}