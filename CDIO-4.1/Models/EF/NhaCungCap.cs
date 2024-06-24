using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CDIO_4._1.Models.EF
{
    [Table("nha_cung_cap")]
    public class NhaCungCap
    {
        public NhaCungCap() { 
            this.NhapKho = new HashSet<NhapKho>();
        }
        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int ma_nhap_kho { get; set; }
        public int ma_san_pham { get; set; }
        public int ma_nha_cung_cap { get; set; }
        public int so_luong { get; set; }
        public DateTime ngay_nhap { get; set; }
        public virtual ICollection<NhapKho> NhapKho { get; set;}

    }
}