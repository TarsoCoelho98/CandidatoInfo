using CandidatoInfo.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Diagnostics;
using System.Globalization;

namespace CandidatoInfo.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            Candidato obj = new Candidato()
            {
                Nome = "Tarso Luiz Lopes Coelho",
                CargoPretendido = "Desenvolvedor Pleno",
                PretensaoSalarial = 4000,
                DataTeste = Convert.ToDateTime("01/12/2022", CultureInfo.GetCultureInfo("pt-BR"))
            };

            return View(obj);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
