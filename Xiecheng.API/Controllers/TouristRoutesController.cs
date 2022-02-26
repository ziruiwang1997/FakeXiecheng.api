using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xiecheng.API.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Xiecheng.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TouristRoutesController : ControllerBase
    {
        private ITouristRouteRepository _touristRouteRepository;//Controller通过操作repo实例返回数据 通过DI获得repo实例

        public TouristRoutesController(ITouristRouteRepository touristRouteRepository)
        {
            _touristRouteRepository = touristRouteRepository;
        }

        public IActionResult GetTouristRoutes()//API 返回的是一个ActionResult
        {
            var routes = _touristRouteRepository.GetTouristRoutes();
            return Ok(routes);

        }
    }
}
