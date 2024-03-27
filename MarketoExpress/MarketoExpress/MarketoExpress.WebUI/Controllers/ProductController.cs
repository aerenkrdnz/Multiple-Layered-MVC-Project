using MarketoExpress.Business.Services;
using MarketoExpress.WebUI.Areas.Admin.Models;
using MarketoExpress.WebUI.Models;
using Microsoft.AspNetCore.Mvc;

namespace MarketoExpress.WebUI.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductService _productService;
        private readonly ICategoryService _categoryService;
        private readonly IWebHostEnvironment _environment;
        public ProductController(IProductService productService, ICategoryService categoryService, IWebHostEnvironment environment)
        {
            _productService = productService;
            _categoryService = categoryService;
            _environment = environment;
        }
        public IActionResult Detail(int id)
        {
            var productDtoList = _productService.GetProducts();
            var viewModel = productDtoList.Select(x => new ProductViewModel()
            {
                Id = x.Id,
                Name = x.Name,
                CategoryId = x.CategoryId,
                CategoryName = x.CategoryName,
                UnitPrice = x.UnitPrice,
                UnitsInStock = x.UnitsInStock,
                ImagePath = x.ImagePath
            }).ToList();

            return View(viewModel);
        }
    }
}
