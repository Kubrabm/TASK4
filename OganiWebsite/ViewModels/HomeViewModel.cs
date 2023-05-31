using OganiWebsite.DataAccessLayer.Entities;
using OganiWebsite.DataAccessLayer.Entities.Home;

namespace OganiWebsite.ViewModels
{
    public class HomeViewModel
    {
        public List<Category>? Categories { get; set; }
        public List<Product>? Products { get; set; }
        public List<Banner>? Banners { get; set; }
        public List<AllDepartment>? AllDepartments { get; set;}
        public List<HeroSearch>? HeroSearches { get; set; }
        public List<TopProduct>? TopProducts { get; set; }
        public List<Blog>? Blogs { get; set; }
        public List<BlogTittle>? BlogsTittle { get; set;}
        public List<FFProduct>? FFFProducts { get; set;}


    }
}
