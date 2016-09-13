using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ExemploCRUD.Models;


namespace ExemploCRUD.Controllers
{
    public class FuncionarioController : Controller
    {
        // GET: Funcionario
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Cadastrar()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Cadastrar(Funcionario f)
        {
            return View();
        }

        public ActionResult Listar()
        {
            return View();
        }
               
    }
}