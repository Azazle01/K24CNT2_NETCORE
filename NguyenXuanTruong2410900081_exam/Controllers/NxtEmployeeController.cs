
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NguyenXuanTruong2410900081_exam.Models;

public class NxtEmployeeController : Controller
{
    private readonly NxtEmployeeContext _context;

    public NxtEmployeeController(NxtEmployeeContext context)
    {
        _context = context;
    }

    // GET: NXTEMPLOYEES
    public async Task<IActionResult> index()    
    {
        return View(await _context.NxtEmployees.ToListAsync());
    }

    // GET: NXTEMPLOYEES/Details/5
    public async Task<IActionResult> Details(long? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        var nxtemployee = await _context.NxtEmployees
            .FirstOrDefaultAsync(m => m.Id == id);
        if (nxtemployee == null)
        {
            return NotFound();
        }

        return View(nxtemployee);
    }

    // GET: NXTEMPLOYEES/Create
    public IActionResult Create()
    {
        return View();
    }

    // POST: NXTEMPLOYEES/Create
    // To protect from overposting attacks, enable the specific properties you want to bind to.
    // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create([Bind("Id,NxtName,NxtGender,NxtBirthday,NxtEmail,NxtPhone,NxtActive")] NxtEmployee nxtemployee)
    {
        if (ModelState.IsValid)
        {
            _context.Add(nxtemployee);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        return View(nxtemployee);
    }

    // GET: NXTEMPLOYEES/Edit/5
    public async Task<IActionResult> Edit(long? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        var nxtemployee = await _context.NxtEmployees.FindAsync(id);
        if (nxtemployee == null)
        {
            return NotFound();
        }
        return View(nxtemployee);
    }

    // POST: NXTEMPLOYEES/Edit/5
    // To protect from overposting attacks, enable the specific properties you want to bind to.
    // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(long? id, [Bind("Id,NxtName,NxtGender,NxtBirthday,NxtEmail,NxtPhone,NxtActive")] NxtEmployee nxtemployee)
    {
        if (id != nxtemployee.Id)
        {
            return NotFound();
        }

        if (ModelState.IsValid)
        {
            try
            {
                _context.Update(nxtemployee);
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!NxtEmployeeExists(nxtemployee.Id))
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
        return View(nxtemployee);
    }

    // GET: NXTEMPLOYEES/Delete/5
    public async Task<IActionResult> Delete(long? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        var nxtemployee = await _context.NxtEmployees
            .FirstOrDefaultAsync(m => m.Id == id);
        if (nxtemployee == null)
        {
            return NotFound();
        }

        return View(nxtemployee);
    }

    // POST: NXTEMPLOYEES/Delete/5
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(long? id)
    {
        var nxtemployee = await _context.NxtEmployees.FindAsync(id);
        if (nxtemployee != null)
        {
            _context.NxtEmployees.Remove(nxtemployee);
        }

        await _context.SaveChangesAsync();
        return RedirectToAction(nameof(Index));
    }

    private bool NxtEmployeeExists(long? id)
    {
        return _context.NxtEmployees.Any(e => e.Id == id);
    }
}
