using Microsoft.AspNetCore.Mvc;
using MyPortfolioUdemy.DAL.Context;

namespace MyPortfolioUdemy.ViewComponents.AdminLayoutViewComponents
{
    public class AdminLayoutNavbarViewComponent:ViewComponent
    {
        private readonly MyPortfolioContext _context;

        public AdminLayoutNavbarViewComponent(MyPortfolioContext context)
        {
            _context = context;
        }

        public IViewComponentResult Invoke()
        {
            var values =  _context.ToDoLists.Where(x => x.Status == false).ToList();
            return View(values);
        }
    }
}
