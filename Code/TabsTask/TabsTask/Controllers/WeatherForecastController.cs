using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TabsTask.ApplicationContext;
using TabsTask.Repositories;

namespace TabsTask.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly IUserManagement _UserManagement;
        public WeatherForecastController(IUserManagement UserManagement)
        {
            _UserManagement = UserManagement;
        }

        [HttpGet]
        public ActionResult Get()
        {
            try
            {
                return Ok(_UserManagement.GetUserInformation());

            }
            catch (Exception ex)
            {

                throw;
            }
           
        }
    }
}
