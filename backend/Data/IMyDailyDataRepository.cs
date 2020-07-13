using System.Collections.Generic;
using MDD.Models;

namespace MDD.Data
{
    public interface IMyDailyDataRepository
    {
        IEnumerable<MyDailyData> GetAllDailyData();
        MyDailyData GetDailyDataById(int id);
    }
}