using Microsoft.AspNetCore.Mvc;

namespace MyPortfolioUdemy.ViewComponents.AdminLayoutViewComponents
{
    public class AdminLayoutSidebarViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
