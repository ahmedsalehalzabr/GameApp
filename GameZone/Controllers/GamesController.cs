using GameZone.Data;
using GameZone.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace GameZone.Controllers
{
    public class GamesController : Controller
    {
        private readonly AppDbContext _context;

        public GamesController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]

        public IActionResult Create() 
        {
            CreateGameFormVM viewModel = new()
            {
                Categories = _context.Categories
                .Select(c => new SelectListItem { Value = c.Id.ToString(), Text = c.Name })
                .OrderBy(c => c.Text)
                .ToList(),
                Devices = _context.Devices
                .Select(a => new SelectListItem { Value = a.Id.ToString(), Text = a.Name })
                .OrderBy(a => a.Text)
                .ToList()
            };
            return View(viewModel);
        }
    }
}
