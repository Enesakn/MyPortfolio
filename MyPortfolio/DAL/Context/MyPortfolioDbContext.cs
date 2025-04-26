using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using MyPortfolio.DAL.Entities;

namespace MyPortfolio.DAL.Context
{
    public class MyPortfolioDbContext : DbContext
    {
        public MyPortfolioDbContext(DbContextOptions<MyPortfolioDbContext> options) : base(options) { }

        DbSet<About> Abouts { get; set; }
        DbSet<Contact> Contacts { get; set; }
        DbSet<Experience> Experiences { get; set; }
        DbSet<Feature> Features { get; set; }
        DbSet<Message> Messages { get; set; }
        DbSet<Portfolio> Portfolios { get; set; }
        DbSet<Skill> Skills { get; set; }
        DbSet<SocialMedia> SocialMedias { get; set; }
        DbSet<Testimonial> Testimonials { get; set; }

    }
}
