using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SalesWebMvc1.Models;
using SalesWebMvc1.Models.ViewModels;
using SalesWebMvc1.Services;

namespace SalesWebMvc1.Controllers
{
    public class SellersController : Controller
    {
        private readonly SellerService _sellerService;//injeçao de dependência 
        private readonly DepartmentService _departmentService;//injeçao de dependência 

        public SellersController(SellerService sellerService, DepartmentService departmentService)
        {
            _sellerService = sellerService;
            _departmentService = departmentService;
        }

        public IActionResult Index()
        {
            var list = _sellerService.FindAll();

            return View(list);
        }
        public IActionResult Create()
        {
            var departments = _departmentService.FindAll();
            var viewModel = new SellerFormViewModel { Departments = departments };
            return View(viewModel);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]//impede que etrem na mesma sessão e envie dados maliciosos
        public IActionResult Create(Seller seller)
        {
            _sellerService.Insert(seller);
            return RedirectToAction(nameof(Index));//após gravar os dados envia para a página selecionada
        }
        public IActionResult Delete(int ? id)
        {
            if( id == null)
            {
                return NotFound();

            }
            var obj = _sellerService.FindById(id.Value);
            if(obj == null)
            {
                return NotFound();
            }
            return View(obj);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Delete(int id)
        {
            _sellerService.Remove(id);
            return RedirectToAction("Index");
        }

        public IActionResult Details(int ? id)
        {
            if(id == null)
            {
                return NotFound();

            }
            var obj = _sellerService.FindById(id.Value);
            if (obj == null)
            {
                return NotFound();
            }
            return View(obj);
        }
    }
}
