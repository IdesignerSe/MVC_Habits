using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MVC_Habit.Models;

namespace MVC_Habit.Controllers
{
    public class ProgramSetsController : Controller
    {
        private readonly HabitContext _context;

        public ProgramSetsController(HabitContext context)
        {
            _context = context;
        }

        // GET: ProgramSets
        public async Task<IActionResult> Index()
        {
            return View(await _context.ProgramSet.ToListAsync());
        }

        // GET: ProgramSets/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var programSet = await _context.ProgramSet
                .FirstOrDefaultAsync(m => m.Id == id);
            if (programSet == null)
            {
                return NotFound();
            }

            return View(programSet);
        }

        // GET: ProgramSets/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: ProgramSets/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,NameProgram,TypeProgram,DurationProgram,Description,Observation")] ProgramSet programSet)
        {
            if (ModelState.IsValid)
            {
                _context.Add(programSet);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(programSet);
        }

        // GET: ProgramSets/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var programSet = await _context.ProgramSet.FindAsync(id);
            if (programSet == null)
            {
                return NotFound();
            }
            return View(programSet);
        }

        // POST: ProgramSets/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,NameProgram,TypeProgram,DurationProgram,Description,Observation")] ProgramSet programSet)
        {
            if (id != programSet.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(programSet);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProgramSetExists(programSet.Id))
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
            return View(programSet);
        }

        // GET: ProgramSets/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var programSet = await _context.ProgramSet
                .FirstOrDefaultAsync(m => m.Id == id);
            if (programSet == null)
            {
                return NotFound();
            }

            return View(programSet);
        }

        // POST: ProgramSets/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var programSet = await _context.ProgramSet.FindAsync(id);
            _context.ProgramSet.Remove(programSet);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ProgramSetExists(int id)
        {
            return _context.ProgramSet.Any(e => e.Id == id);
        }
    }
}
