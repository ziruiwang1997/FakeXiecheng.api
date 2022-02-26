using System;
using System.Collections.Generic;
using Xiecheng.API.Models;
using System.Linq;

namespace Xiecheng.API.Services
{
    public class MockTouristRouteRepository : ITouristRouteRepository
    {
        private List<TouristRoute> _touristRoutes;//存储假数据的

        public MockTouristRouteRepository()
        {
            if (_touristRoutes == null)
            {
                InitializeTouristRoutes();//生成一个假routes 直接更新field
            }
        }

        private void InitializeTouristRoutes()
        {
            _touristRoutes = new List<TouristRoute>
            {
                new TouristRoute {
                    Id = Guid.NewGuid(),
                    Title = "黄山",
                    Description="黄山真好玩",
                    OriginalPrice = 1299,
                    Features = "<p>吃住行游购娱</p>",
                    Fees = "<p>交通费用自理</p>",
                    Notes="<p>小心危险</p>"
                },
                new TouristRoute {
                    Id = Guid.NewGuid(),
                    Title = "华山",
                    Description="华山真好玩",
                    OriginalPrice = 1299,
                    Features = "<p>吃住行游购娱</p>",
                    Fees = "<p>交通费用自理</p>",
                    Notes="<p>小心危险</p>"
                }
            };
        }


        public TouristRoute GetTouristRoute(Guid touristRouteId)
        {
            return _touristRoutes.FirstOrDefault(route => route.Id == touristRouteId);
            //FirstOrDefault 在一个列表里找第一个匹配的上的Item
        }

        public IEnumerable<TouristRoute> GetTouristRoutes()
        {
            return _touristRoutes;
        }
    }
}
