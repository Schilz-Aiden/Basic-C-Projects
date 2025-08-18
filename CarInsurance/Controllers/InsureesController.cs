using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CarInsurance.Data;
using CarInsurance.Models;

namespace CarInsurance.Controllers
{
    public class InsureesController : Controller
{
    private readonly InsuranceDbContext _context;

    public InsureesController(InsuranceDbContext context)
    {
        _context = context;
    }

    // GET: Insurees
    public async Task<IActionResult> Index()
    {
        return View(await _context.Insuree.ToListAsync());
    }

    // GET: Insurees/Details/5
    public async Task<IActionResult> Details(Guid? id)
    {
        if (id == null) return NotFound();

        var insuree = await _context.Insuree.FirstOrDefaultAsync(m => m.Id == id);
        if (insuree == null) return NotFound();

        return View(insuree);
    }

    // GET: Insurees/Create
    public IActionResult Create()
    {
        return View();
    }

    // POST: Insurees/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create([Bind("Id,FirstName,LastName,EmailAddress,DateOfBirth,CarYear,CarMake,CarModel,DUI,SpeedingTickets,CoverageType")] Insuree insuree)
    {
        if (ModelState.IsValid)
        {
            insuree.Id = Guid.NewGuid();

            // 🔹 Calculate Quote
            insuree.Quote = CalculateQuote(insuree);

            _context.Add(insuree);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        return View(insuree);
    }

    // GET: Insurees/Edit/5
    public async Task<IActionResult> Edit(Guid? id)
    {
        if (id == null) return NotFound();

        var insuree = await _context.Insuree.FindAsync(id);
        if (insuree == null) return NotFound();

        return View(insuree);
    }

    // POST: Insurees/Edit/5
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(Guid id, [Bind("Id,FirstName,LastName,EmailAddress,DateOfBirth,CarYear,CarMake,CarModel,DUI,SpeedingTickets,CoverageType")] Insuree insuree)
    {
        if (id != insuree.Id) return NotFound();

        if (ModelState.IsValid)
        {
            try
            {
                // 🔹 Recalculate Quote on edit
                insuree.Quote = CalculateQuote(insuree);

                _context.Update(insuree);
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!InsureeExists(insuree.Id)) return NotFound();
                else throw;
            }
            return RedirectToAction(nameof(Index));
        }
        return View(insuree);
    }

    // GET: Insurees/Delete/5
    public async Task<IActionResult> Delete(Guid? id)
    {
        if (id == null) return NotFound();

        var insuree = await _context.Insuree.FirstOrDefaultAsync(m => m.Id == id);
        if (insuree == null) return NotFound();

        return View(insuree);
    }

    // POST: Insurees/Delete/5
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(Guid id)
    {
        var insuree = await _context.Insuree.FindAsync(id);
        if (insuree != null)
        {
            _context.Insuree.Remove(insuree);
        }

        await _context.SaveChangesAsync();
        return RedirectToAction(nameof(Index));
    }

    private bool InsureeExists(Guid id)
    {
        return _context.Insuree.Any(e => e.Id == id);
    }

    // 🔹 Quote Calculation Logic
    private decimal CalculateQuote(Insuree insuree)
    {
        decimal quote = 50m;

        // Age
        var today = DateTime.Today;
        int age = today.Year - insuree.DateOfBirth.Year;
        if (insuree.DateOfBirth.Date > today.AddYears(-age)) age--;

        if (age <= 18) quote += 100;
        else if (age >= 19 && age <= 25) quote += 50;
        else quote += 25;

        // Car year
        if (insuree.CarYear < 2000) quote += 25;
        if (insuree.CarYear > 2015) quote += 25;

        // Car make/model
        if (!string.IsNullOrEmpty(insuree.CarMake) && insuree.CarMake.ToLower() == "porsche")
        {
            quote += 25;
            if (!string.IsNullOrEmpty(insuree.CarModel) && insuree.CarModel.ToLower() == "911 carrera")
            {
                quote += 25;
            }
        }

        // Speeding tickets
        quote += insuree.SpeedingTickets * 10;

        // DUI (25% more)
        if (insuree.DUI) quote *= 1.25m;

        // Full coverage (50% more)
        if (insuree.CoverageType) quote *= 1.5m;

        return quote;
    }

    // 🔹 Admin view (all insurees with quotes)
    public async Task<IActionResult> Admin()
    {
        var insurees = await _context.Insuree.ToListAsync();
        return View(insurees);
    }
}
}
