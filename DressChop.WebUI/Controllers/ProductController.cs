using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DressChop.Domain.Entities;
using DressChop.Domain.Abstract;


namespace DressChop.WebUI.Controllers
{
    public class ProductController : Controller
    {
        private IProductsRepository repository;
        public int pageSize = 4;

        public ProductController(IProductsRepository repo)
        {
            repository = repo;
        }
        public ViewResult List(int page = 1)
        {
            return View(repository.Products
               .OrderBy(product => product.ProductID)
               .Skip((page - 1) * pageSize)
               .Take(pageSize));
        }
    }
}