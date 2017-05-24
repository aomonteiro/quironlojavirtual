using Quiron.LojaVirtual.Web.Models;
using System;
using System.Text;
using System.Web.Mvc;

namespace Quiron.LojaVirtual.Web.HtmlHelpers
{
    public static class PaginationHelper
    {
        public static MvcHtmlString PageLinks(this HtmlHelper html, Pagination pagination, Func<int,string> pageurl)
        {
            StringBuilder result = new StringBuilder();

            for (int i = 1; i <= pagination.TotalPage; i++)
            {
                TagBuilder tag = new TagBuilder("a");
                tag.MergeAttribute("href", pageurl(i));
                tag.InnerHtml = i.ToString();
                if (i == pagination.CurrentPage)
                {
                    tag.AddCssClass("selected");
                    tag.AddCssClass("btn-primary");
                }
                tag.AddCssClass("btn btn-default");
                result.Append(tag);

            }

            return MvcHtmlString.Create(result.ToString());

        }

    }
}