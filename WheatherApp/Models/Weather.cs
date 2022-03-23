using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WheatherApp.Models
{
    public class FileModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Path { get; set; }
    }

    public class Year
    {
        public int YearId { get; set; }
        public string StrYear { get; set; }
        public List<Date> Dates { get; set; }
        public Year()
        {
            Dates = new List<Date>();
        }
    }

    public class Month
    {
        public int MonthId { get; set; }
        public string StrMonth { get; set; }
        public string NameMonth { get; set; }
        public List<Date> Dates { get; set; }
        public Month()
        {
            Dates = new List<Date>();
        }
    }

    public class Date
    {
        public int DateId { get; set; }
        public string Day { get; set; }
        public Month Month { get; set; }
        public Year Year { get; set; }

        public List<Weather> Weathers { get; set; }

        public Date()
        {
            Weathers = new List<Weather>();
        }
    }

    public class Weather
    {
        // Первичный ключ
        public int Id { get; set; }
        // Дата
        //public string Date { get; set; }
        public Date Date { get; set; }
        // Время
        public string Time { get; set; }
        // Темепература воздуха
        public string Temperature { get; set; }
        // Относительная влажность воздуха
        public string RelativeHumidity { get; set; }
        // Точка росы
        public string DewPoint { get; set; }
        // атмосферное давление
        public string AtmospherPressure { get; set; }
        // Направление ветра
        public string WindDirection { get; set; }
        // Скорость ветра
        public string WindSpeed { get; set; }
        // Облачность
        public string Cloudiness { get; set; }
        // Нижняя граница облачности
        public string CloudBase { get; set; }
        // Горизонтальная видимость
        public string HorizontalVisibility { get; set; }
        // Погодные явления
        public string WeatherConditions { get; set; }
    }
}
