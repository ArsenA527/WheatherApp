using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WheatherApp.Models
{
    public class PageViewModel
    {
        //номер текущей страницы
        public int PageNumber { get; private set; }
        // общее количество страниц
        public int TotalPages { get; private set; }

        public PageViewModel(int count, int pageNumber, int pageSize)
        {
            PageNumber = pageNumber;
            TotalPages = (int)Math.Ceiling(count / (double)pageSize);
        }

        // Есть ли до текущей страницы еще какие-нибудь страницы
        public bool HasPreviousPage
        {
            get
            {
                return (PageNumber > 1);
            }
        }
        // Есть ли после текущей страницы еще какие-нибудь страницы
        public bool HasNextPage
        {
            get
            {
                return (PageNumber < TotalPages);
            }
        }
    }
}
