using DotnetCoreWebApp.Models;
using System.Collections.Generic;

namespace DotnetCoreWebApp.ViewModels
{
    public class PiesListViewModel
    {
        public IEnumerable<Pie> Pies { get; set; }
        public string CurrentCategory { get; set; }
    }
}
