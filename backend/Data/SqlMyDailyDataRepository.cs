using System.Collections.Generic;
using System.Linq;
using MDD.Models;

namespace MDD.Data
{
    public class SqlMyDailyDataRepository : IMyDailyDataRepository
    {
        private readonly MyDailyDataContext _context;
        public SqlMyDailyDataRepository(MyDailyDataContext context)
        {
            _context = context;
        }
        public IEnumerable<MyDailyData> GetAllDailyData()
        {
            return _context.Personals.ToList();
        }

        public MyDailyData GetDailyDataById(int id)
        {
          return _context.Personals.FirstOrDefault(p => p.Id == id);
        }
    }
}