using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using DeBiLaba2.Contexts;
using DeBiLaba2.Models;

namespace DeBiLaba2.Controllers
{
    public class ShipTypesController : Controller
    {
        private readonly MyContext _context;

        public ShipTypesController(MyContext context)
        {
            _context = context;
        }

        // GET: ShipTypes
        public async Task<IActionResult> Index()
        {
              return _context.ShipTypes != null ? 
                          View(await _context.ShipTypes.ToListAsync()) :
                          Problem("Entity set 'MyContext.ShipTypes'  is null.");
        }

        // GET: ShipTypes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.ShipTypes == null)
            {
                return NotFound();
            }

            var shipType = await _context.ShipTypes
                .FirstOrDefaultAsync(m => m.Id == id);
            if (shipType == null)
            {
                return NotFound();
            }

            return View(shipType);
        }

        // GET: ShipTypes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: ShipTypes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,Description")] ShipType shipType)
        {
            if (ModelState.IsValid)
            {
                _context.Add(shipType);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(shipType);
        }

        // GET: ShipTypes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.ShipTypes == null)
            {
                return NotFound();
            }

            var shipType = await _context.ShipTypes.FindAsync(id);
            if (shipType == null)
            {
                return NotFound();
            }
            return View(shipType);
        }

        // POST: ShipTypes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,Description")] ShipType shipType)
        {
            if (id != shipType.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(shipType);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ShipTypeExists(shipType.Id))
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
            return View(shipType);
        }

        // GET: ShipTypes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.ShipTypes == null)
            {
                return NotFound();
            }

            var shipType = await _context.ShipTypes
                .FirstOrDefaultAsync(m => m.Id == id);
            if (shipType == null)
            {
                return NotFound();
            }

            return View(shipType);
        }

        // POST: ShipTypes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.ShipTypes == null)
            {
                return Problem("Entity set 'MyContext.ShipTypes'  is null.");
            }
            var shipType = await _context.ShipTypes.FindAsync(id);
            if (shipType != null)
            {
                _context.ShipTypes.Remove(shipType);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ShipTypeExists(int id)
        {
          return (_context.ShipTypes?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
