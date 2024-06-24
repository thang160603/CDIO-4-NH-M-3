using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CDIO_4._1.Models.EF
{
    [Table("vai_tro_nguoi_dung")]
    public class VaiTroNguoiDung
    {
        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]

        public int ma_vai_tro_nguoi_dung { get; set; }
        public int ma_nguoi_dung { get; set; }
        public int ma_vai_tro { get; set; }
        public virtual VaiTro VaiTro { get; set; }

    }
}