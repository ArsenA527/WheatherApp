using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WheatherApp.Models
{
    public class FilterYearViewModel
    {
        public FilterYearViewModel(List<Year> years, string? year)
        {
            // устанавливаем начальный элемент, который позволит выбрать всех
            years.Insert(0, new Year { StrYear = "", YearId = 0 });
            Years = new SelectList(years, "StrYear", "StrYear", year);
            SelectedYear = year;
        }
        public SelectList Years { get; private set; }
        public string? SelectedYear { get; private set; }
    }
}
