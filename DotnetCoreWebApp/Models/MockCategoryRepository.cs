

using System.Collections.Generic;

namespace DotnetCoreWebApp.Models
{
    public class MockCategoryRepository : ICategoryRepository
    {
        public IEnumerable<Category> AllCategories =>
        
            new List<Category>
            {
                new Category{CategoryId=1, CategoryName="Fruit pies", Description="All fruit pies"},
                new Category{CategoryId=2, CategoryName="Cheese pies", Description="Cheesy pies"},
                new Category{CategoryId=3, CategoryName="Seasonal pies", Description="La la la"},
            };
        
    }
}
