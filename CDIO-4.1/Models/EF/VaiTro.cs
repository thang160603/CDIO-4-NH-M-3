using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CDIO_4._1.Models.EF
{
    [Table("vai_tro")]
    public class VaiTro
    {
        public VaiTro() { 
            this.VaiTroNguoiDungs = new HashSet<VaiTroNguoiDung>();
        }
        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]

        public int ma_vai_tro { get; set; }
        public string ten_vai_tro { get;set; }
        public virtual ICollection<VaiTroNguoiDung> VaiTroNguoiDungs { get; set; }
    }
}