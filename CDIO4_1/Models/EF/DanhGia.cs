using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CDIO_4._1.Models.EF
{
    [Table("danh_gia")]
    public class DanhGia
    {
        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int ma_danh_gia { get; set; }
        public int ma_san_pham { get; set; }
        public int ma_nguoi_dung { get; set; }
        public string noi_dung  { get; set; }
        public int diem { get; set; }
        public DateTime ngay_danh_gia { get; set; }

    }
}
