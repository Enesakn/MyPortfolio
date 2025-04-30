using Microsoft.AspNetCore.Mvc;
using MyPortfolio.DAL.Context;

namespace MyPortfolio.ViewComponents
{
    public class _ContactComponentPartial:ViewComponent
    {
        private readonly MyPortfolioDbContext _myPortfolioDbContext;
        public _ContactComponentPartial(MyPortfolioDbContext myPortfolioDbContext)
        {
            _myPortfolioDbContext = myPortfolioDbContext;
        }
        public IViewComponentResult Invoke()
        {
            var values=_myPortfolioDbContext.Contacts.ToList();
            var contactInfo = _myPortfolioDbContext.Contacts.FirstOrDefault();
            ViewBag.Description = contactInfo.Description;
            ViewBag.Tittle = contactInfo.Tittle;
            return View(values);
        }
    }
}
