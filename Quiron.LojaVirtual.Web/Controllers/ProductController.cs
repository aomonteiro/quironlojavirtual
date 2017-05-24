using Quiron.LojaVirtual.Dominio.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Quiron.LojaVirtual.Web.Controllers
{
    public class ProductController : Controller
    {
        private ProductRepository _repository;

        // GET: Product
        public ActionResult Index()
        {
            _repository = new ProductRepository();
            var products = _repository.Product.Take(10);

            return View(products);
        }
    }
}