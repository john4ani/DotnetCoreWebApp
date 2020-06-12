using System.Collections.Generic;
using DotnetCoreWebApp.Models;

namespace DotnetCoreWebApp.ViewModels
{
    public class HomeViewModel
    {
        public IEnumerable<Pie> PiesOfTheWeek { get; set; }
    }
}