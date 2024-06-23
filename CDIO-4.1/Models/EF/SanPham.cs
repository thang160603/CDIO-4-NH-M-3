using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CDIO_4._1.Models.EF
{
    [Table("san_pham")]
    public class SanPham
    {
        public int ma_san_pham { get; set; }
        public string ten_san_pham { get; set; }
        public string mo_ta { get; set; }
        public decimal gia { get; set; }
        public int ma_danh_muc { get; set; }
        public int so_luong_ton { get; set; }

    }
}