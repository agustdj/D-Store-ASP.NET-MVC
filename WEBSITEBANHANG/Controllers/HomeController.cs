using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WEBSITEBANHANG.Models;
using WEBSITEBANHANG.Repositories;

namespace WEBSITEBANHANG.Controllers
{
    public class HomeController : Controller
    {
        private readonly IProductRepository _productRepository;

        public HomeController(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public async Task<IActionResult> Index()
        {
           var products = await _productRepository.GetAllAsync();
            return View(products);
            }
        }
}
