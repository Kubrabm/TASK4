using Microsoft.AspNetCore.Mvc;
using OganiWebsite.DataAccessLayer;
using OganiWebsite.ViewModels;

namespace OganiWebsite.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _dbContext;

        public HomeController(AppDbContext appDbContext)
        {
            _dbContext = appDbContext;
        }

        public IActionResult Index()
        {
            var category = _dbContext?.Categories?.ToList();
            var product = _dbContext?.Products?.ToList();
            var banner = _dbContext?.Banners?.ToList();
            var alldepartment=_dbContext?.AllDepartments?.ToList();
            var herosearch=_dbContext?.HeroSearches?.ToList();
            var topproduct= _dbContext?.TopProducts?.ToList();
            var blog=_dbContext?.Blogs?.ToList();
            var blogtittle=_dbContext?.BlogsTittle?.ToList();
            var ffproduct=_dbContext?.FFProducts?.ToList();

            var viewModel = new HomeViewModel
            {
                Categories = category,
                Products = product,
                Banners = banner,
                AllDepartments=alldepartment,
                HeroSearches=herosearch,
                TopProducts=topproduct,
                Blogs=blog,
                BlogsTittle=blogtittle,
                FFFProducts=ffproduct,
            };

            return View(viewModel);
        }
    }
}
