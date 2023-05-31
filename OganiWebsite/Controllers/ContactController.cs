using Microsoft.AspNetCore.Mvc;
using OganiWebsite.DataAccessLayer;
using OganiWebsite.ViewModels;

namespace OganiWebsite.Controllers
{
    public class ContactController : Controller
    {
        private readonly AppDbContext _dbContext;

        public ContactController(AppDbContext appDbContext)

        {
            _dbContext = appDbContext;
        }

        public IActionResult Index()
        {
            var contactinfo=_dbContext?.Contacts?.ToList();

            var viewModel = new ContactViewModel
            {
                Contacts = contactinfo,
            };

            return View(viewModel);
        }
    }
}
