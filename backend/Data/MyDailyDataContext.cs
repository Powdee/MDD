using Microsoft.EntityFrameworkCore;
using MDD.Models;

namespace MDD.Data
{
    public class MyDailyDataContext : DbContext
    {
        public MyDailyDataContext(DbContextOptions<MyDailyDataContext> opt) : base(opt)
        {

        }

        public DbSet<MyDailyData> Personals { get; set; }
    }
}