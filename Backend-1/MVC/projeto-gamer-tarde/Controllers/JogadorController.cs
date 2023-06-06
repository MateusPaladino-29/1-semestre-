using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using projeto_gamer_tarde.Infra;
using projeto_gamer_tarde.Models;

namespace projeto_gamer_tarde.Controllers
{
    [Route("[controller]")]
    public class JogadorController : Controller
    {
        private readonly ILogger<JogadorController> _logger;

        public JogadorController(ILogger<JogadorController> logger)
        {
            _logger = logger;
        }

        Context c = new Context();

        [Route("Listar")]
        public IActionResult Index()
        {
            ViewBag.Jogador = c.Jogador.ToList();
            ViewBag.Equipe = c.Equipe.ToList();

            return View();
        }

        [Route("Cadastrar")]
        public IActionResult Cadastrar(IFormCollection form)
        {
            Jogador novoJogador = new Jogador();

            novoJogador.Nome = form["Nome"].ToString();
            novoJogador.Email = form["Email"].ToString();
            novoJogador.Senha = form["Senha"].ToString();
            novoJogador.IdEquipe = int.Parse(form["IdEquipe"].ToString());

            c.Jogador.Add(novoJogador);

            c.SaveChanges();
            

            return LocalRedirect("~/Jogador/Listar");
        }
    

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }



        [Route("Excluir/{id}")]
        public IActionResult Excluir(int id)
        {
            Jogador j = c.Jogador.First(j => j.IdJogador == id);

            c.Jogador.Remove(j);

            c.SaveChanges();

            return LocalRedirect("~/Jogador/Listar");
        }

        [Route("Editar/{id}")]

        public IActionResult Editar(int id)
        {
            Jogador j = c.Jogador.First(j => j.IdJogador == id);

            ViewBag.Equipe = c.Equipe.ToList();

            ViewBag.Jogador = j;

            return View("Edit");
        }


        [Route("Atualizar")]
        public IActionResult Atualizar(IFormCollection form, Jogador j, Equipe e)
        {

            Jogador novojogador = new Jogador();

            novojogador.IdJogador = int.Parse(form["IdJogador"].ToString());
            novojogador.Nome = form["Nome"].ToString();
            novojogador.Email = form["Email"].ToString();
            novojogador.Senha = form["Senha"].ToString();
            novojogador.IdEquipe = int.Parse(form["IdEquipe"].ToString());       

            novojogador.Nome = j.Nome;

    
            j.Nome = novojogador.Nome;
            j.Email = novojogador.Email;
            j.Senha = novojogador.Senha;
            j.IdEquipe = novojogador.IdEquipe;



            c.Jogador.Update(j);

           c.SaveChanges();

            return LocalRedirect("~/Jogador/Listar");



        }


    }
}