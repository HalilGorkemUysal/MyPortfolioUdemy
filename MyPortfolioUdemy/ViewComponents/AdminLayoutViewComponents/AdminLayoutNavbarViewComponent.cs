using Microsoft.AspNetCore.Mvc;

namespace MyPortfolioUdemy.ViewComponents.AdminLayoutViewComponents
{
    public class AdminLayoutNavbarViewComponent:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
