using Microsoft.EntityFrameworkCore;
using WebApi.Entities;

namespace WebApi.Helpers
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }
        public DataContext() : base()
        {

        }

        public DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                //  optionsBuilder.UseSqlServer(@"Server=13.59.157.144; Database=FoodInfoService; User Id=fiservice;Password=foodinfoservice;MultipleActiveResultSets:true");
                 optionsBuilder.UseSqlServer(@"Server=DESKTOP-S44KKNG; Database=Ecommerce; Trusted_Connection=True; MultipleActiveResultSets= True;");
               // optionsBuilder.UseSqlServer(@"Server=FATIH; Database=Ecommerce; Trusted_Connection=True; MultipleActiveResultSets= True;");
            }
        }
    }
}