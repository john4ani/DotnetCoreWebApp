
using System.Collections.Generic;

namespace DotnetCoreWebApp.Models
{
    public interface ICategoryRepository
    {
        IEnumerable<Category> AllCategories { get; }
    }
}
