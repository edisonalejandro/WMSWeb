using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;
using WMSWeb.Models;

namespace WMSWeb.Controllers
{
    public class UbicacionFisicasController : Controller
    {
        private readonly ESSENTIALWMSContext _context;

        public UbicacionFisicasController(ESSENTIALWMSContext context)
        {
            _context = context;
        }

        // GET: UbicacionFisicas
        public async Task<IActionResult> Index()
        {
            var eSSENTIALWMSContext = _context.UbicacionFisica.Include(u => u.Cod).Include(u => u.CodAlmacenNavigation);
            return View(await eSSENTIALWMSContext.ToListAsync());
        }

        // GET: UbicacionFisicas/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ubicacionFisica = await _context.UbicacionFisica
                .Include(u => u.Cod)
                .Include(u => u.CodAlmacenNavigation)
                .FirstOrDefaultAsync(m => m.CodUbicacion == id);
            if (ubicacionFisica == null)
            {
                return NotFound();
            }

            return View(ubicacionFisica);
        }

        // GET: UbicacionFisicas/Create
        public IActionResult Create()
        {
            ViewData["CodZona"] = new SelectList(_context.ZonaUbicacion, "CodZona", "CodZona");
            ViewData["CodAlmacen"] = new SelectList(_context.Almacen, "CodAlmacen", "CodAlmacen");
            return View();
        }

        // POST: UbicacionFisicas/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("CodUbicacion,CodAlmacen,Hilera,Columna,Nivel,Calle,CodEstado,CodZona,FlujoPicking,TipoUm,CapacidadUm,CapacidadVolumen,TipoUbicacion,UltimaFechaConteo,Largo,Ancho,Alto,UbicacionReposicion,AreaPicking,TipoLpn")] UbicacionFisica ubicacionFisica)
        {
            if (ModelState.IsValid)
            {
                _context.Add(ubicacionFisica);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["CodZona"] = new SelectList(_context.ZonaUbicacion, "CodZona", "CodZona", ubicacionFisica.CodZona);
            ViewData["CodAlmacen"] = new SelectList(_context.Almacen, "CodAlmacen", "CodAlmacen", ubicacionFisica.CodAlmacen);
            return View(ubicacionFisica);
        }

        // GET: UbicacionFisicas/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ubicacionFisica = await _context.UbicacionFisica.FindAsync(id);
            if (ubicacionFisica == null)
            {
                return NotFound();
            }
            ViewData["CodZona"] = new SelectList(_context.ZonaUbicacion, "CodZona", "CodZona", ubicacionFisica.CodZona);
            ViewData["CodAlmacen"] = new SelectList(_context.Almacen, "CodAlmacen", "CodAlmacen", ubicacionFisica.CodAlmacen);
            return View(ubicacionFisica);
        }

        // POST: UbicacionFisicas/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("CodUbicacion,CodAlmacen,Hilera,Columna,Nivel,Calle,CodEstado,CodZona,FlujoPicking,TipoUm,CapacidadUm,CapacidadVolumen,TipoUbicacion,UltimaFechaConteo,Largo,Ancho,Alto,UbicacionReposicion,AreaPicking,TipoLpn")] UbicacionFisica ubicacionFisica)
        {
            if (id != ubicacionFisica.CodUbicacion)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(ubicacionFisica);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!UbicacionFisicaExists(ubicacionFisica.CodUbicacion))
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
            ViewData["CodZona"] = new SelectList(_context.ZonaUbicacion, "CodZona", "CodZona", ubicacionFisica.CodZona);
            ViewData["CodAlmacen"] = new SelectList(_context.Almacen, "CodAlmacen", "CodAlmacen", ubicacionFisica.CodAlmacen);
            return View(ubicacionFisica);
        }

        // GET: UbicacionFisicas/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ubicacionFisica = await _context.UbicacionFisica
                .Include(u => u.Cod)
                .Include(u => u.CodAlmacenNavigation)
                .FirstOrDefaultAsync(m => m.CodUbicacion == id);
            if (ubicacionFisica == null)
            {
                return NotFound();
            }

            return View(ubicacionFisica);
        }

        // POST: UbicacionFisicas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var ubicacionFisica = await _context.UbicacionFisica.FindAsync(id);
            _context.UbicacionFisica.Remove(ubicacionFisica);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool UbicacionFisicaExists(string id)
        {
            return _context.UbicacionFisica.Any(e => e.CodUbicacion == id);
        }
    }
}
