using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CDIO4_1.Models.EF
{
    [Table("danh_muc")]
    public class DanhMuc
    {
        public DanhMuc()
        {
            this.SanPhams = new HashSet<SanPham>();
        }
        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int ma_danh_muc { get; set; }
        public string ten_danh_muc { get; set; }
        public virtual ICollection<SanPham> SanPhams { get; set; }


    }
}
