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
    public class DocumentoEntradasController : Controller
    {
        private readonly ESSENTIALWMSContext _context;

        public DocumentoEntradasController(ESSENTIALWMSContext context)
        {
            _context = context;
        }

        // GET: DocumentoEntradas
        public async Task<IActionResult> Index()
        {
            var eSSENTIALWMSContext = _context.DocumentoEntrada.Include(d => d.CodAlmacenNavigation).Include(d => d.CodProveedorNavigation);
            return View(await eSSENTIALWMSContext.ToListAsync());
        }

        // GET: DocumentoEntradas/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var documentoEntrada = await _context.DocumentoEntrada
                .Include(d => d.CodAlmacenNavigation)
                .Include(d => d.CodProveedorNavigation)
                .FirstOrDefaultAsync(m => m.NroEntrada == id);
            if (documentoEntrada == null)
            {
                return NotFound();
            }

            return View(documentoEntrada);
        }

        // GET: DocumentoEntradas/Create
        public IActionResult Create()
        {
            ViewData["CodAlmacen"] = new SelectList(_context.Almacen, "CodAlmacen", "CodAlmacen");
            ViewData["CodProveedor"] = new SelectList(_context.Proveedor, "CodProveedor", "CodProveedor");
            return View();
        }

        // POST: DocumentoEntradas/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("NroEntrada,CodAlmacen,NroDocEntrada,CodEstado,NroDocReferencia,CodDocEntrada,CodAlmacenOrigen,CodProveedor,Observaciones,FechaCreacion,FechaEmision,FecEstimadaRecepcion")] DocumentoEntrada documentoEntrada)
        {
            if (ModelState.IsValid)
            {
                _context.Add(documentoEntrada);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["CodAlmacen"] = new SelectList(_context.Almacen, "CodAlmacen", "CodAlmacen", documentoEntrada.CodAlmacen);
            ViewData["CodProveedor"] = new SelectList(_context.Proveedor, "CodProveedor", "CodProveedor", documentoEntrada.CodProveedor);
            return View(documentoEntrada);
        }

        // GET: DocumentoEntradas/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var documentoEntrada = await _context.DocumentoEntrada.FindAsync(id);
            if (documentoEntrada == null)
            {
                return NotFound();
            }
            ViewData["CodAlmacen"] = new SelectList(_context.Almacen, "CodAlmacen", "CodAlmacen", documentoEntrada.CodAlmacen);
            ViewData["CodProveedor"] = new SelectList(_context.Proveedor, "CodProveedor", "CodProveedor", documentoEntrada.CodProveedor);
            return View(documentoEntrada);
        }

        // POST: DocumentoEntradas/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("NroEntrada,CodAlmacen,NroDocEntrada,CodEstado,NroDocReferencia,CodDocEntrada,CodAlmacenOrigen,CodProveedor,Observaciones,FechaCreacion,FechaEmision,FecEstimadaRecepcion")] DocumentoEntrada documentoEntrada)
        {
            if (id != documentoEntrada.NroEntrada)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(documentoEntrada);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DocumentoEntradaExists(documentoEntrada.NroEntrada))
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
            ViewData["CodAlmacen"] = new SelectList(_context.Almacen, "CodAlmacen", "CodAlmacen", documentoEntrada.CodAlmacen);
            ViewData["CodProveedor"] = new SelectList(_context.Proveedor, "CodProveedor", "CodProveedor", documentoEntrada.CodProveedor);
            return View(documentoEntrada);
        }

        // GET: DocumentoEntradas/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var documentoEntrada = await _context.DocumentoEntrada
                .Include(d => d.CodAlmacenNavigation)
                .Include(d => d.CodProveedorNavigation)
                .FirstOrDefaultAsync(m => m.NroEntrada == id);
            if (documentoEntrada == null)
            {
                return NotFound();
            }

            return View(documentoEntrada);
        }

        // POST: DocumentoEntradas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var documentoEntrada = await _context.DocumentoEntrada.FindAsync(id);
            _context.DocumentoEntrada.Remove(documentoEntrada);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DocumentoEntradaExists(int id)
        {
            return _context.DocumentoEntrada.Any(e => e.NroEntrada == id);
        }
    }
}
