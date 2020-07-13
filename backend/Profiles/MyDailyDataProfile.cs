using AutoMapper;
using MDD.Models;
using MDD.Dtos;

namespace MDD.Profiles
{
    public class MyDailyDataProfiles : Profile
    {
        public MyDailyDataProfiles()
        {
            // Source -> Target
            CreateMap<MyDailyData, MyDailyDataReadDto>();
            CreateMap<MyDailyDataCreateDto, MyDailyData>();
        }
    }
}