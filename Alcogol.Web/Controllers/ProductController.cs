using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AlcogolDomain;
using AlcogolRepository;

namespace Alcogol.Web.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        private IProductRepository _repository;

        public ProductController(IProductRepository repository)
        {
            _repository = repository;
        }
        public ViewResult List()
        {
            return View(_repository.GetAll()?.ToArray());
        }
    }
}