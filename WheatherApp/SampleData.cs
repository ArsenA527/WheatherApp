using System.Linq;
using WheatherApp.Models;

namespace WheatherApp
{
    public static class SampleData
    {
        public static void Initialize(WeatherContext context)
        {
            if (context.Dates.Count() == 0)
            {
                Year year2010 = new Year{ StrYear = "2010" };
                Year year2011 = new Year{ StrYear = "2011" };
                Year year2012 = new Year{ StrYear = "2012" };
                Year year2013 = new Year{ StrYear = "2013" };

                Month January = new Month { StrMonth = "01", NameMonth = "Январь" };
                Month February = new Month { StrMonth = "02", NameMonth = "Февраль" };
                Month March = new Month { StrMonth = "03", NameMonth = "Март" };
                Month April = new Month { StrMonth = "04", NameMonth = "Апрель" };
                Month May = new Month { StrMonth = "05", NameMonth = "Май" };
                Month June = new Month { StrMonth = "06", NameMonth = "Июнь" };
                Month July = new Month { StrMonth = "07", NameMonth = "Июль" };
                Month August = new Month { StrMonth = "08", NameMonth = "Август" };
                Month September = new Month { StrMonth = "09", NameMonth = "Сентябрь" };
                Month October = new Month { StrMonth = "10", NameMonth = "Октябрь" };
                Month November = new Month { StrMonth = "11", NameMonth = "Ноябрь" };
                Month December = new Month { StrMonth = "12", NameMonth = "Декабрь" };


                context.Weathers.AddRange(
                    new Weather
                    {
                        Date = new Date { Day = "01", Month = January, Year = year2010 },
                        Time = "00:00",
                        Temperature = "-7,3",
                        RelativeHumidity = "93,25",
                        DewPoint = "-8,2",
                        AtmospherPressure = "743",
                        WindDirection = "",
                        WindSpeed = "",
                        Cloudiness = "70",
                        CloudBase = "300",   
                        HorizontalVisibility = "",
                        WeatherConditions = "Непрерывный слабый снег"
                    },
                    new Weather
                    {
                        Date = new Date { Day = "01", Month = February, Year = year2010 },
                        Time = "00:00",
                        Temperature = "-9,9",
                        RelativeHumidity = "90,9",
                        DewPoint = "-11,1",
                        AtmospherPressure = "748",
                        WindDirection = "ЮЗ",
                        WindSpeed = "1",
                        Cloudiness = "",
                        CloudBase = "2500",
                        HorizontalVisibility = "",
                        WeatherConditions = "Дымка"
                    },
                    new Weather
                    {
                        Date = new Date { Day = "01", Month = March, Year = year2010 },
                        Time = "00:00",
                        Temperature = "-12,1",
                        RelativeHumidity = "69,63",
                        DewPoint = "-16,5",
                        AtmospherPressure = "768",
                        WindDirection = "Ю",
                        WindSpeed = "1",
                        Cloudiness = "10",
                        CloudBase = "600",
                        HorizontalVisibility = "",
                        WeatherConditions = ""
                    },
                    new Weather
                    {
                        Date = new Date { Day = "01", Month = April, Year = year2010 },
                        Time = "00:00",
                        Temperature = "-4,4",
                        RelativeHumidity = "67,49",
                        DewPoint = "-9,5",
                        AtmospherPressure = "757",
                        WindDirection = "",
                        WindSpeed = "",
                        Cloudiness = "",
                        CloudBase = "2500",
                        HorizontalVisibility = "",
                        WeatherConditions = ""
                    },
                    new Weather
                    {
                        Date = new Date { Day = "01", Month = May, Year = year2010 },
                        Time = "00:00",
                        Temperature = "11,5",
                        RelativeHumidity = "88,71",
                        DewPoint = "9,7",
                        AtmospherPressure = "742",
                        WindDirection = "ЮВ",
                        WindSpeed = "2",
                        Cloudiness = "90",
                        CloudBase = "600",
                        HorizontalVisibility = "",
                        WeatherConditions = "Ливневый дождь"
                    },
                    new Weather
                    {
                        Date = new Date { Day = "01", Month = June, Year = year2010 },
                        Time = "00:00",
                        Temperature = "14,9",
                        RelativeHumidity = "77,5",
                        DewPoint = "11",
                        AtmospherPressure = "756",
                        WindDirection = "",
                        WindSpeed = "",
                        Cloudiness = "",
                        CloudBase = "2500",
                        HorizontalVisibility = "",
                        WeatherConditions = ""
                    },
                    new Weather
                    {
                        Date = new Date { Day = "01", Month = July, Year = year2010 },
                        Time = "00:00",
                        Temperature = "22,9",
                        RelativeHumidity = "66,33",
                        DewPoint = "14,8",
                        AtmospherPressure = "749",
                        WindDirection = "ЮВ",
                        WindSpeed = "1",
                        Cloudiness = "",
                        CloudBase = "2500",
                        HorizontalVisibility = "",
                        WeatherConditions = ""
                    },
                    new Weather
                    {
                        Date = new Date { Day = "01", Month = August, Year = year2010 },
 
                        Time = "00:00",
                        Temperature = "18,5",
                        RelativeHumidity = "95,11",
                        DewPoint = "17,7",
                        AtmospherPressure = "738",
                        WindDirection = "",
                        WindSpeed = "",
                        Cloudiness = "",
                        CloudBase = "2500",
                        HorizontalVisibility = "",
                        WeatherConditions = "Дымка"
                    },
                    new Weather
                    {
                        Date = new Date { Day = "01", Month = September, Year = year2010 },
                        Time = "00:00",
                        Temperature = "14,1",
                        RelativeHumidity = "90,1",
                        DewPoint = "12,5",
                        AtmospherPressure = "745",
                        WindDirection = "",
                        WindSpeed = "",
                        Cloudiness = "100",
                        CloudBase = "1000",
                        HorizontalVisibility = "",
                        WeatherConditions = "Дымка"
                    },
                    new Weather
                    {
                        Date = new Date { Day = "01", Month = October, Year = year2010 },
                        Time = "00:00",
                        Temperature = "11,1",
                        RelativeHumidity = "93,56",
                        DewPoint = "10,1",
                        AtmospherPressure = "741",
                        WindDirection = "З",
                        WindSpeed = "1",
                        Cloudiness = "100",
                        CloudBase = "300",
                        HorizontalVisibility = "",
                        WeatherConditions = "Непрерывный слабый дождь"
                    },
                    new Weather
                    {
                        Date = new Date { Day = "01", Month = November, Year = year2010 },
                        Time = "00:00",
                        Temperature = "7,7",
                        RelativeHumidity = "94,03",
                        DewPoint = "6,8",
                        AtmospherPressure = "742",
                        WindDirection = "З",
                        WindSpeed = "1",
                        Cloudiness = "100",
                        CloudBase = "300",
                        HorizontalVisibility = "",
                        WeatherConditions = "Дымка"
                    },
                    new Weather
                    {
                        Date = new Date { Day = "01", Month = December, Year = year2010 },
                        Time = "00:00",
                        Temperature = "-2,2",
                        RelativeHumidity = "76,29",
                        DewPoint = "-5,8",
                        AtmospherPressure = "749",
                        WindDirection = "Ю",
                        WindSpeed = "1",
                        Cloudiness = "100",
                        CloudBase = "600",
                        HorizontalVisibility = "",
                        WeatherConditions = ""
                    },

                    new Weather
                    {
                        Date = new Date { Day = "01", Month = January, Year = year2011 },
                        Time = "00:00",
                        Temperature = "-7,3",
                        RelativeHumidity = "93,25",
                        DewPoint = "-8,2",
                        AtmospherPressure = "743",
                        WindDirection = "",
                        WindSpeed = "",
                        Cloudiness = "70",
                        CloudBase = "300",
                        HorizontalVisibility = "",
                        WeatherConditions = "Непрерывный слабый снег"
                    },
                    new Weather
                    {
                        Date = new Date { Day = "01", Month = February, Year = year2011 },
                        Time = "00:00",
                        Temperature = "-9,9",
                        RelativeHumidity = "90,9",
                        DewPoint = "-11,1",
                        AtmospherPressure = "748",
                        WindDirection = "ЮЗ",
                        WindSpeed = "1",
                        Cloudiness = "",
                        CloudBase = "2500",
                        HorizontalVisibility = "",
                        WeatherConditions = "Дымка"
                    },
                    new Weather
                    {
                        Date = new Date { Day = "01", Month = March, Year = year2011 },
                        Time = "00:00",
                        Temperature = "-12,1",
                        RelativeHumidity = "69,63",
                        DewPoint = "-16,5",
                        AtmospherPressure = "768",
                        WindDirection = "Ю",
                        WindSpeed = "1",
                        Cloudiness = "10",
                        CloudBase = "600",
                        HorizontalVisibility = "",
                        WeatherConditions = ""
                    },
                    new Weather
                    {
                        Date = new Date { Day = "01", Month = April, Year = year2011 },
                        Time = "00:00",
                        Temperature = "-4,4",
                        RelativeHumidity = "67,49",
                        DewPoint = "-9,5",
                        AtmospherPressure = "757",
                        WindDirection = "",
                        WindSpeed = "",
                        Cloudiness = "",
                        CloudBase = "2500",
                        HorizontalVisibility = "",
                        WeatherConditions = ""
                    },
                    new Weather
                    {
                        Date = new Date { Day = "01", Month = May, Year = year2011 },
                        Time = "00:00",
                        Temperature = "11,5",
                        RelativeHumidity = "88,71",
                        DewPoint = "9,7",
                        AtmospherPressure = "742",
                        WindDirection = "ЮВ",
                        WindSpeed = "2",
                        Cloudiness = "90",
                        CloudBase = "600",
                        HorizontalVisibility = "",
                        WeatherConditions = "Ливневый дождь"
                    },
                    new Weather
                    {
                        Date = new Date { Day = "01", Month = June, Year = year2011 },
                        Time = "00:00",
                        Temperature = "14,9",
                        RelativeHumidity = "77,5",
                        DewPoint = "11",
                        AtmospherPressure = "756",
                        WindDirection = "",
                        WindSpeed = "",
                        Cloudiness = "",
                        CloudBase = "2500",
                        HorizontalVisibility = "",
                        WeatherConditions = ""
                    },
                    new Weather
                    {
                        Date = new Date { Day = "01", Month = July, Year = year2011 },
                        Time = "00:00",
                        Temperature = "22,9",
                        RelativeHumidity = "66,33",
                        DewPoint = "14,8",
                        AtmospherPressure = "749",
                        WindDirection = "ЮВ",
                        WindSpeed = "1",
                        Cloudiness = "",
                        CloudBase = "2500",
                        HorizontalVisibility = "",
                        WeatherConditions = ""
                    },
                    new Weather
                    {
                        Date = new Date { Day = "01", Month = August, Year = year2011 },
                        Time = "00:00",
                        Temperature = "18,5",
                        RelativeHumidity = "95,11",
                        DewPoint = "17,7",
                        AtmospherPressure = "738",
                        WindDirection = "",
                        WindSpeed = "",
                        Cloudiness = "",
                        CloudBase = "2500",
                        HorizontalVisibility = "",
                        WeatherConditions = "Дымка"
                    },
                    new Weather
                    {
                        Date = new Date { Day = "01", Month = September, Year = year2011 },
                        Time = "00:00",
                        Temperature = "14,1",
                        RelativeHumidity = "90,1",
                        DewPoint = "12,5",
                        AtmospherPressure = "745",
                        WindDirection = "",
                        WindSpeed = "",
                        Cloudiness = "100",
                        CloudBase = "1000",
                        HorizontalVisibility = "",
                        WeatherConditions = "Дымка"
                    },
                    new Weather
                    {
                        Date = new Date { Day = "01", Month = October, Year = year2011 },
                        Time = "00:00",
                        Temperature = "11,1",
                        RelativeHumidity = "93,56",
                        DewPoint = "10,1",
                        AtmospherPressure = "741",
                        WindDirection = "З",
                        WindSpeed = "1",
                        Cloudiness = "100",
                        CloudBase = "300",
                        HorizontalVisibility = "",
                        WeatherConditions = "Непрерывный слабый дождь"
                    },
                    new Weather
                    {
                        Date = new Date { Day = "01", Month = November, Year = year2011 },
                        Time = "00:00",
                        Temperature = "7,7",
                        RelativeHumidity = "94,03",
                        DewPoint = "6,8",
                        AtmospherPressure = "742",
                        WindDirection = "З",
                        WindSpeed = "1",
                        Cloudiness = "100",
                        CloudBase = "300",
                        HorizontalVisibility = "",
                        WeatherConditions = "Дымка"
                    },
                    new Weather
                    {
                        Date = new Date { Day = "01", Month = December, Year = year2011 },
                        Time = "00:00",
                        Temperature = "-2,2",
                        RelativeHumidity = "76,29",
                        DewPoint = "-5,8",
                        AtmospherPressure = "749",
                        WindDirection = "Ю",
                        WindSpeed = "1",
                        Cloudiness = "100",
                        CloudBase = "600",
                        HorizontalVisibility = "",
                        WeatherConditions = ""
                    },

                    new Weather
                    {
                        Date = new Date { Day = "01", Month = January, Year = year2012 },
                        Time = "00:00",
                        Temperature = "-7,3",
                        RelativeHumidity = "93,25",
                        DewPoint = "-8,2",
                        AtmospherPressure = "743",
                        WindDirection = "",
                        WindSpeed = "",
                        Cloudiness = "70",
                        CloudBase = "300",
                        HorizontalVisibility = "",
                        WeatherConditions = "Непрерывный слабый снег"
                    },
                    new Weather
                    {
                        Date = new Date { Day = "01", Month = February, Year = year2012 },
                        Time = "00:00",
                        Temperature = "-9,9",
                        RelativeHumidity = "90,9",
                        DewPoint = "-11,1",
                        AtmospherPressure = "748",
                        WindDirection = "ЮЗ",
                        WindSpeed = "1",
                        Cloudiness = "",
                        CloudBase = "2500",
                        HorizontalVisibility = "",
                        WeatherConditions = "Дымка"
                    },
                    new Weather
                    {
                        Date = new Date { Day = "01", Month = March, Year = year2012 },
                        Time = "00:00",
                        Temperature = "-12,1",
                        RelativeHumidity = "69,63",
                        DewPoint = "-16,5",
                        AtmospherPressure = "768",
                        WindDirection = "Ю",
                        WindSpeed = "1",
                        Cloudiness = "10",
                        CloudBase = "600",
                        HorizontalVisibility = "",
                        WeatherConditions = ""
                    },
                    new Weather
                    {
                        Date = new Date { Day = "01", Month = April, Year = year2012 },
                        Time = "00:00",
                        Temperature = "-4,4",
                        RelativeHumidity = "67,49",
                        DewPoint = "-9,5",
                        AtmospherPressure = "757",
                        WindDirection = "",
                        WindSpeed = "",
                        Cloudiness = "",
                        CloudBase = "2500",
                        HorizontalVisibility = "",
                        WeatherConditions = ""
                    },
                    new Weather
                    {
                        Date = new Date { Day = "01", Month = May, Year = year2012 },
                        Time = "00:00",
                        Temperature = "11,5",
                        RelativeHumidity = "88,71",
                        DewPoint = "9,7",
                        AtmospherPressure = "742",
                        WindDirection = "ЮВ",
                        WindSpeed = "2",
                        Cloudiness = "90",
                        CloudBase = "600",
                        HorizontalVisibility = "",
                        WeatherConditions = "Ливневый дождь"
                    },
                    new Weather
                    {
                        Date = new Date { Day = "01", Month = June, Year = year2012 },
                        Time = "00:00",
                        Temperature = "14,9",
                        RelativeHumidity = "77,5",
                        DewPoint = "11",
                        AtmospherPressure = "756",
                        WindDirection = "",
                        WindSpeed = "",
                        Cloudiness = "",
                        CloudBase = "2500",
                        HorizontalVisibility = "",
                        WeatherConditions = ""
                    },
                    new Weather
                    {
                        Date = new Date { Day = "01", Month = July, Year = year2012 },
                        Time = "00:00",
                        Temperature = "22,9",
                        RelativeHumidity = "66,33",
                        DewPoint = "14,8",
                        AtmospherPressure = "749",
                        WindDirection = "ЮВ",
                        WindSpeed = "1",
                        Cloudiness = "",
                        CloudBase = "2500",
                        HorizontalVisibility = "",
                        WeatherConditions = ""
                    },
                    new Weather
                    {
                        Date = new Date { Day = "01", Month = August, Year = year2012 },
                        Time = "00:00",
                        Temperature = "18,5",
                        RelativeHumidity = "95,11",
                        DewPoint = "17,7",
                        AtmospherPressure = "738",
                        WindDirection = "",
                        WindSpeed = "",
                        Cloudiness = "",
                        CloudBase = "2500",
                        HorizontalVisibility = "",
                        WeatherConditions = "Дымка"
                    },
                    new Weather
                    {
                        Date = new Date { Day = "01", Month = September, Year = year2012 },
                        Time = "00:00",
                        Temperature = "14,1",
                        RelativeHumidity = "90,1",
                        DewPoint = "12,5",
                        AtmospherPressure = "745",
                        WindDirection = "",
                        WindSpeed = "",
                        Cloudiness = "100",
                        CloudBase = "1000",
                        HorizontalVisibility = "",
                        WeatherConditions = "Дымка"
                    },
                    new Weather
                    {
                        Date = new Date { Day = "01", Month = October, Year = year2012 },
                        Time = "00:00",
                        Temperature = "11,1",
                        RelativeHumidity = "93,56",
                        DewPoint = "10,1",
                        AtmospherPressure = "741",
                        WindDirection = "З",
                        WindSpeed = "1",
                        Cloudiness = "100",
                        CloudBase = "300",
                        HorizontalVisibility = "",
                        WeatherConditions = "Непрерывный слабый дождь"
                    },
                    new Weather
                    {
                        Date = new Date { Day = "01", Month = November, Year = year2012 },
                        Time = "00:00",
                        Temperature = "7,7",
                        RelativeHumidity = "94,03",
                        DewPoint = "6,8",
                        AtmospherPressure = "742",
                        WindDirection = "З",
                        WindSpeed = "1",
                        Cloudiness = "100",
                        CloudBase = "300",
                        HorizontalVisibility = "",
                        WeatherConditions = "Дымка"
                    },
                    new Weather
                    {
                        Date = new Date { Day = "01", Month = December, Year = year2012 },
                        Time = "00:00",
                        Temperature = "-2,2",
                        RelativeHumidity = "76,29",
                        DewPoint = "-5,8",
                        AtmospherPressure = "749",
                        WindDirection = "Ю",
                        WindSpeed = "1",
                        Cloudiness = "100",
                        CloudBase = "600",
                        HorizontalVisibility = "",
                        WeatherConditions = ""
                    },

                    new Weather
                    {
                        Date = new Date { Day = "01", Month = January, Year = year2013 },
                        Time = "00:00",
                        Temperature = "-7,3",
                        RelativeHumidity = "93,25",
                        DewPoint = "-8,2",
                        AtmospherPressure = "743",
                        WindDirection = "",
                        WindSpeed = "",
                        Cloudiness = "70",
                        CloudBase = "300",
                        HorizontalVisibility = "",
                        WeatherConditions = "Непрерывный слабый снег"
                    },
                    new Weather
                    {
                        Date = new Date { Day = "01", Month = February, Year = year2013 },
                        Time = "00:00",
                        Temperature = "-9,9",
                        RelativeHumidity = "90,9",
                        DewPoint = "-11,1",
                        AtmospherPressure = "748",
                        WindDirection = "ЮЗ",
                        WindSpeed = "1",
                        Cloudiness = "",
                        CloudBase = "2500",
                        HorizontalVisibility = "",
                        WeatherConditions = "Дымка"
                    },
                    new Weather
                    {
                        Date = new Date { Day = "01", Month = March, Year = year2013 },
                        Time = "00:00",
                        Temperature = "-12,1",
                        RelativeHumidity = "69,63",
                        DewPoint = "-16,5",
                        AtmospherPressure = "768",
                        WindDirection = "Ю",
                        WindSpeed = "1",
                        Cloudiness = "10",
                        CloudBase = "600",
                        HorizontalVisibility = "",
                        WeatherConditions = ""
                    },
                    new Weather
                    {
                        Date = new Date { Day = "01", Month = April, Year = year2013 },
                        Time = "00:00",
                        Temperature = "-4,4",
                        RelativeHumidity = "67,49",
                        DewPoint = "-9,5",
                        AtmospherPressure = "757",
                        WindDirection = "",
                        WindSpeed = "",
                        Cloudiness = "",
                        CloudBase = "2500",
                        HorizontalVisibility = "",
                        WeatherConditions = ""
                    },
                    new Weather
                    {
                        Date = new Date { Day = "01", Month = May, Year = year2013 },
                        Time = "00:00",
                        Temperature = "11,5",
                        RelativeHumidity = "88,71",
                        DewPoint = "9,7",
                        AtmospherPressure = "742",
                        WindDirection = "ЮВ",
                        WindSpeed = "2",
                        Cloudiness = "90",
                        CloudBase = "600",
                        HorizontalVisibility = "",
                        WeatherConditions = "Ливневый дождь"
                    },
                    new Weather
                    {
                        Date = new Date { Day = "01", Month = June, Year = year2013 },
                        Time = "00:00",
                        Temperature = "14,9",
                        RelativeHumidity = "77,5",
                        DewPoint = "11",
                        AtmospherPressure = "756",
                        WindDirection = "",
                        WindSpeed = "",
                        Cloudiness = "",
                        CloudBase = "2500",
                        HorizontalVisibility = "",
                        WeatherConditions = ""
                    },
                    new Weather
                    {
                        Date = new Date { Day = "01", Month = July, Year = year2013 },
                        Time = "00:00",
                        Temperature = "22,9",
                        RelativeHumidity = "66,33",
                        DewPoint = "14,8",
                        AtmospherPressure = "749",
                        WindDirection = "ЮВ",
                        WindSpeed = "1",
                        Cloudiness = "",
                        CloudBase = "2500",
                        HorizontalVisibility = "",
                        WeatherConditions = ""
                    },
                    new Weather
                    {
                        Date = new Date { Day = "01", Month = August, Year = year2013 },
                        Time = "00:00",
                        Temperature = "18,5",
                        RelativeHumidity = "95,11",
                        DewPoint = "17,7",
                        AtmospherPressure = "738",
                        WindDirection = "",
                        WindSpeed = "",
                        Cloudiness = "",
                        CloudBase = "2500",
                        HorizontalVisibility = "",
                        WeatherConditions = "Дымка"
                    },
                    new Weather
                    {
                        Date = new Date { Day = "01", Month = September, Year = year2013 },
                        Time = "00:00",
                        Temperature = "14,1",
                        RelativeHumidity = "90,1",
                        DewPoint = "12,5",
                        AtmospherPressure = "745",
                        WindDirection = "",
                        WindSpeed = "",
                        Cloudiness = "100",
                        CloudBase = "1000",
                        HorizontalVisibility = "",
                        WeatherConditions = "Дымка"
                    },
                    new Weather
                    {
                        Date = new Date { Day = "01", Month = October, Year = year2013 },
                        Time = "00:00",
                        Temperature = "11,1",
                        RelativeHumidity = "93,56",
                        DewPoint = "10,1",
                        AtmospherPressure = "741",
                        WindDirection = "З",
                        WindSpeed = "1",
                        Cloudiness = "100",
                        CloudBase = "300",
                        HorizontalVisibility = "",
                        WeatherConditions = "Непрерывный слабый дождь"
                    },
                    new Weather
                    {
                        Date = new Date { Day = "01", Month = November, Year = year2013 },
                        Time = "00:00",
                        Temperature = "7,7",
                        RelativeHumidity = "94,03",
                        DewPoint = "6,8",
                        AtmospherPressure = "742",
                        WindDirection = "З",
                        WindSpeed = "1",
                        Cloudiness = "100",
                        CloudBase = "300",
                        HorizontalVisibility = "",
                        WeatherConditions = "Дымка"
                    },
                    new Weather
                    {
                        Date = new Date { Day = "01", Month = December, Year = year2013 },
                        Time = "00:00",
                        Temperature = "-2,2",
                        RelativeHumidity = "76,29",
                        DewPoint = "-5,8",
                        AtmospherPressure = "749",
                        WindDirection = "Ю",
                        WindSpeed = "1",
                        Cloudiness = "100",
                        CloudBase = "600",
                        HorizontalVisibility = "",
                        WeatherConditions = ""
                    }

                );

                context.Years.AddRange(year2010, year2011, year2012, year2013);
                context.Months.AddRange(January, February, March, April, May, June, July, August, September, October, November, December);

                context.SaveChanges();
            }
        }
    }
}
