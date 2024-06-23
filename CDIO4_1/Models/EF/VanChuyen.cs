using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CDIO_4._1.Models.EF
{
    [Table("van_chuyen")]
    public class VanChuyen
    {
        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int ma_van_chuyen { get; set; }
        public string ten_van_chuyen { get; set; }
        public decimal phi_van_chuyen { get; set; }

    }
}
