#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CosmoTrek_v3.Data;
using CosmoTrek_v3.Models;

namespace CosmoTrek_v3.Controllers
{
    public class TrekReservationController : Controller
    {
        private readonly ApplicationDbContext _context;

        public TrekReservationController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: TrekReservation
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.TrekReservations.Include(t => t.SpaceTravelIdentityUser);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: TrekReservation/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var trekReservation = await _context.TrekReservations
                .Include(t => t.SpaceTravelIdentityUser)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (trekReservation == null)
            {
                return NotFound();
            }

            return View(trekReservation);
        }

        // GET: TrekReservation/Create
        public IActionResult Create()
        {
            ViewData["SpaceTravelIdentityUserId"] = new SelectList(_context.Set<SpaceTravelIdentityUser>(), "Id", "Id");
            return View();
        }

        // POST: TrekReservation/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,TravelerName,Street,City,State,Zip,SpaceTravelIdentityUserId")] TrekReservation trekReservation)
        {
            if (ModelState.IsValid)
            {
                _context.Add(trekReservation);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["SpaceTravelIdentityUserId"] = new SelectList(_context.Set<SpaceTravelIdentityUser>(), "Id", "Id", trekReservation.SpaceTravelIdentityUserId);
            return View(trekReservation);
        }

        // GET: TrekReservation/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var trekReservation = await _context.TrekReservations.FindAsync(id);
            if (trekReservation == null)
            {
                return NotFound();
            }
            ViewData["SpaceTravelIdentityUserId"] = new SelectList(_context.Set<SpaceTravelIdentityUser>(), "Id", "Id", trekReservation.SpaceTravelIdentityUserId);
            return View(trekReservation);
        }

        // POST: TrekReservation/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,TravelerName,Street,City,State,Zip,SpaceTravelIdentityUserId")] TrekReservation trekReservation)
        {
            if (id != trekReservation.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(trekReservation);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TrekReservationExists(trekReservation.Id))
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
            ViewData["SpaceTravelIdentityUserId"] = new SelectList(_context.Set<SpaceTravelIdentityUser>(), "Id", "Id", trekReservation.SpaceTravelIdentityUserId);
            return View(trekReservation);
        }

        // GET: TrekReservation/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var trekReservation = await _context.TrekReservations
                .Include(t => t.SpaceTravelIdentityUser)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (trekReservation == null)
            {
                return NotFound();
            }

            return View(trekReservation);
        }

        // POST: TrekReservation/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var trekReservation = await _context.TrekReservations.FindAsync(id);
            _context.TrekReservations.Remove(trekReservation);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TrekReservationExists(int id)
        {
            return _context.TrekReservations.Any(e => e.Id == id);
        }
    }
}
