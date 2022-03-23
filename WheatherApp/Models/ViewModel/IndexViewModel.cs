using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WheatherApp.Models
{
    public class IndexViewModel
    {
        public IEnumerable<Weather> Weathers { get; set; }
        public PageViewModel PageViewModel { get; set; }
        public FilterMonthViewModel FilterMonthViewModel { get; set; }
        public FilterYearViewModel FilterYearViewModel { get; set; }
    }
}
