using ControleDeEstoque.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ControleDeEstoque.Web.Controllers
{
    public class CadastroController : Controller
    {

        // GET: Cadastro
        private static List<GrupoProdutoModel> _listaGrupoProduto = new List<GrupoProdutoModel>()
        {
        new GrupoProdutoModel(){Id=1, Nome="livros", Ativo=true},
        new GrupoProdutoModel(){Id=2, Nome="Mouses", Ativo=true},
        new GrupoProdutoModel(){Id=3, Nome="Monitores", Ativo=false}
        };
        [Authorize]
        public ActionResult GrupoProduto()
        {
            return View(_listaGrupoProduto);
        }
        [HttpPost]
        [Authorize]
        public ActionResult RecuperarGrupoProduto (int id)
        {
            return Json(_listaGrupoProduto.Find(x => x.Id == id));
        }
        [Authorize]
        public ActionResult MarcaProduto()
        {
            return View();
        }
        [Authorize]
        public ActionResult LocalProduto()
        {
            return View();
        }
        [Authorize]
        public ActionResult UnidadeMedida()
        {
            return View();
        }
        [Authorize]
        public ActionResult Produto()
        {
            return View();
        }
        [Authorize]
        public ActionResult Pais()
        {
            return View();
        }
        [Authorize]
        public ActionResult Provincia()
        {
            return View();
        }
        [Authorize]
        public ActionResult Municipio()
        {
            return View();
        }
        [Authorize]
        public ActionResult Fornecedor()
        {
            return View();
        }
        [Authorize]
        public ActionResult PerfilUsuario()
        {
            return View();
        }
        [Authorize]
        public ActionResult Usuário()
        {
            return View();
        }
    }
}