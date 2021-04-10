using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SnurrtumlareWebSite.Data;
using SnurrtumlareWebSite.Models;
using SnurrtumlareWebSite.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using X.PagedList;


namespace SnurrtumlareWebSite.Controllers
{
    [Authorize(Roles = "Admin")]
    public class ProductsController : Controller
    {
        private readonly ProductsService _productsService;

        public ProductsController(ProductsService productsService)
        {
            _productsService = productsService;
        }

        // GET: Products
        public async Task<IActionResult> Index(string sortOrder, string searchString, string currentFilter, int? page)
        {
            ViewBag.CurrentSort = sortOrder;
            ViewBag.ProductIdSortParm = String.IsNullOrEmpty(sortOrder) ? "productId_desc" : "";
            ViewBag.ProductNameSortParm = String.IsNullOrEmpty(sortOrder) ? "productName_desc" : "";
            ViewBag.ProductDescriptionSortParm = String.IsNullOrEmpty(sortOrder) ? "productDescription_desc" : "";
            ViewBag.AmountInStockSortParm = String.IsNullOrEmpty(sortOrder) ? "amountInStock_desc" : "";
            ViewBag.ProductPriceSortParm = String.IsNullOrEmpty(sortOrder) ? "productPrice_desc" : "";

            if (searchString != null)
            {
                page = 1;
            }
            else
            {
                searchString = currentFilter;
            }

            ViewBag.CurrentFilter = searchString;

            var products = await _productsService.GetAllProducts();

            if (!String.IsNullOrEmpty(searchString))
            {
                products = products.Where(s => s.ProductName.ToLower().Contains(searchString.ToLower())
                                       || s.ProductDescription.ToLower().Contains(searchString.ToLower())).ToList();
            }


            switch (sortOrder)
            {
                case "productId_desc":
                    products = products.OrderByDescending(s => s.ProductId).ToList();
                    break;

                case "productName_desc":
                    products = products.OrderByDescending(s => s.ProductName).ToList();
                    break;

                case "productDescription_desc":
                    products = products.OrderByDescending(s => s.ProductDescription).ToList();
                    break;

                case "productPrice_desc":
                    products = products.OrderByDescending(s => s.ProductPrice).ToList();
                    break;

                case "amountInStock_desc":
                    products = products.OrderByDescending(s => s.Quantity).ToList();
                    break;

                default:  // Name ascending 
                    products = products.OrderBy(s => s.ProductId).ToList();
                    break;
            }


            int pageSize = 5;
            int pageNumber = (page ?? 1);

            ViewBag.OnePageOfProducts = products.ToPagedList(pageNumber, pageSize);


            return View();


            //List<Product> result = await _productsService.GetAllProducts();

            //return View(result);
        }



        // GET: Products/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Product product = await _productsService.GetProductById(id);

            if (product == null)
            {
                return NotFound();
            }

            return View(product);
        }



        // GET: Products/Create
        public IActionResult Create()
        {
            return View();
        }


        // POST: Products/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ProductId,ImageLink,ProductName,Category,ProductDescription,AmountInStock,ProductPrice")] Product product)
        {
            if (ModelState.IsValid)
            {
                await _productsService.AddNewProduct(product);

                return RedirectToAction(nameof(Index));
            }
            return View(product);
        }



        // GET: Products/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Product product = await _productsService.FindProductById(id);

            if (product == null)
            {
                return NotFound();
            }
            return View(product);
        }



        // POST: Products/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ProductId,ImageLink,ProductName,Category,ProductDescription,AmountInStock,ProductPrice")] Product product)
        {
            if (id != product.ProductId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    await _productsService.UpdateProduct(product);
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!_productsService.ProductExists(product.ProductId))
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
            return View(product);
        }

        // GET: Products/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Product product = await _productsService.GetProductById(id);

            if (product == null)
            {
                return NotFound();
            }

            return View(product);
        }


        // POST: Products/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            await _productsService.DeleteProductById(id);

            return RedirectToAction(nameof(Index));
        }

    }
}
