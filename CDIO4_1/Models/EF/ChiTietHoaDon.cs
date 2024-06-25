using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CDIO4_1.Models.EF
{
    [Table("chi_tiet_hoa_don")]
    public class ChiTietHoaDon
    {
        [key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int ma_chi_tiet_hoa_don { get; set; }
        public int ma_don_hang { get; set; }
        public int ma_san_pham { get; set; }
        public int so_luong { get; set; }
        public decimal don_gia { get; set; }
        public decimal thanh_tien { get; set; }
        public virtual DonHang DonHang { get; set; }
        public virtual SanPham SanPham { get; set; }

    }
}
