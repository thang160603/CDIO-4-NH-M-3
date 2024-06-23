using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CDIO_4._1.Models.EF
{
    [Table("nguoi_dung")]
    public class NguoiDung
    {
        public int ma_nguoi_dung { get; set; }
        public string ten_dang_nhap { get; set; }
        public string mat_khau { get; set; }    
        public string email { get; set; }




    }
}