using System.Collections.Generic;
using System.Linq;
using MDD.Models;
using System;

namespace MDD.Data
{
    public class SqlMyDailyDataRepository : IMyDailyDataRepository
    {
        private readonly MyDailyDataContext _context;

        public SqlMyDailyDataRepository(MyDailyDataContext context)
        {
            _context = context;
        }

        public void CreateDailyData(MyDailyData data)
        {
            if (data == null)
            {
                throw new ArgumentNullException(nameof(data));
            }

            _context.Add(data);
        }

        public IEnumerable<MyDailyData> GetAllDailyData()
        {
            return _context.Personals.ToList();
        }

        public MyDailyData GetDailyDataById(int id)
        {
          return _context.Personals.FirstOrDefault(p => p.Id == id);
        }

        public bool SaveChanges()
        {
            return (_context.SaveChanges() >= 0);
        }
    }
}