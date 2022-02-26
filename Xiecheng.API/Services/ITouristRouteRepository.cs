using Xiecheng.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Xiecheng.API.Services
{
    public interface ITouristRouteRepository
    {
        //返回所有路线的数据
        IEnumerable<TouristRoute> GetTouristRoutes();

        //用Id查找单个旅游路线
        TouristRoute GetTouristRoute(Guid touristRouteId);
    }
}
