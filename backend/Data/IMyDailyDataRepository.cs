using System.Collections.Generic;
using MDD.Models;

namespace MDD.Data
{
    public interface IMyDailyDataRepository
    {
        bool SaveChanges();
        
        IEnumerable<MyDailyData> GetAllDailyData();
        MyDailyData GetDailyDataById(int id);
        void CreateDailyData(MyDailyData data);
    }
}