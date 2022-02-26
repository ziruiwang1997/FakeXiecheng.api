using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Xiecheng.API.Models
{
    public class TouristRoutePicture
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }//picture自己的id 主键

        [MaxLength(100)]
        public string Url { get; set; }//picture url

        //用外键连接一个外部model的时候 我们用这个model的ID作为外键
        //同时也要绑定这个model本身 即TouristRoute
        //一个pic最多对应一个旅游路线 所以在这里用路线id作为外键 这个变量命名可以和route里的id不一样
        //TouristRoute的ID在外部作为外键的时候 自动映射成为TouristRouteId
        [ForeignKey("TouristRouteId")]
        public Guid TouristRouteId { get; set; }

        public TouristRoute TouristRoute { get; set; }
    }
}
