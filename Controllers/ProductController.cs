﻿using Microsoft.AspNetCore.Mvc;
using AmazonToo.Models;
using System.Linq;
using AmazonToo.Models.ViewModels;
using System;

namespace AmazonToo.Controllers {

    public class ProductController : Controller {
        private IProductRepository repository;
        public int PageSize = 10;

        public ProductController(IProductRepository repo) {
            repository = repo;
        }

        // Individual Product Detail by Id
        [Route("/Product/Details/{productId:int}")]
        public ViewResult Details([FromRoute] int productId)
        {
            Product product = null;

            try
            {
                product = repository.Products.Where(p => p.ProductID == productId).First();
                return View(product);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: No Product found for id. {ex}");
            }

            return View("ProductNotFound");

        }

        public ViewResult List(string category, int productPage = 1)
            => View(new ProductsListViewModel {
                Products = repository.Products
                    .Where(p => category == null || p.Category == category)
                    .OrderBy(p => p.ProductID)
                    .Skip((productPage - 1) * PageSize)
                    .Take(PageSize),
                PagingInfo = new PagingInfo {
                    CurrentPage = productPage,
                    ItemsPerPage = PageSize,
                    TotalItems = category == null ?
                        repository.Products.Count() :
                        repository.Products.Where(e =>
                            e.Category == category).Count()
                },
                CurrentCategory = category
            });
    }
}
