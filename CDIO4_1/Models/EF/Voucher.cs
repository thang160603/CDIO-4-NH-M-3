using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CDIO_4._1.Models.EF
{
    [Table("voucher")]
    public class Voucher
    {
        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int ma_voucher { get; set; }
        public int ma_nguoi_dung { get; set; }
        public string ten_voucher { get; set; }
        public decimal gia_tri { get; set; }
        public DateTime ngay_bat_dau { get; set; }
        public DateTime ngay_het_han { get; set; }

    }
}
