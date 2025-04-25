namespace MyPortfolio.DAL.Entities
{
    public class Portfolio
    {
        public int PortfolioId { get; set; }
        public string Tittle { get; set; }
        public string SubTittle { get; set; }
        public string ImageUrl { get; set; }
        public string Url { get; set; }
        public string Description{ get; set; }
    }
}
