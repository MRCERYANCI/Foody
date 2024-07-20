using Foody.BusinessLayer.Abstract;
using Foody.PresentationLayer.Models;
using Microsoft.AspNetCore.Mvc;

namespace Foody.PresentationLayer.Controllers
{
    public class CategoriesController : Controller
    {
        private readonly ICategoryService _categoryService;
        private string[] _getControllerAndTitleName;

        public CategoriesController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        public async Task<IActionResult> Index()
        {
            try
            {
                _getControllerAndTitleName = Materials.GetTitle("Categories", "Category List");
                TempData["Controller"] = _getControllerAndTitleName[0]; 
                TempData["Action"] = _getControllerAndTitleName[1]; 

                var categoryList = await _categoryService.TGetAllAsync();
                if(categoryList is not null)
                {
                    return View(categoryList);
                }
            }
            catch (Exception errorMessage)
            {
                return RedirectToAction("Index", "Test", new { message = errorMessage.Message });
            }

            return View();
        }
    }
}
