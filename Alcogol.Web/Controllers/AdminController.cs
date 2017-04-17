using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AlcogolDomain;
using AlcogolRepository;

namespace Alcogol.Web.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        private IProductRepository _repository;
        private IManufacturerRepository _manufacturerRepository;

        public AdminController(IProductRepository repository, IManufacturerRepository manufacturerRepository)
        {
            _repository = repository;
            _manufacturerRepository = manufacturerRepository;
        }
        public ViewResult Index()
        {
            return View(_repository.GetAll().ToArray());
        }

        public ViewResult Edit(int Id)
        {
            ProductsEntity product = _repository.GetAll().ToArray()
                .FirstOrDefault(g => g.Id == Id);

            ViewBag.Manufacturers = _manufacturerRepository.GetAll().ToArray();

            return View(product);
        }

        [HttpPost]
        public ActionResult Edit(ProductsEntity product)
        {
            if (ModelState.IsValid)
            {
                _repository.SaveProduct(product);
                TempData["message"] = string.Format("Изменения в товаре \"{0}\" были сохранены", product.Name);
                return RedirectToAction("Index");
            }
            else
            {
                ViewBag.Manufacturers = _manufacturerRepository.GetAll().ToArray();
                return View(product);
            }
        }
        public ViewResult Create()
        {
            ViewBag.Manufacturers = _manufacturerRepository.GetAll().ToArray();
            return View("Edit", new ProductsEntity());
        }
        [HttpPost]
        public ActionResult Delete(int Id)
        {
            ProductsEntity deletedProduct = _repository.DeleteProduct(Id);
            if (deletedProduct != null)
            {
                TempData["message"] = string.Format("Товар \"{0}\" была удален",
                    deletedProduct.Name);
            }
            return RedirectToAction("Index");
        }
    }
}