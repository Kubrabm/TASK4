using Microsoft.EntityFrameworkCore;
using OganiWebsite.DataAccessLayer.Entities;
using OganiWebsite.DataAccessLayer.Entities.Home;

namespace OganiWebsite.DataAccessLayer
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public DbSet<Category>? Categories { get; set; }
        public DbSet<Product>? Products { get; set; }
        public DbSet<Banner>? Banners { get; set; }
        public DbSet<AllDepartment>? AllDepartments { get; set; }
        public DbSet<HeroSearch>? HeroSearches { get; set; }
        public DbSet<TopProduct>? TopProducts { get; set; }
        public DbSet<Blog>? Blogs { get; set; }
        public DbSet<BlogTittle> BlogsTittle { get; set; }
        public DbSet<ContactInfo>? Contacts { get; set; }
        public DbSet<Sale>? Sales { get; set; }
        public DbSet<Discount>? Discounts { get; set; }
        public DbSet<DepartmentShop>?DepartmentShops { get; set; }
        public DbSet<Color>?Colors { get; set; }
        public DbSet<Size>? Sizes { get; set; }
        public DbSet<LatestProduct>? LatestProducts { get; set;}
        public DbSet<Breadcrumb>?Breadcrumbs { get; set; }
        public DbSet<FFProduct>? FFProducts { get; set; }
    }
}