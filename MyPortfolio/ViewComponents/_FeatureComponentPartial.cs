using Microsoft.AspNetCore.Mvc;
using MyPortfolio.DAL.Context;

namespace MyPortfolio.ViewComponents
{
    public class _FeatureComponentPartial : ViewComponent
    {
        private readonly MyPortfolioDbContext _myPortfolioDbContext;

        public _FeatureComponentPartial(MyPortfolioDbContext myPortfolioDbContext)
        {
            _myPortfolioDbContext = myPortfolioDbContext;
        }

        public IViewComponentResult Invoke()
        {
            var values = _myPortfolioDbContext.Features.ToList();
            return View(values);
        }
    }
}
