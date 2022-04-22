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
    public class TrekPlanController : Controller
    {
        private readonly ApplicationDbContext _context;

        public TrekPlanController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: TrekPlan
        public async Task<IActionResult> Index()
        {
            return View(await _context.TrekPlans.ToListAsync());
        }

        // GET: TrekPlan/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var trekPlan = await _context.TrekPlans
                .FirstOrDefaultAsync(m => m.Id == id);
            if (trekPlan == null)
            {
                return NotFound();
            }

            return View(trekPlan);
        }

        // GET: TrekPlan/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: TrekPlan/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Destination,RocketType,LaunchDate,Mode,Distance,Duration,Cost")] TrekPlan trekPlan)
        {
            if (ModelState.IsValid)
            {
                _context.Add(trekPlan);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(trekPlan);
        }

        // GET: TrekPlan/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var trekPlan = await _context.TrekPlans.FindAsync(id);
            if (trekPlan == null)
            {
                return NotFound();
            }
            return View(trekPlan);
        }

        // POST: TrekPlan/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Destination,RocketType,LaunchDate,Mode,Distance,Duration,Cost")] TrekPlan trekPlan)
        {
            if (id != trekPlan.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(trekPlan);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TrekPlanExists(trekPlan.Id))
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
            return View(trekPlan);
        }

        // GET: TrekPlan/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var trekPlan = await _context.TrekPlans
                .FirstOrDefaultAsync(m => m.Id == id);
            if (trekPlan == null)
            {
                return NotFound();
            }

            return View(trekPlan);
        }

        // POST: TrekPlan/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var trekPlan = await _context.TrekPlans.FindAsync(id);
            _context.TrekPlans.Remove(trekPlan);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TrekPlanExists(int id)
        {
            return _context.TrekPlans.Any(e => e.Id == id);
        }
    }
}
