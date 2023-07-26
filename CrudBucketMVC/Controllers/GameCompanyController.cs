using Microsoft.AspNetCore.Mvc;
using CrudBucketMVC.DataAccess;
using CrudBucketMVC.Models;

namespace CrudBucketMVC.Controllers
{
    public class GameCompanyController : Controller
    {
        private readonly CrudBucketContext _context;

        public GameCompanyController(CrudBucketContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var companies = _context.GameCompanies;
            return View(companies);
        }

        public IActionResult Show(int id)
        {
            var company = _context.GameCompanies.Find(id);
            return View(company);
        }

        public IActionResult New()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(GameCompany gameCompany)
        {
            
            _context.GameCompanies.Add(gameCompany);
            _context.SaveChanges();

            
            var newGameCompanyId = gameCompany.Id;

            
            return RedirectToAction("show", new { id = newGameCompanyId });
        }

        [Route("GameCompany/{id:int}/edit")]
        public IActionResult Edit(int id)
        {
            var company = _context.GameCompanies.Find(id);
            return View(company);
        }
    }
}
