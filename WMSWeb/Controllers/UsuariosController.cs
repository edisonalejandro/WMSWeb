using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WMSWeb.Models;

namespace WMSWeb.Controllers
{
    public class UsuariosController : Controller
    {
        private readonly ESSENTIALWMSContext _context;

        public UsuariosController(ESSENTIALWMSContext context)
        {
            _context = context;
        }

        // GET: Usuarios
        public async Task<IActionResult> Index()
        {
            var eSSENTIALWMSContext = _context.Usuario.Include(u => u.CodAlmacenNavigation);
            return View(await eSSENTIALWMSContext.ToListAsync());
        }

        // GET: Usuarios/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var usuario = await _context.Usuario
                .Include(u => u.CodAlmacenNavigation)
                .FirstOrDefaultAsync(m => m.CodAlmacen == id);
            if (usuario == null)
            {
                return NotFound();
            }

            return View(usuario);
        }

        // GET: Usuarios/Create
        public IActionResult Create()
        {
            ViewData["CodAlmacen"] = new SelectList(_context.Almacen, "CodAlmacen", "CodAlmacen");
            return View();
        }

        // POST: Usuarios/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("CodUsuario,CodAlmacen,Clave,NomUsuario,Rut,Estado,CodZona,AreaPicking,Dispositivo")] Usuario usuario)
        {
            if (ModelState.IsValid)
            {
                _context.Add(usuario);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["CodAlmacen"] = new SelectList(_context.Almacen, "CodAlmacen", "CodAlmacen", usuario.CodAlmacen);
            return View(usuario);
        }

        // GET: Usuarios/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var usuario = await _context.Usuario.FindAsync(id);
            if (usuario == null)
            {
                return NotFound();
            }
            ViewData["CodAlmacen"] = new SelectList(_context.Almacen, "CodAlmacen", "CodAlmacen", usuario.CodAlmacen);
            return View(usuario);
        }

        // POST: Usuarios/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("CodUsuario,CodAlmacen,Clave,NomUsuario,Rut,Estado,CodZona,AreaPicking,Dispositivo")] Usuario usuario)
        {
            if (id != usuario.CodAlmacen)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(usuario);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!UsuarioExists(usuario.CodAlmacen))
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
            ViewData["CodAlmacen"] = new SelectList(_context.Almacen, "CodAlmacen", "CodAlmacen", usuario.CodAlmacen);
            return View(usuario);
        }

        // GET: Usuarios/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var usuario = await _context.Usuario
                .Include(u => u.CodAlmacenNavigation)
                .FirstOrDefaultAsync(m => m.CodAlmacen == id);
            if (usuario == null)
            {
                return NotFound();
            }

            return View(usuario);
        }

        // POST: Usuarios/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var usuario = await _context.Usuario.FindAsync(id);
            _context.Usuario.Remove(usuario);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool UsuarioExists(string id)
        {
            return _context.Usuario.Any(e => e.CodAlmacen == id);
        }
    }
}
