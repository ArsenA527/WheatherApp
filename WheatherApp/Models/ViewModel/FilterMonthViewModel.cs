using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WheatherApp.Models
{
    public class FilterMonthViewModel
    {
        public FilterMonthViewModel(List<Month> months, string? month)
        {
            // устанавливаем начальный элемент, который позволит выбрать всех
            months.Insert(0, new Month { StrMonth = "", NameMonth = "Все" });
            Months = new SelectList(months, "StrMonth", "NameMonth", month);
            SelectedMonth = month;
        }
        public SelectList Months { get; private set; }
        public string? SelectedMonth { get; private set; }
    }
}
