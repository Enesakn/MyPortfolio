using Microsoft.AspNetCore.Mvc;
using MyPortfolio.DAL.Context;

namespace MyPortfolio.ViewComponents
{
    public class _SkillComponentPartial : ViewComponent
    {
        private readonly MyPortfolioDbContext _myPortfolioDbContext;
        public _SkillComponentPartial(MyPortfolioDbContext myPortfolioDbContext)
        {
            _myPortfolioDbContext = myPortfolioDbContext;
        }
        public IViewComponentResult Invoke()
        {
            var values = _myPortfolioDbContext.Skills.ToList();
            return View(values);
        }
    }
}
