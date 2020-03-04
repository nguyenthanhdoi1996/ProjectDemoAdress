using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProjectDemoAdress.Models;
using ProjectDemoAdress.Services;

namespace ProjectDemoAdress.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CityController : ControllerBase
    {
        private ICity _city;
        public CityController(ICity city)
        {
            _city = city;

        }
        
        [Route("GetAll")]
        [HttpGet]
        public ApiJsonResult GetRawCertifications()
        {
            try
            {
                var result = _city.getAll();
                if(result != null)
                {
                    return new ApiJsonResult { Success = true, Data = result };
                }
                return new ApiJsonResult { Success = false, Data = null };
            }
            catch (Exception ex)
            {
                return new ApiJsonResult { Success = false, Data = null };

            }
        }
    }
}