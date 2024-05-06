using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Smile.Models.Contact;

namespace Smile.Controllers;

public class ContactController : Controller
{
    private readonly ContactContext _context;

    public ContactController(ContactContext context)
    {
        _context = context;
    }

    // GET: ContactController
    public async Task<IActionResult> Index()
    {
        return View(await _context.Contacts.ToListAsync());
    }

    // GET: ContactController/Details/5
    public async Task<IActionResult> Details(int? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        var contact = await _context.Contacts
            .FirstOrDefaultAsync(m => m.ContactId == id);
        if (contact == null)
        {
            return NotFound();
        }

        return View(contact);
    }

    // GET: ContactController/Create
    public IActionResult Create()
    {
        return View();
    }

    // POST: ContactController/Create
    // To protect from overposting attacks, enable the specific properties you want to bind to.
    // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create([Bind("ContactId,Name,Email,Subject,Message")] Contact contact)
    {
        if (ModelState.IsValid)
        {
            _context.Add(contact);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        return View(contact);
    }

    // GET: ContactController/Edit/5
    public async Task<IActionResult> Edit(int? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        var contact = await _context.Contacts.FindAsync(id);
        if (contact == null)
        {
            return NotFound();
        }
        return View(contact);
    }

    /*// POST: ContactController/Edit/5
    // To protect from overposting attacks, enable the specific properties you want to bind to.
    // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(int id, [Bind("ContactId,Name,Email,Subject,Message")] ContactController contact)
    {
        if (id != contact.ContactId)
        {
            return NotFound();
        }

        if (ModelState.IsValid)
        {
            try
            {
                _context.Update(contact);
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ContactExists(contact.ContactId))
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
        return View(contact);
    }*/

    // GET: ContactController/Delete/5
    public async Task<IActionResult> Delete(int? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        var contact = await _context.Contacts
            .FirstOrDefaultAsync(m => m.ContactId == id);
        if (contact == null)
        {
            return NotFound();
        }

        return View(contact);
    }

    // POST: ContactController/Delete/5
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(int id)
    {
        var contact = await _context.Contacts.FindAsync(id);
        if (contact != null)
        {
            _context.Contacts.Remove(contact);
        }

        await _context.SaveChangesAsync();
        return RedirectToAction(nameof(Index));
    }

    private bool ContactExists(int id)
    {
        return _context.Contacts.Any(e => e.ContactId == id);
    }
}
