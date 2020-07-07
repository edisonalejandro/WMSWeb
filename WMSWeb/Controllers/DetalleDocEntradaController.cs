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
    public class DetalleDocEntradaController : Controller
    {
        private readonly ESSENTIALWMSContext _context;

        public DetalleDocEntradaController(ESSENTIALWMSContext context)
        {
            _context = context;
        }

        // GET: DetalleDocEntrada
        public async Task<IActionResult> Index()
        {
            var eSSENTIALWMSContext = _context.DetalleDocEntrada.Include(d => d.DocumentoEntrada).Include(d => d.IdProductoNavigation);
            return View(await eSSENTIALWMSContext.ToListAsync());
        }

        // GET: DetalleDocEntrada/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var detalleDocEntrada = await _context.DetalleDocEntrada
                .Include(d => d.DocumentoEntrada)
                .Include(d => d.IdProductoNavigation)
                .FirstOrDefaultAsync(m => m.NroEntrada == id);
            if (detalleDocEntrada == null)
            {
                return NotFound();
            }

            return View(detalleDocEntrada);
        }

        // GET: DetalleDocEntrada/Create
        public IActionResult Create()
        {
            ViewData["NroEntrada"] = new SelectList(_context.DocumentoEntrada, "NroEntrada", "CodAlmacen");
            ViewData["IdProducto"] = new SelectList(_context.Producto, "IdProducto", "CodAlmacen");
            return View();
        }

        // POST: DetalleDocEntrada/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("NroEntrada,NroLinea,IdProducto,CodProducto,CodAlmacen,Cantidad,Lote,CodEstado,FechaCreacion,UsuarioCreacion,FechaModificacion,UsuarioModificacion")] DetalleDocEntrada detalleDocEntrada)
        {
            if (ModelState.IsValid)
            {
                _context.Add(detalleDocEntrada);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["NroEntrada"] = new SelectList(_context.DocumentoEntrada, "NroEntrada", "CodAlmacen", detalleDocEntrada.NroEntrada);
            ViewData["IdProducto"] = new SelectList(_context.Producto, "IdProducto", "CodAlmacen", detalleDocEntrada.IdProducto);
            return View(detalleDocEntrada);
        }

        // GET: DetalleDocEntrada/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var detalleDocEntrada = await _context.DetalleDocEntrada.FindAsync(id);
            if (detalleDocEntrada == null)
            {
                return NotFound();
            }
            ViewData["NroEntrada"] = new SelectList(_context.DocumentoEntrada, "NroEntrada", "CodAlmacen", detalleDocEntrada.NroEntrada);
            ViewData["IdProducto"] = new SelectList(_context.Producto, "IdProducto", "CodAlmacen", detalleDocEntrada.IdProducto);
            return View(detalleDocEntrada);
        }

        // POST: DetalleDocEntrada/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("NroEntrada,NroLinea,IdProducto,CodProducto,CodAlmacen,Cantidad,Lote,CodEstado,FechaCreacion,UsuarioCreacion,FechaModificacion,UsuarioModificacion")] DetalleDocEntrada detalleDocEntrada)
        {
            if (id != detalleDocEntrada.NroEntrada)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(detalleDocEntrada);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DetalleDocEntradaExists(detalleDocEntrada.NroEntrada))
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
            ViewData["NroEntrada"] = new SelectList(_context.DocumentoEntrada, "NroEntrada", "CodAlmacen", detalleDocEntrada.NroEntrada);
            ViewData["IdProducto"] = new SelectList(_context.Producto, "IdProducto", "CodAlmacen", detalleDocEntrada.IdProducto);
            return View(detalleDocEntrada);
        }

        // GET: DetalleDocEntrada/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var detalleDocEntrada = await _context.DetalleDocEntrada
                .Include(d => d.DocumentoEntrada)
                .Include(d => d.IdProductoNavigation)
                .FirstOrDefaultAsync(m => m.NroEntrada == id);
            if (detalleDocEntrada == null)
            {
                return NotFound();
            }

            return View(detalleDocEntrada);
        }

        // POST: DetalleDocEntrada/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var detalleDocEntrada = await _context.DetalleDocEntrada.FindAsync(id);
            _context.DetalleDocEntrada.Remove(detalleDocEntrada);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DetalleDocEntradaExists(int id)
        {
            return _context.DetalleDocEntrada.Any(e => e.NroEntrada == id);
        }
    }
}
