using Microsoft.AspNetCore.Mvc;
using MyPortfolio.DAL.Context;

namespace MyPortfolio.ViewComponents
{
    public class _AboutComponentPartial : ViewComponent
    {
        private readonly MyPortfolioDbContext _myPortfolioDbContext;
        public _AboutComponentPartial(MyPortfolioDbContext myPortfolioDbContext)
        {
            _myPortfolioDbContext = myPortfolioDbContext;
        }
        public IViewComponentResult Invoke()
        {
            var aboutInfo = _myPortfolioDbContext.Abouts.FirstOrDefault(); 
            ViewBag.Title = aboutInfo.Tittle;
            ViewBag.SubDescription = aboutInfo.SubDescription;
            ViewBag.Details = aboutInfo.Details;
            return View();
        }
    } 
}

