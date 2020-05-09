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
    public class ItemTypesController : Controller
    {
        private ApplicationDbContext _context;

        public ItemTypesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: ItemTypes
        public async Task<IActionResult> Index()
        {
            ViewData["Title"] = "Categorías";
            ViewData["Subtitle"] = "Lista de Categorías";

            return View(await _context.ItemTypes.ToListAsync());
        }

        // GET: ItemTypes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            ViewData["Title"] = "Productos";
            if (id == null)
            {
                return NotFound();
            }

            var itemType = await _context.ItemTypes
                .FirstOrDefaultAsync(m => m.Id == id);
            if (itemType == null)
            {
                return NotFound();
            }
            ViewData["Subtitle"] = "Detalles del producto: " + itemType.Name;
            return View(itemType);
        }

        [HttpGet]
        public async Task<IActionResult> Save(int? id)
        {
            ViewData["Title"] = "Productos";
            if (id == 0 || id == null)
            {
                ViewData["Subtitle"] = "Crear producto";
                return View(new ItemType() { IsActive = true, Username = User.Identity.Name });
            }
            ItemType itemType = await _context.ItemTypes.FindAsync(id);
            if (itemType == null)
            {
                return NotFound();
            }
            ViewData["Subtitle"] = "Modificar la talla: " + itemType.Name;
            return View(itemType);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Save(ItemType itemType)
        {
            if (ModelState.IsValid)
            {
                if (itemType.Id == 0)
                {
                    itemType.CreatedDate = DateTime.Now;
                    itemType.Username = User.Identity.Name;
                    _context.Add(itemType);
                    await _context.SaveChangesAsync();
                    return RedirectToAction(nameof(Index));
                }
                try
                {
                    itemType.ModifiedDate = DateTime.Now;
                    itemType.Username = User.Identity.Name;
                    _context.Update(itemType);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ItemTypeExists(itemType.Id))
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
            return View(itemType);
        }

        



        // GET: ItemTypes/Create
        public IActionResult Create()
        {
            return View(new ItemType() { IsActive = true });
        }

        // POST: ItemTypes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,Description,CreatedDate,ModifiedDate,IsActive,Username")] ItemType itemType)
        {
            if (ModelState.IsValid)
            {
                itemType.CreatedDate = DateTime.Now;
                itemType.Username = User.Identity.Name;
                _context.Add(itemType);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(itemType);
        }

        // GET: ItemTypes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var itemType = await _context.ItemTypes.FindAsync(id);
            if (itemType == null)
            {
                return NotFound();
            }
            return View(itemType);
        }

        // POST: ItemTypes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,Description,CreatedDate,ModifiedDate,IsActive,Username")] ItemType itemType)
        {
            if (id != itemType.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    itemType.ModifiedDate = DateTime.Now;
                    _context.Update(itemType);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ItemTypeExists(itemType.Id))
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
            return View(itemType);
        }

        //// GET: ItemTypes/Delete/5
        //public async Task<IActionResult> Delete(int? id)
        //{
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }

        //    var itemType = await _context.ItemTypes
        //        .FirstOrDefaultAsync(m => m.Id == id);
        //    if (itemType == null)
        //    {
        //        return NotFound();
        //    }

        //    return View(itemType);
        //}

        // POST: ItemTypes/Delete/5
        [HttpPost, ActionName("Delete")]
        //[ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var itemType = await _context.ItemTypes.FindAsync(id);
            _context.ItemTypes.Remove(itemType);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ItemTypeExists(int id)
        {
            return _context.ItemTypes.Any(e => e.Id == id);
        }
    }
}
