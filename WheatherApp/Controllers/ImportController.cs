using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Logging;
using System.Text;
using NPOI.SS.UserModel;
using NPOI.HSSF.UserModel;
using NPOI.XSSF.UserModel;
using IHostingEnvironment = Microsoft.AspNetCore.Hosting.IHostingEnvironment;
using WheatherApp.Models;

namespace WheatherApp.Controllers
{
    public class ImportController : Controller
    {
        private IHostingEnvironment _hostingEnvironment;
        public IActionResult Index()
        {
            /*IFormFile file = Request.Form.Files[0];
            string folderName = "UploadExcel";
            string webRootPath = _hostingEnvironment.WebRootPath;
            string newPath = Path.Combine(webRootPath, folderName);
            StringBuilder sb = new StringBuilder();
            if (file.Length > 0)
            {
                string sFileExtension = Path.GetExtension(file.FileName).ToLower();
                ISheet sheet;
                string fullPath = Path.Combine(newPath, file.FileName);
                using (var stream = new FileStream(fullPath, FileMode.Create))
                {
                    file.CopyTo(stream);
                    stream.Position = 0;
                    if (sFileExtension == ".xls")
                    {
                        HSSFWorkbook hssfwb = new HSSFWorkbook(stream); // форматы Excel 97-2000  
                        sheet = hssfwb.GetSheetAt(0); // получаем первый лист из книги 
                    }
                    else
                    {
                        XSSFWorkbook hssfwb = new XSSFWorkbook(stream); // формат Excel 2007 года  
                        sheet = hssfwb.GetSheetAt(0); // получаем первый лист из книги    
                    }
                }
            }*/

            return View();
        }
    }
}
