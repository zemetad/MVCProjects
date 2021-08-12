using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using LGX.Data;
using LGX.Models;

namespace LGX.Controllers
{
    public class ShelfController : Controller
    {
        private readonly LGXContext _context;

        public ShelfController(LGXContext context)
        {
            _context = context;
        }

        // GET:Shelf
        public async Task<IActionResult> Index()
        {
            var LGXContext = _context.Shelf.Include(s => s.RelayRack);
            return View(await LGXContext.ToListAsync());
        }

        // GET: Shelf/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var shelf = await _context.Shelf
                .Include(s => s.RelayRack)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (shelf == null)
            {
                return NotFound();
            }

            return View(shelf);
        }

        // GET: Shelf/Create
        public IActionResult Create()
        {
            ViewData["RelayRackId"] = new SelectList(_context.RelayRack, "Id", "Id");
            return View();
        }

        // POST: Shelves/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,DeviceType,RelayRackId")] Shelf Shelf)
        {
            if (ModelState.IsValid)
            {
                _context.Add(Shelf);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["RelayRackId"] = new SelectList(_context.RelayRack, "Id", "Id", Shelf.RelayRackId);
            return View(Shelf);
        }

        // GET: Shelves/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var Shelf = await _context.Shelf.FindAsync(id);
            if (Shelf == null)
            {
                return NotFound();
            }
            ViewData["RelayRackId"] = new SelectList(_context.RelayRack, "Id", "Id", Shelf.RelayRackId);
            return View(Shelf);
        }

        // POST: Shelves/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,DeviceType,RelayRackId")] Shelf Shelf)
        {
            if (id != Shelf.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(Shelf);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ShelfExists(Shelf.Id))
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
            ViewData["RelayRackId"] = new SelectList(_context.RelayRack, "Id", "Id", Shelf.RelayRackId);
            return View(Shelf);
        }

        // GET: Shelves/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var Shelf = await _context.Shelf
                .Include(s => s.RelayRack)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (Shelf == null)
            {
                return NotFound();
            }

            return View(Shelf);
        }

        // POST: Shelves/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var Shelf = await _context.Shelf.FindAsync(id);
            _context.Shelf.Remove(Shelf);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ShelfExists(int id)
        {
            return _context.Shelf.Any(e => e.Id == id);
        }
    }
}
