using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AlcogolDomain;
using Alcogol;
using WebUI.BLL.Services;

//using AutoMapper;
///using WebUI.BLL.DTO;
//using WebUI.BLL.Interface;
//using WebUI.BLL.Services;
//using WebUI.DAL.Entities;
//using WebUI.WEB.Models;

namespace WebUI.WEB.Controllers
{
    public class CartController : Controller
    {
        // GET: Cart

        public ActionResult Index()
        {
            //var Cart = GetCart();
            // ViewBag.Cart = Cart;
            return View((IList<ProductsEntity>)GetCart());
        }
        public ActionResult AddToCart(int id, int amount, int man,string name, int price,int excerpt )
        {
            var cart = (List<ProductsEntity>)Session["Cart"];
            if (cart != null)
            {
                cart.Add(new ProductsEntity { Id = id, Amount = amount, ManufacturerEntityId = man,Name = name,Price = price,Excerpt = excerpt });
            }
            else
            {
                cart = new List<ProductsEntity>();
                cart.Add(new ProductsEntity { Id = id, Amount = amount, ManufacturerEntityId = man }); 
            }
            Session["Cart"] = cart;
            return RedirectToAction("Index", "Cart");
        }

        public RedirectToRouteResult RemoveFromCart(int Id)
        {
           
            return RedirectToAction("Index");
        }

        public List<ProductsEntity> GetCart()
        {
            List<ProductsEntity> cart = (List<ProductsEntity>)Session["Cart"];
            if (cart == null)
            {
                cart = new List<ProductsEntity>();
                Session["Cart"] = cart;
            }
            return cart;
        }
    }
}