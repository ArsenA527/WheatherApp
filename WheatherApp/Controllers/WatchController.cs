using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WheatherApp.Models;
using System.Threading.Tasks;
using System.Linq;
using NPOI.HSSF.UserModel;
using System.IO;
using NPOI.SS.UserModel;
using NPOI.XSSF.UserModel;

namespace WheatherApp.Controllers
{
    public class WatchController : Controller
    {

        WeatherContext db;
        IWebHostEnvironment _appEnvironment;
        public WatchController(WeatherContext context, IWebHostEnvironment appEnvironment)
        {
            db = context;
            _appEnvironment = appEnvironment;
        }

        public async Task<IActionResult> Index(string? year, string? month, int page = 1)
        {
            int pageSize = 5;   // количество элементов на странице


            // Фильтрация
            IQueryable<Weather> weathers = db.Weathers.Include(x => x.Date);


            if (!String.IsNullOrEmpty(year))
            {
                weathers = weathers.Where(p => p.Date.Year.StrYear == year);
            }

            if (!String.IsNullOrEmpty(month))
            {
                weathers = weathers.Where(p => p.Date.Month.StrMonth == month);
            }

            // Пагинация

            var count = await weathers.CountAsync();
            var items = await weathers.Skip((page - 1) * pageSize).Take(pageSize).ToListAsync();

            
            IndexViewModel viewModel = new IndexViewModel
            {
                PageViewModel = new PageViewModel(count, page, pageSize),
                FilterMonthViewModel = new FilterMonthViewModel(db.Months.ToList(), month),
                FilterYearViewModel = new FilterYearViewModel(db.Years.ToList(), year),
                Weathers = items
            };

            return View(viewModel);
        }

        [HttpPost]
        public async Task<IActionResult> AddFile(IFormFile fileExcel)
        {

            if (fileExcel != null)
            {

                string path = "/Files/" + fileExcel;

                using (var fileStream = new FileStream(_appEnvironment.WebRootPath + path, FileMode.Create))
                {
                    await fileExcel.CopyToAsync(fileStream);
                    XSSFWorkbook excel = new XSSFWorkbook(fileStream);

                    ISheet ws = excel.GetSheetAt(0);
                    List<Weather> newWeathers = new List<Weather>();

                    int startRow = 5;
                    for (int i = startRow; i <= ws.LastRowNum; i++)
                      {

                        string[] strDate = ws.GetRow(i).GetCell(0).StringCellValue.Split('.');

                        var res = db.Years.Where(e => e.StrYear == strDate[2]);
                        Year newYear;
                        if (res == null)
                        {
                            newYear = new Year { StrYear = strDate[2] };
                        }

                        db.Weathers.AddRange(new Weather
                          {

                              Date = new Date { 
                                  Day = strDate[0], 
                                  Month = new Month { StrMonth = strDate[1] }, 
                                  Year = new Year { StrYear = strDate[2] },
                              },
                              Time = ws.GetRow(i).GetCell(1).StringCellValue,
                              Temperature = ws.GetRow(i).GetCell(2).StringCellValue,
                              RelativeHumidity = ws.GetRow(i).GetCell(3).StringCellValue,
                              DewPoint = ws.GetRow(i).GetCell(4).StringCellValue,
                              AtmospherPressure = ws.GetRow(i).GetCell(5).StringCellValue,
                              WindDirection = ws.GetRow(i).GetCell(6).StringCellValue,
                              WindSpeed = ws.GetRow(i).GetCell(7).StringCellValue,
                              Cloudiness = ws.GetRow(i).GetCell(8).StringCellValue,
                              CloudBase = ws.GetRow(i).GetCell(9).StringCellValue,
                              HorizontalVisibility = ws.GetRow(i).GetCell(10).StringCellValue,
                              WeatherConditions = ws.GetRow(i).GetCell(11).StringCellValue
                          });
                        startRow++;
                      }
                    

                    FileModel file = new FileModel { Name = fileExcel.FileName, Path = path };
                    db.Files.Add(file);
                    db.SaveChanges();
                }
            }      
            return RedirectToAction("Index");
        }
    }
}
