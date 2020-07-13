using System.Collections.Generic;
using MDD.Models;

namespace MDD.Data
{
    public class MockMyDailyDataRepository : IMyDailyDataRepository
    {
        public IEnumerable<MyDailyData> GetAllDailyData()
        {
            var data = new List<MyDailyData>
            {
                new MyDailyData{Id = 0, Name="eat", From="1AM", To="8AM", CreationDate="Today"},
                new MyDailyData{Id = 0, Name="sleep", From="8PM", To="9PM", CreationDate="Today"},
                new MyDailyData{Id = 0, Name="travel", From="11AM", To="3PM", CreationDate="Today"}
            };

            return data;
        }

        public MyDailyData GetDailyDataById(int id)
        {
           return new MyDailyData{Id = 0, Name="eat", From="1AM", To="8AM", CreationDate="Today"};
        }
    }
}