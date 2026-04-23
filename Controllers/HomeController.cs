using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using inicio.Models;

namespace inicio.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        Grupo grupo  = new Grupo();
        ViewBag.Integrantes = grupo.DevolverIntegrantes();
        return View();
    }

    public IActionResult DetalleIntegrante (int dni)
    {
        Grupo grupo  = new Grupo();
        Integrante integrante = grupo.GetIntegrante(dni);
        ViewBag.Integrante = integrante;
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
