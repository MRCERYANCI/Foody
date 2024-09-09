using AutoMapper;
using FluentValidation.Results;
using Foody.BusinessLayer.Abstract;
using Foody.BusinessLayer.ValidationRules.CategoryRules;
using Foody.DtoLayer.Dtos.CategoryDtos;
using Foody.EntityLayer.Concrete;
using Foody.PresentationLayer.Models;
using Microsoft.AspNetCore.Mvc;

namespace Foody.PresentationLayer.Controllers
{
    public class CategoriesController : Controller
    {
        private readonly ICategoryService _categoryService;
        private readonly IMapper _mapper;
        private string[] _getControllerAndTitleName;

        public CategoriesController(ICategoryService categoryService, IMapper mapper)
        {
            _categoryService = categoryService;
            _mapper = mapper;
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

        [HttpGet]
        public IActionResult CreateCategory()
        {
            _getControllerAndTitleName = Materials.GetTitle("Categories", "Create Category");
            TempData["Controller"] = _getControllerAndTitleName[0];
            TempData["Action"] = _getControllerAndTitleName[1];

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateCategory(CreateCategoryDto createCategoryDto)
        {
            try
            {
                CategoryValidator validationRules = new CategoryValidator();
                ValidationResult validationResult = validationRules.Validate(_mapper.Map<Category>(createCategoryDto));
                if(validationResult.IsValid)
                {
                    createCategoryDto.CategoryStatus = true;
                    createCategoryDto.CreateCategory = DateTime.Now;
                    await _categoryService.TInsertAsync(_mapper.Map<Category>(createCategoryDto));
                    return RedirectToAction("Index");
                }
            }
            catch (Exception errorMessage)
            {
                return RedirectToAction("Index", "Test", new { message = errorMessage.Message });
            }

            return View();
        }

        public async Task<IActionResult> DeleteCategory(int id)
        {
            if(id == 0 || id == null)
            {
                return RedirectToAction("Index", "Test", new { message = "You have sent an invalid or empty request." });
            }
            else
            {
                await _categoryService.TDeleteAsync(id);
                return RedirectToAction("Index");
            }
        }
    }
}
