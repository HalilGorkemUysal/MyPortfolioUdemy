using Microsoft.AspNetCore.Mvc;

namespace MyPortfolioUdemy.ViewComponents.AdminLayoutViewComponents
{
    public class AdminLayoutHeadViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
