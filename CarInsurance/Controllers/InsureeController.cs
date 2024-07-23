using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System;
using CarInsurance.Models;

public class InsureeController : Controller
{
    private readonly InsuranceEntities _context;

    public InsureeController(InsuranceEntities context)
    {
        _context = context;
    }

    // GET: Insuree
    public IActionResult Index()
    {
        var insurees = _context.Insurees.ToList();
        return View(insurees);
    }

    // GET: Insuree/Details/5
    public IActionResult Details(int? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        var insuree = _context.Insurees
            .FirstOrDefault(m => m.Id == id);
        if (insuree == null)
        {
            return NotFound();
        }

        return View(insuree);
    }

    // GET: Insuree/Create
    public IActionResult Create()
    {
        return View();
    }

    // POST: Insuree/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult Create([Bind("Id,FirstName,LastName,EmailAddress,DateOfBirth,CarYear,CarMake,CarModel,DUI,SpeedingTickets,CoverageType")] Insuree insuree)
    {
        if (ModelState.IsValid)
        {
            insuree.Quote = CalculateQuote(insuree);  // Calculate the quote
            _context.Add(insuree);
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }
        return View(insuree);
    }

    // GET: Insuree/Edit/5
    public IActionResult Edit(int? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        var insuree = _context.Insurees.Find(id);
        if (insuree == null)
        {
            return NotFound();
        }
        return View(insuree);
    }

    // POST: Insuree/Edit/5
    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult Edit(int id, [Bind("Id,FirstName,LastName,EmailAddress,DateOfBirth,CarYear,CarMake,CarModel,DUI,SpeedingTickets,CoverageType")] Insuree insuree)
    {
        if (id != insuree.Id)
        {
            return NotFound();
        }

        if (ModelState.IsValid)
        {
            try
            {
                insuree.Quote = CalculateQuote(insuree);  // Recalculate the quote in case of changes
                _context.Update(insuree);
                _context.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!InsureeExists(insuree.Id))
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
        return View(insuree);
    }

    // GET: Insuree/Delete/5
    public IActionResult Delete(int? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        var insuree = _context.Insurees
            .FirstOrDefault(m => m.Id == id);
        if (insuree == null)
        {
            return NotFound();
        }

        return View(insuree);
    }

    // POST: Insuree/Delete/5
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public IActionResult DeleteConfirmed(int id)
    {
        var insuree = _context.Insurees.Find(id);
        _context.Insurees.Remove(insuree);
        _context.SaveChanges();
        return RedirectToAction(nameof(Index));
    }

    // GET: Insuree/Admin
    public IActionResult Admin()
    {
        var insurees = _context.Insurees.ToList();
        return View(insurees);
    }

    private bool InsureeExists(int id)
    {
        return _context.Insurees.Any(e => e.Id == id);
    }

    private decimal CalculateQuote(Insuree insuree)
    {
        decimal baseQuote = 50;

        // Age-based calculations
        int age = DateTime.Now.Year - insuree.DateOfBirth.Year;
        if (insuree.DateOfBirth.Date > DateTime.Now.AddYears(-age)) age--;
        if (age <= 18) baseQuote += 100;
        else if (age <= 25) baseQuote += 50;
        else baseQuote += 25;

        // Car year-based calculations
        if (insuree.CarYear < 2000) baseQuote += 25;
        if (insuree.CarYear > 2015) baseQuote += 25;

        // Car make and model-based calculations
        if (insuree.CarMake == "Porsche") baseQuote += 25;
        if (insuree.CarMake == "Porsche" && insuree.CarModel == "911 Carrera") baseQuote += 25;

        // Speeding tickets
        baseQuote += insuree.SpeedingTickets * 10;

        // DUI and coverage type
        if (insuree.DUI) baseQuote *= 1.25m;
        if (insuree.CoverageType) baseQuote *= 1.50m;

        return baseQuote;
    }
}
