using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CDIO_4._1.Models.EF
{
    [Table("san_pham")]
    public class SanPham
    {
        public SanPham() { 
            this.NhapKhos = new HashSet<NhapKho>();
            this.ChiTietHoaDonNhaps = new HashSet<ChiTietHoaDonNhap>();
            this.ChiTietHoaDons = new HashSet<ChiTietHoaDon>();
        }
        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int ma_san_pham { get; set; }
        public string ten_san_pham { get; set; }
        public string mo_ta { get; set; }
        public decimal gia { get; set; }
        public int ma_danh_muc { get; set; }
        public int so_luong_ton { get; set; }
        public virtual ICollection<ChiTietHoaDon> ChiTietHoaDons { get; set; }
        public virtual ICollection<NhapKho> NhapKhos { get; set; }
        public virtual ICollection<ChiTietHoaDonNhap> ChiTietHoaDonNhaps { get; set; }
        public virtual DanhMuc DanhMuc { get; set; }

    }
}