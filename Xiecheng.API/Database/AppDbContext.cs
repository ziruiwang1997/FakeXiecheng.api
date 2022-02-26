using Microsoft.EntityFrameworkCore;
using Xiecheng.API.Models;

namespace Xiecheng.API.Database
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<TouristRoute> TouristRoutes { get; set; }

        public DbSet<TouristRoutePicture> TouristRoutesPicture { get; set; }
        //这个类注册了context 连接真正的数据库

    }
}
