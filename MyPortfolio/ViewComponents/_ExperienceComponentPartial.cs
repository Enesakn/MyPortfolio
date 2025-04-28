using Microsoft.AspNetCore.Mvc;
using MyPortfolio.DAL.Context;

namespace MyPortfolio.ViewComponents
{
    public class _ExperienceComponentPartial:ViewComponent
    {
        private readonly MyPortfolioDbContext _myPortfolioDbContext;
        public _ExperienceComponentPartial(MyPortfolioDbContext myPortfolioDbContext)
        {
            _myPortfolioDbContext = myPortfolioDbContext;
        }
        public IViewComponentResult Invoke()
        {
            var values = _myPortfolioDbContext.Experiences.ToList();
            return View(values);
        }
    }
}
