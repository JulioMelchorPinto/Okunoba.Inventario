using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Inventario.Data;
using Inventario.Models;
using Inventario.ViewModels;
using Microsoft.AspNetCore.Authorization;

namespace Inventario.Controllers
{
    //[Authorize]
    public class StocksController : Controller
    {
        private readonly ApplicationDbContext _context;

        public StocksController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Stocks
        //public async Task<IActionResult> Index()
        //{
        //    var applicationDbContext = _context.Stocks.Include(s => s.Company).Include(s => s.Item).Include(s => s.ItemSize).Include(s => s.ItemType);
        //    return View(await applicationDbContext.ToListAsync());
        //}

        public ActionResult Overview()
        {
            ViewData["Title"] = "Inventario";
            ICollection<ProductViewModel> overview = new HashSet<ProductViewModel>();
            foreach (var itemName in _context.Stocks.Select(r => r.Item.Name).Distinct())
            {
                overview.Add(new ProductViewModel()
                {
                    ProductName = itemName,
                    ProductTypes = _context.Stocks
                        .Where(x => x.Item.Name == itemName)
                        .Select(y => y.ItemType.Name)
                        .Distinct()
                        .ToList(),

                    ProductSizes = _context.Stocks
                        .Where(x => x.Item.Name == itemName)
                        .Select(y => y.ItemSize.Name)
                        .Distinct()
                        .ToList(),
                    SumAmount = _context.Stocks
                        .Where(x =>
                            x.Item.Name == itemName &&
                            x.StockType == StockType.Ingreso)
                        .Select(y =>
                            y.Quantity)
                        .Sum() -
                    _context.Stocks
                        .Where(x =>
                            x.Item.Name == itemName &&

                            x.StockType == StockType.Venta)
                        .Select(y =>
                            y.Quantity)
                        .Sum() -
                    _context.Stocks
                        .Where(x =>
                            x.Item.Name == itemName &&
                            x.StockType == StockType.Mortalidad)
                        .Select(y =>
                            y.Quantity)
                        .Sum(),
                    SumWeight = _context.Stocks
                        .Where(x =>
                            x.Item.Name == itemName &&
                            x.StockType == StockType.Ingreso)
                        .Select(y =>
                            y.Weight)
                        .Sum() -
                    _context.Stocks
                        .Where(x =>
                            x.Item.Name == itemName &&
                            x.StockType == StockType.Venta)
                        .Select(y =>
                            y.Weight)
                        .Sum() -
                    _context.Stocks
                        .Where(x =>
                            x.Item.Name == itemName &&
                            x.StockType == StockType.Mortalidad)
                        .Select(y =>
                            y.Weight)
                        .Sum(),
                });
            }
            return View(overview);
        }

        public ActionResult Budget()
        {
            ViewData["Title"] = "Inventario";
            ViewData["Subtitle"] = "Detalle de existencias";
            ViewData["Label"] = "Todos los productos";

            ICollection<StockViewModel> itemStock = new HashSet<StockViewModel>();
            foreach (var itemName in _context.Stocks.Select(r => r.Item.Name).Distinct())
            {
                StockViewModel svm = new StockViewModel()
                {
                    ItemName = itemName,
                    TotalQuantity = _context.Stocks
                        .Where(x =>
                            x.Item.Name == itemName &&
                            x.StockType == StockType.Ingreso)
                        .Select(y =>
                            y.Quantity)
                        .Sum() -
                    _context.Stocks
                        .Where(x =>
                            x.Item.Name == itemName &&

                            x.StockType == StockType.Venta)
                        .Select(y =>
                            y.Quantity)
                        .Sum() -
                    _context.Stocks
                        .Where(x =>
                            x.Item.Name == itemName &&
                            x.StockType == StockType.Mortalidad)
                        .Select(y =>
                            y.Quantity)
                        .Sum(),
                    TotalWeight = _context.Stocks
                        .Where(x =>
                            x.Item.Name == itemName &&
                            x.StockType == StockType.Ingreso)
                        .Select(y =>
                            y.Weight)
                        .Sum() -
                    _context.Stocks
                        .Where(x =>
                            x.Item.Name == itemName &&
                            x.StockType == StockType.Venta)
                        .Select(y =>
                            y.Weight)
                        .Sum() -
                    _context.Stocks
                        .Where(x =>
                            x.Item.Name == itemName &&
                            x.StockType == StockType.Mortalidad)
                        .Select(y =>
                            y.Weight)
                        .Sum(),
                };
                //ICollection<DetailsViewModel> itemSizes = new HashSet<DetailsViewModel>();
                //foreach (var itemSizeName in _context.Stocks.Where(x => x.Item.Name == itemName).Select(y => y.ItemSize.Name).Distinct())
                //{
                //    DetailsViewModel dvm = new DetailsViewModel()
                //    {
                //        ItemSizeName= itemSizeName,
                //        TotalQuantity = _context.Stocks
                //            .Where(x =>
                //                x.Item.Name == itemName &&
                //                x.ItemSize.Name == itemSizeName &&
                //                x.StockType == StockType.Ingreso)
                //            .Select(y =>
                //                y.Quantity)
                //            .Sum() -
                //        _context.Stocks
                //            .Where(x =>
                //                x.Item.Name == itemName &&
                //                x.ItemSize.Name == itemSizeName &&
                //                x.StockType == StockType.Venta)
                //            .Select(y =>
                //                y.Quantity)
                //            .Sum() -
                //        _context.Stocks
                //            .Where(x =>
                //                x.Item.Name == itemName &&
                //                x.ItemSize.Name == itemSizeName &&
                //                x.StockType == StockType.Mortalidad)
                //            .Select(y =>
                //                y.Quantity)
                //            .Sum(),
                //     TotalWeight = _context.Stocks
                //            .Where(x =>
                //                x.Item.Name == itemName &&
                //                x.ItemSize.Name == itemSizeName &&
                //                x.StockType == StockType.Ingreso)
                //            .Select(y =>
                //                y.Weight)
                //            .Sum() -
                //    _context.Stocks
                //            .Where(x =>
                //                x.Item.Name == itemName &&
                //                x.ItemSize.Name == itemSizeName &&
                //                x.StockType == StockType.Venta)
                //            .Select(y =>
                //                y.Weight)
                //            .Sum() -
                //    _context.Stocks
                //            .Where(x =>
                //                x.Item.Name == itemName &&
                //                x.ItemSize.Name == itemSizeName &&
                //                x.StockType == StockType.Mortalidad)
                //            .Select(y =>
                //                y.Weight)
                //            .Sum()
                //    };
                //    svm.DetailsList.Add(dvm);
                //}
                itemStock.Add(svm);
            }
            return View(itemStock);
        }

        public ActionResult ItemType(string prodName)
        {
            ViewData["Title"] = "Inventario";
            ViewData["Subtitle"] = "Detalle de existencias";
            ViewData["Label"] = "Todos los productos";
            ViewData["Item"] = prodName;
            ICollection<ItemInStock> stockList = new List<ItemInStock>();
            foreach (var itemType in _context.Stocks.Where(s => s.Item.Name == prodName).Select(r => r.ItemType.Name).Distinct())
            {
                stockList.Add(new ItemInStock()
                {
                    ItemName = prodName,
                    ItemTypeName = itemType,
                    Quantity = _context.Stocks
                            .Where(s => s.Item.Name == prodName && s.ItemType.Name == itemType && s.StockType == StockType.Ingreso)
                            .Select(r => r.Quantity).Sum() -
                        _context.Stocks
                            .Where(s => s.Item.Name == prodName && s.ItemType.Name == itemType && s.StockType == StockType.Venta)
                            .Select(r => r.Quantity).Sum() -
                        _context.Stocks
                            .Where(s => s.Item.Name == prodName && s.ItemType.Name == itemType && s.StockType == StockType.Mortalidad)
                            .Select(r => r.Quantity).Sum(),
                    Weight = _context.Stocks
                            .Where(s => s.Item.Name == prodName && s.ItemType.Name == itemType && s.StockType == StockType.Ingreso)
                            .Select(r => r.Weight).Sum() -
                        _context.Stocks
                            .Where(s => s.Item.Name == prodName && s.ItemType.Name == itemType && s.StockType == StockType.Venta)
                            .Select(r => r.Weight).Sum() -
                        _context.Stocks
                            .Where(s => s.Item.Name == prodName && s.ItemType.Name == itemType && s.StockType == StockType.Mortalidad)
                            .Select(r => r.Weight).Sum()
                });
            }
            return View(stockList);
        }




        public ActionResult ItemSize(string prodName, string prodType)
        {
            ViewData["Title"] = "Inventario";
            ViewData["Subtitle"] = "Detalle de existencias";
            ViewData["Label"] = "Todos los productos";
            ViewData["Item"] = prodName;
            ViewData["ItemType"] = prodType;
            ICollection<ItemInStock> stockList = new List<ItemInStock>();
           foreach (var itemSize in _context.Stocks.Where(s => s.Item.Name == prodName && s.ItemType.Name==prodType).Select(r => r.ItemSize.Name).Distinct())
            {
                stockList.Add(new ItemInStock()
                {
                    ItemName = prodName,
                    ItemSizeName = itemSize,
                    ItemTypeName = prodType,
                    Quantity = _context.Stocks
                            .Where(s => s.Item.Name == prodName && s.ItemType.Name == prodType && s.ItemSize.Name == itemSize && s.StockType == StockType.Ingreso)
                            .Select(r => r.Quantity).Sum() -
                        _context.Stocks
                            .Where(s => s.Item.Name == prodName && s.ItemType.Name == prodType && s.ItemSize.Name == itemSize && s.StockType == StockType.Venta)
                            .Select(r => r.Quantity).Sum() -
                        _context.Stocks
                            .Where(s => s.Item.Name == prodName && s.ItemType.Name == prodType && s.ItemSize.Name == itemSize && s.StockType == StockType.Mortalidad)
                            .Select(r => r.Quantity).Sum(),
                    Weight = _context.Stocks
                            .Where(s => s.Item.Name == prodName && s.ItemType.Name == prodType && s.ItemSize.Name == itemSize && s.StockType == StockType.Ingreso)
                            .Select(r => r.Weight).Sum() -
                        _context.Stocks
                            .Where(s => s.Item.Name == prodName && s.ItemType.Name == prodType && s.ItemSize.Name == itemSize && s.StockType == StockType.Venta)
                            .Select(r => r.Weight).Sum() -
                        _context.Stocks
                            .Where(s => s.Item.Name == prodName && s.ItemType.Name == prodType && s.ItemSize.Name == itemSize && s.StockType == StockType.Mortalidad)
                            .Select(r => r.Weight).Sum()
                });
            }
            return View(stockList);
        }



        // GET: Stocks
        public async Task<ActionResult> Index()
        {
            ViewData["Title"] = "Inventario";
            ViewData["Subtitle"] = "Buscar en todos los registros";
            var stocks = _context.Stocks
                .Include(s => s.Company)
                .Include(s => s.Item)
                .Include(s => s.ItemType)
                .Include(s => s.ItemSize);
            return View(await stocks.ToListAsync());
        }

        // GET: Stocks/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            ViewData["Title"] = "Inventario";
            ViewData["Subtitle"] = "Información del registro";
            if (id == null)
            {
                return NotFound();
            }

            var stock = await _context.Stocks
                .Include(s => s.Company)
                .Include(s => s.Item)
                .Include(s => s.ItemSize)
                .Include(s => s.ItemType)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (stock == null)
            {
                return NotFound();
            }

            return View(stock);
        }

        // GET: Stocks/Create
        public IActionResult Create()
        {
            ViewData["Title"] = "Inventario";
            ViewData["Subtitle"] = "Nuevo registro de inventario";
            ViewData["CompanyId"] = new SelectList(_context.Companies, "Id", "Name");
            ViewData["ItemId"] = new SelectList(_context.Items, "Id", "Name");
            ViewData["ItemSizeId"] = new SelectList(_context.ItemSizes, "Id", "Name");
            ViewData["ItemTypeId"] = new SelectList(_context.ItemTypes, "Id", "Name");
            Stock newStock = new Stock() { IsActive = true };
            return View(newStock);
        }

        // POST: Stocks/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,StockType,ItemId,ItemTypeId,CompanyId,ItemSizeId,Quantity,Weight,CreatedDate,ModifiedDate,IsActive,Username")] Stock stock)
        {
            if (ModelState.IsValid)
            {
                
                stock.CreatedDate = DateTime.Now;
                stock.Username = User.Identity.Name;
                _context.Add(stock);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Budget));
            }
            ViewData["Title"] = "Inventario";
            ViewData["Subtitle"] = "Nuevo registro de inventario";
            ViewData["CompanyId"] = new SelectList(_context.Companies, "Id", "Name", stock.CompanyId);
            ViewData["ItemId"] = new SelectList(_context.Items, "Id", "Name", stock.ItemId);
            ViewData["ItemSizeId"] = new SelectList(_context.ItemSizes, "Id", "Name", stock.ItemSizeId);
            ViewData["ItemTypeId"] = new SelectList(_context.ItemTypes, "Id", "Name", stock.ItemTypeId);
            return View(stock);
        }

        // GET: Stocks/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var stock = await _context.Stocks.FindAsync(id);
            if (stock == null)
            {
                return NotFound();
            }
            ViewData["Title"] = "Inventario";
            ViewData["Subtitle"] = "Modifica el registro de inventario";
            ViewData["CompanyId"] = new SelectList(_context.Companies, "Id", "Name", stock.CompanyId);
            ViewData["ItemId"] = new SelectList(_context.Items, "Id", "Name", stock.ItemId);
            ViewData["ItemSizeId"] = new SelectList(_context.ItemSizes, "Id", "Name", stock.ItemSizeId);
            ViewData["ItemTypeId"] = new SelectList(_context.ItemTypes, "Id", "Name", stock.ItemTypeId);
            return View(stock);
        }

        // POST: Stocks/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,StockType,ItemId,ItemTypeId,CompanyId,ItemSizeId,Quantity,Weight,CreatedDate,ModifiedDate,IsActive,Username")] Stock stock)
        {
            if (id != stock.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    stock.ModifiedDate = DateTime.Now;
                    stock.Username = User.Identity.Name;
                    _context.Update(stock);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!StockExists(stock.Id))
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
            ViewData["Title"] = "Inventario";
            ViewData["Subtitle"] = "Modificar registro de inventario";
            ViewData["CompanyId"] = new SelectList(_context.Companies, "Id", "Name", stock.CompanyId);
            ViewData["ItemId"] = new SelectList(_context.Items, "Id", "Name", stock.ItemId);
            ViewData["ItemSizeId"] = new SelectList(_context.ItemSizes, "Id", "Name", stock.ItemSizeId);
            ViewData["ItemTypeId"] = new SelectList(_context.ItemTypes, "Id", "Name", stock.ItemTypeId);
            return View(stock);
        }

        //// GET: Stocks/Delete/5
        //public async Task<IActionResult> Delete(int? id)
        //{
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }

        //    var stock = await _context.Stocks
        //        .Include(s => s.Company)
        //        .Include(s => s.Item)
        //        .Include(s => s.ItemSize)
        //        .Include(s => s.ItemType)
        //        .FirstOrDefaultAsync(m => m.Id == id);
        //    if (stock == null)
        //    {
        //        return NotFound();
        //    }

        //    return View(stock);
        //}

        // POST: Stocks/Delete/5
        [HttpPost, ActionName("Delete")]
        //[ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var stock = await _context.Stocks.FindAsync(id);
            _context.Stocks.Remove(stock);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool StockExists(int id)
        {
            return _context.Stocks.Any(e => e.Id == id);
        }
    }
}
