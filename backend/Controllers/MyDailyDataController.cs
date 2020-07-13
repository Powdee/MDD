using System.Collections.Generic;
using MDD.Data;
using MDD.Dtos;
using Microsoft.AspNetCore.Mvc;
using AutoMapper;

namespace MDD.Controllers
{
    // api/commands
    [Route("api/dailydata")]
    [ApiController]
    public class MyDailyDataController : ControllerBase
    {
        private readonly IMyDailyDataRepository _repository;
        private readonly IMapper _mapper;

        public MyDailyDataController(IMyDailyDataRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        // GET api/dailydata
        [HttpGet]
        public ActionResult <IEnumerable<MyDailyDataReadDto>> GetAllDailyData()
        {
            var dailydataItems = _repository.GetAllDailyData();

            return Ok(_mapper.Map<IEnumerable<MyDailyDataReadDto>>(dailydataItems));
        }

        // GET api/dailydata/{id}
        [HttpGet("{id}")]
        public ActionResult <MyDailyDataReadDto> GetDailyDataById(int id)
        {
            var dailyDataItem = _repository.GetDailyDataById(id);
            if (dailyDataItem != null)
            {
                return Ok(_mapper.Map<MyDailyDataReadDto>(dailyDataItem));
            }

            return NotFound();
        }
    }
}