using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Registration.Models;
using dto = Registration.Dtos;
using model = Registration.Models;

namespace RegisterAutomapperMappingGlobally.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly IMapper _mapper;

        public WeatherForecastController(IMapper mapper)
        {
            _mapper = mapper;
        }

        [HttpGet("GetWeatherForecast")]
        public IActionResult GetWeatherForecast()
        {
            var modelClass1 = new model.Class1() { MyProperty = 10 };
            dto.Class1 dtoClass1 = _mapper.Map<dto.Class1>(modelClass1);
            model.Class1 modelClass = _mapper.Map<model.Class1>(dtoClass1);// test reverse mapping
            return Ok(dtoClass1);
        }

        [HttpGet("GetStudents")]
        public IActionResult GetStudents()
        {
            var modelStudent = new model.Student()
            {
                Addresses = new List<Address> {
                     new Address
                     {
                         District ="tvm",
                         PinCode= 1245,
                         Street= "swe"
                     },
                     new Address
                     {
                         District ="kyc",
                         PinCode= 546,
                         Street= "ind"
                     }
                },
                Id = 1,
                Name= "Anish"
            };



            dto.Student dtoStudent = _mapper.Map<dto.Student>(modelStudent);
            model.Student mappedModelStudent = _mapper.Map<model.Student>(dtoStudent);
            return Ok(dtoStudent);
        }
    }
}