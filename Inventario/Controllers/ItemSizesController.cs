using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Inventario.Data;
using Inventario.Models;
using Microsoft.AspNetCore.Authorization;

namespace Inventario.Controllers
{
    //[Authorize]
    public class ItemSizesController : Controller
    {
        private ApplicationDbContext _context;

        public ItemSizesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: ItemSizes
        public async Task<IActionResult> Index()
        {
            ViewData["Title"] = "Tallas";
            ViewData["Subtitle"] = "Lista de Tallas";
            return View(await _context.ItemSizes.ToListAsync());
        }

        // GET: ItemSizes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            ViewData["Title"] = "Tallas";
            if (id == null)
            {
                return NotFound();
            }

            var itemSize = await _context.ItemSizes
                .FirstOrDefaultAsync(m => m.Id == id);
            if (itemSize == null)
            {
                return NotFound();
            }
            ViewData["Subtitle"] = "Detalles de la talla: " + itemSize.Name;
            return View(itemSize);
        }

        [HttpGet]
        public async Task<IActionResult> Save(int? id)
        {
            ViewData["Title"] = "Tallas";
            if (id == 0 || id == null)
            {
                ViewData["Subtitle"] = "Crear talla";
                return View(new ItemSize() { IsActive = true, Username = User.Identity.Name });
            }
            ItemSize itemSize = await _context.ItemSizes.FindAsync(id);
            if (itemSize == null)
            {
                return NotFound();
            }
            ViewData["Subtitle"] = "Modificar la talla: " + itemSize.Name;
            return View(itemSize);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Save(ItemSize itemSize)
        {
            if (ModelState.IsValid)
            {
                if (itemSize.Id == 0)
                {
                    itemSize.CreatedDate = DateTime.Now;
                    itemSize.Username = User.Identity.Name;
                    _context.Add(itemSize);
                    await _context.SaveChangesAsync();
                    return RedirectToAction(nameof(Index));
                }
                try
                {
                    itemSize.ModifiedDate = DateTime.Now;
                    itemSize.Username = User.Identity.Name;
                    _context.Update(itemSize);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ItemSizeExists(itemSize.Id))
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
            return View(itemSize);
        }

        // GET: ItemSizes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: ItemSizes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,Description,CreatedDate,ModifiedDate,IsActive,Username")] ItemSize itemSize)
        {
            if (ModelState.IsValid)
            {
                itemSize.CreatedDate = DateTime.Now;
                _context.Add(itemSize);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(itemSize);
        }

        // GET: ItemSizes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var itemSize = await _context.ItemSizes.FindAsync(id);
            if (itemSize == null)
            {
                return NotFound();
            }
            return View(itemSize);
        }

        // POST: ItemSizes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,Description,CreatedDate,ModifiedDate,IsActive,Username")] ItemSize itemSize)
        {
            if (id != itemSize.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(itemSize);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ItemSizeExists(itemSize.Id))
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
            return View(itemSize);
        }

        //// GET: ItemSizes/Delete/5
        //public async Task<IActionResult> Delete(int? id)
        //{
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }

        //    var itemSize = await _context.ItemSizes
        //        .FirstOrDefaultAsync(m => m.Id == id);
        //    if (itemSize == null)
        //    {
        //        return NotFound();
        //    }

        //    return View(itemSize);
        //}

        // POST: ItemSizes/Delete/5
        [HttpPost, ActionName("Delete")]
        //[ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var itemSize = await _context.ItemSizes.FindAsync(id);
            _context.ItemSizes.Remove(itemSize);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ItemSizeExists(int id)
        {
            return _context.ItemSizes.Any(e => e.Id == id);
        }
    }
}
