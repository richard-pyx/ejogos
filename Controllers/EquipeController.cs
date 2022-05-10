using EJOGOS.Models;
using Microsoft.AspNetCore.Mvc;

namespace EJOGOS.Controllers
{
    public class EquipeController : Controller
    {

        //ActionResult representam os varios codigos HTTP

        //Codgitos HTTP - https://developer.mozilla.org/pt-BR/docs/Web/HTTP/Status.


        Equipe equipeModel = new Equipe();

        public IActionResult Index()
        {
            //ViewBag = Reserva de espaco para armazenas informações para recuperar na View.
            ViewBag.Equipes = equipeModel.LerEquipes();
            
            return View();
        }
    }
}
