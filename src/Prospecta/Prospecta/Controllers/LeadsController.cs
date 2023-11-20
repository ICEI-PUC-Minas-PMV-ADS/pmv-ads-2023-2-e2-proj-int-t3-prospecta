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

        public async Task<IActionResult> Index(string search) 
        {
            
            if (string.IsNullOrEmpty(search)) {
                var dados = await _context.Leads.ToListAsync();
                return View(dados);
            }
            else
            {
                var dados = await _context.Leads.Where(lead => lead.Cpf.ToLower().Contains(search) ||
                    lead.Nome.ToLower().Contains(search) ||
                    lead.Email.ToLower().Contains(search) ||
                    lead.Telefone.ToLower().Contains(search) ||
                    lead.Cidade.ToLower().Contains(search) ||
                    lead.Estado.ToLower().Contains(search) ||
                    lead.Endereco.ToLower().Contains(search) ||
                    lead.Interesse.ToLower().Contains(search) ||
                    lead.EmpresaPretendida.ToLower().Contains(search)
                ).ToListAsync();
                return View(dados);
            }

           
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

        public async Task<IActionResult> ToggleFavorito(int id)
        {
            var lead = await _context.Leads.FindAsync(id);

            if (lead == null)
            {
                return NotFound();
            }

            lead.Favorito = !lead.Favorito;

            try
            {
                _context.Update(lead);
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (lead == null)
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToAction(nameof(Details), new { id });
        }

    }
}
