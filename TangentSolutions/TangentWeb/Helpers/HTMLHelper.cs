using Microsoft.AspNetCore.Mvc.Rendering;
using static System.String;

namespace TangentWeb.Helpers
{
    public static class HtmlHelper
    {
        public static string IsSelected(this IHtmlHelper html, string controller = null, string action = null)
        {
            var cssClass = "active open";
            var currentAction = (string)html.ViewContext.RouteData.Values["action"];
            var currentController = (string)html.ViewContext.RouteData.Values["controller"];

            if (IsNullOrEmpty(controller))
                controller = currentController;

            if (IsNullOrEmpty(action))
                action = currentAction;

            return controller == currentController && action == currentAction ?
                cssClass : Empty;
        }

        public static string PageClass(this IHtmlHelper html)
        {
            var currentAction = (string)html.ViewContext.RouteData.Values["action"];
            return currentAction;
        }
    }
}
