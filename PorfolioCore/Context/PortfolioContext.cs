using Microsoft.EntityFrameworkCore;
using PorfolioCore.Entities;

namespace PorfolioCore.Context
{
    public class PortfolioContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-9TE47SL\\SQLEXPRESS;initial Catalog=PortfolioNightDb;integrated security=true;");
        }

        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Education> Educations { get; set; }
        public DbSet<Experience> Experiences { get; set; }
        public DbSet<Message> Messages { get; set; }
        public DbSet<Testimonial> Testimonials { get; set; }
        public DbSet<Skill> Skills { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Portfolio> Portfolios { get; set; }
        public DbSet<SocialMedia> SocialMedias { get; set; }
        public DbSet<Feature> Features { get; set; }
        public DbSet<About> Abouts { get; set; }
        public DbSet<Statistic> Statistics { get; set; }
        public DbSet<Resume> Resumes { get; set; }
        public DbSet<Service> Services { get; set; }
    }
}
//trust server certificate=true; 6.0 üstü kullananlar bu kısmı eklemeli.