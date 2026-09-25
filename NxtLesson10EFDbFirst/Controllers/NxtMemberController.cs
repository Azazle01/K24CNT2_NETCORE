
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NxtLesson10EFDbFirst.Models;

public class NxtMemberController : Controller
{
    private readonly NxtK24cnt2lesson10EfdbContext _context;

    public NxtMemberController(NxtK24cnt2lesson10EfdbContext context)
    {
        _context = context;
    }

    // GET: NXTMEMBERS
    public async Task<IActionResult> index()    
    {
        return View(await _context.NxtMembers.ToListAsync());
    }

    // GET: NXTMEMBERS/Details/5
    public async Task<IActionResult> Details(long? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        var nxtmember = await _context.NxtMembers
            .FirstOrDefaultAsync(m => m.Id == id);
        if (nxtmember == null)
        {
            return NotFound();
        }

        return View(nxtmember);
    }

    // GET: NXTMEMBERS/Create
    public IActionResult Create()
    {
        return View();
    }

    // POST: NXTMEMBERS/Create
    // To protect from overposting attacks, enable the specific properties you want to bind to.
    // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create([Bind("Id,NxtUserName,NxtPassword,NxtFullName,NxtEmail,NxtPhone,NxtStatus")] NxtMember nxtmember)
    {
        if (ModelState.IsValid)
        {
            _context.Add(nxtmember);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        return View(nxtmember);
    }

    // GET: NXTMEMBERS/Edit/5
    public async Task<IActionResult> Edit(long? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        var nxtmember = await _context.NxtMembers.FindAsync(id);
        if (nxtmember == null)
        {
            return NotFound();
        }
        return View(nxtmember);
    }

    // POST: NXTMEMBERS/Edit/5
    // To protect from overposting attacks, enable the specific properties you want to bind to.
    // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(long? id, [Bind("Id,NxtUserName,NxtPassword,NxtFullName,NxtEmail,NxtPhone,NxtStatus")] NxtMember nxtmember)
    {
        if (id != nxtmember.Id)
        {
            return NotFound();
        }

        if (ModelState.IsValid)
        {
            try
            {
                _context.Update(nxtmember);
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!NxtMemberExists(nxtmember.Id))
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
        return View(nxtmember);
    }

    // GET: NXTMEMBERS/Delete/5
    public async Task<IActionResult> Delete(long? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        var nxtmember = await _context.NxtMembers
            .FirstOrDefaultAsync(m => m.Id == id);
        if (nxtmember == null)
        {
            return NotFound();
        }

        return View(nxtmember);
    }

    // POST: NXTMEMBERS/Delete/5
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(long? id)
    {
        var nxtmember = await _context.NxtMembers.FindAsync(id);
        if (nxtmember != null)
        {
            _context.NxtMembers.Remove(nxtmember);
        }

        await _context.SaveChangesAsync();
        return RedirectToAction(nameof(Index));
    }

    private bool NxtMemberExists(long? id)
    {
        return _context.NxtMembers.Any(e => e.Id == id);
    }
}
