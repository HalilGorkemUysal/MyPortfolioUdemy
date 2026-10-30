using Microsoft.AspNetCore.Mvc;

namespace MyPortfolioUdemy.ViewComponents.AdminLayoutViewComponents
{
    public class AdminLayoutScriptViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
