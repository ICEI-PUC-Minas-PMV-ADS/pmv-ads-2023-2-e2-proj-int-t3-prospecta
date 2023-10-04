using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Prospecta.Models;

namespace Prospecta.Controllers
{
    public class LeadsController : Controller
    {
        private readonly ProspectaDbContext _context;
        public LeadsController(ProspectaDbContext context) 
        {
            _context = context;
        }

        public async Task<IActionResult> Index() 
        { 
            var dados = await _context.Leads.ToListAsync();

            return View(dados);
        }

        public IActionResult Create() 
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Lead lead)
        {
            if (ModelState.IsValid) 
            {
                _context.Leads.Add(lead);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View();
        }
    }
}
