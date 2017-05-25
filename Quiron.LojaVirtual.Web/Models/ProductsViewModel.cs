using Quiron.LojaVirtual.Dominio.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Quiron.LojaVirtual.Web.Models
{
    public class ProductsViewModel
    {
        public IEnumerable<Product> Products { get; set; }

        public Pagination Pagination { get; set; }

    }
}