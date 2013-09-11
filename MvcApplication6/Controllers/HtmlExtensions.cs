using System.Web;
using System.Web.Mvc;

namespace MvcApplication6.Controllers
{

    public static class HtmlExtensions
    {
    
      public static HtmlString JeffsExtension(this HtmlHelper html, string stuff)
      {
          
            return new HtmlString("<b>" + stuff + "</b>");

      }

    }

}