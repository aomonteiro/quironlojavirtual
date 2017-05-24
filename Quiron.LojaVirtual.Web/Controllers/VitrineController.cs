using Quiron.LojaVirtual.Dominio.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Quiron.LojaVirtual.Web.Controllers
{
    public class VitrineController : Controller
    {

        private ProductRepository _repository;
        public int productPerPage = 3;

        // GET: Vitrine
        public ActionResult ListProducts(int page = 1)
        {
            _repository = new ProductRepository();
            var products = _repository.Product
                .OrderBy(p => p.Name)
                .Skip((page - 1) * productPerPage)
                .Take(productPerPage);

            return View(products);
        }
    }
}