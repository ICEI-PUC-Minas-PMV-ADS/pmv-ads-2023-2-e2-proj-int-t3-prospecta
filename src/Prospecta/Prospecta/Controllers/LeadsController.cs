using Microsoft.AspNetCore.Authorization;
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

        public async Task<IActionResult> Edit(int? id) 
        { 
            if(id == null)
                return NotFound();

            var dados = await _context.Leads.FindAsync(id);

            if (dados == null)
                return NotFound();

            return View(dados);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int id, Lead lead)
        {
            if(id != lead.Id)
                return NotFound();  

            if(ModelState.IsValid)
            {
                _context.Leads.Update(lead);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View();
        }
        public async Task<IActionResult> Details(int? id) 
        { 
            if(id == null)
                return NotFound();

            var dados = await _context.Leads.FindAsync(id);

            if (dados == null)
                return NotFound();
        
            return View(dados);
        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
                return NotFound();

            var dados = await _context.Leads.FindAsync(id);

            if (dados == null)
                return NotFound();

            return View(dados);
        }

        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(int? id)
        {
            if (id == null)
                return NotFound();

            var dados = await _context.Leads.FindAsync(id);

            if (dados == null)
                return NotFound();

            _context.Leads.Remove(dados);
            await _context.SaveChangesAsync();

            return RedirectToAction("Index");
        }
    }
}
