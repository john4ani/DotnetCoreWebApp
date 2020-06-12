using DotnetCoreWebApp.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace DotnetCoreWebApp.Components
{
    public class CategoryMenu : ViewComponent
    {
        private readonly ICategoryRepository _categoryRepository;

        public CategoryMenu(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }

        public IViewComponentResult Invoke()
        {
            var categoies = _categoryRepository.AllCategories.OrderBy(c => c.CategoryName);
            return View(categoies);
        }
    }
}
