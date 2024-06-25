using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CDIO4_1.Models.EF
{
    [Table("don_hang")]
    public class DonHang
    {
        public DonHang()
        {
            this.ChiTietHoaDons = new HashSet<ChiTietHoaDon>();
        }
        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int ma_don_hang { get; set; }
        public int ma_nguoi_dung { get; set; }
        public DateTime ngay_dat { get; set; }
        public decimal tong_tien { get; set; }
        public string trang_thai { get; set; }
        public int ma_van_chuyen { get; set; }
        public string Phuong_thuc_thanh_toan { get; set; }
        public int ma_danh_gia { get; set; }
        public int ma_vocucher { get; set; }
        public virtual Voucher Voucher { get; set; }
        public virtual VanChuyen VanChuyen { get; set; }
        public virtual NguoiDung NguoiDung { get; set; }
        public virtual DanhGia DanhGia { get; set; }
        public virtual ICollection<ChiTietHoaDon> ChiTietHoaDons { get; set; }








    }
}
