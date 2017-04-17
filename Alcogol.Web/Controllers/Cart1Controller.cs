using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AutoMapper;
using WebUI.BLL.DTO;
using WebUI.BLL.Interface;
using WebUI.BLL.Services;
using WebUI.DAL.Entities;
using WebUI.WEB.Models;

namespace WebUI.WEB.Controllers
{
    public class CartController : Controller
    {
        // GET: Cart
        private IOrderService repository;
        public CartController(IOrderService repo)
        {
            repository = repo;
        }

        public ActionResult Index()
        {
           //var Cart = GetCart();
           // ViewBag.Cart = Cart;
            return View(GetCart());
        }
        public ActionResult AddToCart(int Id)
        {
            var product = repository.GetPhone(Id);

            if (product != null)
            {
                Mapper.Initialize(cfg => cfg.CreateMap<ProductDTO, Product>());
                var Product = Mapper.Map<ProductDTO,Product>(product);
                GetCart().AddItem(Product, 1);
            }
            return RedirectToAction("Index","Home");
        }

        public RedirectToRouteResult RemoveFromCart(int Id)
        {
            var product = repository.GetPhone(Id);

            if (product != null)
            {
                Mapper.Initialize(cfg => cfg.CreateMap<ProductDTO, Product>());
                var Product = Mapper.Map<ProductDTO, Product>(product);
                GetCart().RemoveLine(Product);
            }
            return RedirectToAction("Index");
        }

        public Cart GetCart()
        {
            Cart cart = (Cart)Session["Cart"];
            if (cart == null)
            {
                cart = new Cart();
                Session["Cart"] = cart;
            }
            return cart;
        }
    }
}