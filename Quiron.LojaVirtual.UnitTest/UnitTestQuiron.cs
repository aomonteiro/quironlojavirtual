using Microsoft.VisualStudio.TestTools.UnitTesting;
using Quiron.LojaVirtual.Web.Models;
using System;
using System.Web;
using Quiron.LojaVirtual.Web.HtmlHelpers;
using System.Web.Mvc;

namespace Quiron.LojaVirtual.UnitTest
{
    [TestClass]
    public class UnitTestQuiron
    {
        [TestMethod]
        public void TestPagination()
        {
            HtmlHelper html = null;

            Pagination pagination = new Pagination
            {
                CurrentPage = 2,
                ItensPerPage = 10,
                TotalItens = 28,
            };

            Func<int, string> pageUrl = i => "Pagina" + i;

            MvcHtmlString result = html.PageLinks(pagination, pageUrl);

            Assert.AreEqual(

                @"<a class=""btn btn-default"" href=""Pagina1"">1</a>"
                + @"<a class=""btn btn-default btn-primary selected"" href=""Pagina2"">2</a>"
                + @"<a class=""btn btn-default"" href=""Pagina3"">3</a>", result.ToString()

                );
          
        }
    }
}
