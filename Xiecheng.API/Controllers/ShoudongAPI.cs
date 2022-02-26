using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Xiecheng.API.Controllers
{
    [Route("api/shoudongapi")]
    public class ShoudongAPI : Controller
    {
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "1", "2", "3" };
        }

    }
}
