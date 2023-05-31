using Microsoft.AspNetCore.Mvc;
using OganiWebsite.DataAccessLayer;
using OganiWebsite.DataAccessLayer.Entities;
using OganiWebsite.ViewModels;
using System.Security.Cryptography;

namespace OganiWebsite.Controllers
{
    public class ShopController : Controller
    {
        private readonly AppDbContext _dbContext;

        public ShopController(AppDbContext appDbContext)

        {
            _dbContext = appDbContext;
        }

        public IActionResult Index()
        {
            var sale=_dbContext?.Sales?.ToList();
            var discount=_dbContext?.Discounts?.ToList();
            var departmentshop=_dbContext?.DepartmentShops?.ToList();
            var color=_dbContext?.Colors?.ToList();
            var size=_dbContext?.Sizes?.ToList();
            var latestproduct=_dbContext?.LatestProducts?.ToList();
            var breadcrumb=_dbContext?.Breadcrumbs?.ToList();

            var viewModel = new ShopViewModel
            {
                Sales=sale,
                Discounts=discount,
                DepartmentShops = departmentshop,
                Colors=color,
                Sizes=size,
                LatestProducts=latestproduct,
                Breadcrumbs = breadcrumb,


            };

            return View(viewModel);
        }
    }
}
