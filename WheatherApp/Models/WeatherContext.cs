using Microsoft.EntityFrameworkCore;

namespace WheatherApp.Models
{
    public class WeatherContext : DbContext
    {
        public DbSet<Weather> Weathers { get; set; }
        public DbSet<Date> Dates { get; set; }
        public DbSet<Month> Months { get; set; }
        public DbSet<Year> Years { get; set; }
        public DbSet<FileModel> Files { get; set; }
        public WeatherContext(DbContextOptions<WeatherContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }
    }
}
