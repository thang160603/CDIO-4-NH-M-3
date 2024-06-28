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
        public int ma_nha_cung_cap { get; set; }
        public int ten_nha_cung_cap { get; set; }
        public int thong_tin_lien_he { get; set; }
        public int ten_dang_nhap { get; set; }
        public int mat_khau { get; set; }
        public virtual ICollection<NhapKho> NhapKho { get; set;}

    }
}
