using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CDIO_4._1.Models.EF
{
    [Table("chi_tiet_hoa_don_nhap")]
    public class ChiTietHoaDonNhap
    {
        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int ma_chi_tiet_nhap { get; set; }
        public int ma_nhap_kho { get; set; }
        public int ma_san_pham { get; set; }
        public int so_luong { get; set; }
        public decimal thanh_tien { get; set; }
        public decimal don_gia { get; set; }

        public virtual SanPham SanPham { get; set; }
        public virtual NhapKho NhapKho { get; set; }

    }
}