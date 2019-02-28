using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using BoomGaming.Models;
using Microsoft.AspNetCore.Authorization;

namespace BoomGaming.Controllers
{
    public class ObjectivesController : Controller
    {
        private readonly BoomGamingContext _context;

        public ObjectivesController(BoomGamingContext context)
        {
            _context = context;
        }

        // GET: Objectives
        [Authorize]
        public async Task<IActionResult> Index()
        {
            var objectives = _context.Objectives
                .AsNoTracking();
            return View(await objectives.ToListAsync());
        }

        // GET: Objectives/Details/5
        [Authorize]
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var objective = await _context.Objectives
                .FirstOrDefaultAsync(m => m.ObjectiveID == id);
            if (objective == null)
            {
                return NotFound();
            }

            return View(objective);
        }

        // GET: Objectives/Create
        [Authorize]
        public IActionResult Create()
        {
            return View();
        }

        // POST: Objectives/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize]
        public async Task<IActionResult> Create([Bind("ObjectiveID,GameName,Category,ObjectiveName,ValueMin,ValueAvg,ValueMax,EarnedPoints,StolentPoints")] Objective objective)
        {
            if (ModelState.IsValid)
            {
                _context.Add(objective);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(objective);
        }

        // GET: Objectives/Edit/5
        [Authorize]
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var objective = await _context.Objectives.FindAsync(id);
            if (objective == null)
            {
                return NotFound();
            }
            return View(objective);
        }

        // POST: Objectives/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize]
        public async Task<IActionResult> Edit(int id, [Bind("ObjectiveID,GameName,Category,ObjectiveName,ValueMin,ValueAvg,ValueMax,EarnedPoints,StolentPoints")] Objective objective)
        {
            if (id != objective.ObjectiveID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(objective);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ObjectiveExists(objective.ObjectiveID))
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
            return View(objective);
        }

        // GET: Objectives/Delete/5
        [Authorize]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var objective = await _context.Objectives
                .FirstOrDefaultAsync(m => m.ObjectiveID == id);
            if (objective == null)
            {
                return NotFound();
            }

            return View(objective);
        }

        // POST: Objectives/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        [Authorize]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var objective = await _context.Objectives.FindAsync(id);
            _context.Objectives.Remove(objective);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ObjectiveExists(int id)
        {
            return _context.Objectives.Any(e => e.ObjectiveID == id);
        }
    }
}
