using static System.String;

namespace TangentWeb.Helpers
{
    public static class HtmlHelper
    {
        public static string IsSelected(this Microsoft.AspNetCore.Mvc.ViewFeatures.HtmlHelper html, string controller = null, string action = null)
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

        public static string PageClass(this Microsoft.AspNetCore.Mvc.ViewFeatures.HtmlHelper html)
        {
            var currentAction = (string)html.ViewContext.RouteData.Values["action"];
            return currentAction;
        }
    }
}
