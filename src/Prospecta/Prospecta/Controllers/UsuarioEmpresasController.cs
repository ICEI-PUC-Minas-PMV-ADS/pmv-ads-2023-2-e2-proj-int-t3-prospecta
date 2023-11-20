using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Prospecta.Models;

namespace Prospecta.Controllers
{
    
    public class UsuarioEmpresasController : Controller
    {
        private readonly ProspectaDbContext _context;

        public UsuarioEmpresasController(ProspectaDbContext context)
        {
            _context = context;
        }

        // GET: UsuarioEmpresas
        public async Task<IActionResult> Index()
        {
              return View(await _context.Usuarios.ToListAsync());
        }
        [AllowAnonymous]
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        
        public async Task<IActionResult> Login(UsuarioEmpresa usuario)
        {
            var usuarioDatabase = await _context.Usuarios
                .FirstOrDefaultAsync(u => u.Nome == usuario.Nome);
            if (usuarioDatabase == null)
            {
                ViewBag.Message = "Usuário e/ou senha inválidos";
                return View();
            }

            bool senhaOk = BCrypt.Net.BCrypt.Verify(usuario.Senha, usuarioDatabase.Senha);

            if(senhaOk)
            {
                var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name, usuarioDatabase.Nome),
                    new Claim(ClaimTypes.NameIdentifier, usuarioDatabase.Id.ToString()),
                    new Claim(ClaimTypes.Role, usuarioDatabase.Perfil.ToString())

                };

                var usuarioIdentity = new ClaimsIdentity(claims, "login");
                ClaimsPrincipal principal = new ClaimsPrincipal(usuarioIdentity);

                var props = new AuthenticationProperties
                {
                    AllowRefresh = true,
                    ExpiresUtc = DateTime.UtcNow.ToLocalTime().AddHours(8),
                    IsPersistent = true,
                };

                await HttpContext.SignInAsync(principal, props);

                return Redirect("/");
            }
            
            else
            {
                ViewBag.Message = "Usuário e/ou senha inválidos!";
            }
            return View();
        }

        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync();

            return RedirectToAction("Login", "UsuarioEmpresas");
        }

        // GET: UsuarioEmpresas/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Usuarios == null)
            {
                return NotFound();
            }

            var usuarioEmpresa = await _context.Usuarios
                .FirstOrDefaultAsync(m => m.Id == id);
            if (usuarioEmpresa == null)
            {
                return NotFound();
            }

            return View(usuarioEmpresa);
        }

        // GET: UsuarioEmpresas/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: UsuarioEmpresas/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Nome,Senha,Perfil")] UsuarioEmpresa usuarioEmpresa)
        {
            if (ModelState.IsValid)
            {
                usuarioEmpresa.Senha = BCrypt.Net.BCrypt.HashPassword(usuarioEmpresa.Senha);
                _context.Add(usuarioEmpresa);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(usuarioEmpresa);
        }

        // GET: UsuarioEmpresas/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Usuarios == null)
            {
                return NotFound();
            }

            var usuarioEmpresa = await _context.Usuarios.FindAsync(id);
            if (usuarioEmpresa == null)
            {
                return NotFound();
            }
            return View(usuarioEmpresa);
        }

        // POST: UsuarioEmpresas/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Nome,Senha,Perfil")] UsuarioEmpresa usuarioEmpresa)
        {
            if (id != usuarioEmpresa.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    usuarioEmpresa.Senha = BCrypt.Net.BCrypt.HashPassword(usuarioEmpresa.Senha);
                    _context.Update(usuarioEmpresa);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!UsuarioEmpresaExists(usuarioEmpresa.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(usuarioEmpresa);
        }

        // GET: UsuarioEmpresas/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Usuarios == null)
            {
                return NotFound();
            }

            var usuarioEmpresa = await _context.Usuarios
                .FirstOrDefaultAsync(m => m.Id == id);
            if (usuarioEmpresa == null)
            {
                return NotFound();
            }

            return View(usuarioEmpresa);
        }

        // POST: UsuarioEmpresas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Usuarios == null)
            {
                return Problem("Entity set 'ProspectaDbContext.Usuarios'  is null.");
            }
            var usuarioEmpresa = await _context.Usuarios.FindAsync(id);

            if (usuarioEmpresa != null)
            {
                _context.Usuarios.Remove(usuarioEmpresa);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool UsuarioEmpresaExists(int id)
        {
          return _context.Usuarios.Any(e => e.Id == id);
        }
    }
}
