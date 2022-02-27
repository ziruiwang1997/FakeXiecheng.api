using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Xiecheng.API.Models
{
    public class TouristRoute
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string Title { get; set; }

        [Required]
        [MaxLength(1500)]
        public string Description { get; set; }

        [Column(TypeName ="decimal(18, 2")] //用来表示这一列都受到限制
        public decimal OriginalPrice { get; set; }

        [Range(0.0, 1.0)]
        public double? DiscountPresent { get; set; }//？是可空变量

        public DateTime CreateTime { get; set; }

        public DateTime? UpdateTime { get; set; }

        public DateTime? DepartureTime { get; set; }

        [MaxLength]
        public string Features { get; set; }

        [MaxLength]
        public string Fees { get; set; }

        [MaxLength]
        public string Notes { get; set; }

        //以上是基础属性 我们还需要一些外键关联外部models 比如TouristRoutePictures

        public ICollection<TouristRoutePicture> TouristRoutePictures { get; set; }
            = new List<TouristRoutePicture>();//一对多 可以有多个照片模型 初始化一个数组 更加健壮

    }
}
