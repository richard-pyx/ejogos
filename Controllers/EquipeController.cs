using EJOGOS.Models;
using Microsoft.AspNetCore.Http;
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

        public IActionResult Cadastrar(IFormCollection form)
        {
            //criar um objeto equipe a partir do frontend.
            //IFormColletion

            Equipe novaEquipe = new Equipe();

            novaEquipe.idEquipe = int.Parse(form["IdEquipe"]);
            novaEquipe.Nome = form["Nome"];
            novaEquipe.Imagem = form["Imagem"];

            //chamar a função "Criar" passando um objeto do tipo equipe "novaEquipe".
            equipeModel.Criar(novaEquipe);

            ViewBag.Equipes = equipeModel.LerEquipes();
            


            return LocalRedirect("~/Equipe");
        }
    }
}
