using Quiron.LojaVirtual.Dominio.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiron.LojaVirtual.Dominio.Repository
{
    public class ProductRepository
    {
        private readonly EfDbContext _context = new EfDbContext();

        public IEnumerable<Product> Product
        {
            get { return _context.Product; }
        }

        
    }
}
