using System;

namespace Quiron.LojaVirtual.Web.Models
{
    public class Pagination
    {
        public int TotalItens { get; set; }

        public int ItensPerPage { get; set; }

        public int CurrentPage { get; set; }

        public int TotalPage {
            get
            {
                return (int)Math.Ceiling((decimal)TotalItens / ItensPerPage);
            }            
        }
    }
}