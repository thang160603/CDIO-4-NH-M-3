using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CDIO_4._1.Models.EF
{
    [Table("danh_muc")]
    public class DanhMuc
    {
        public int ma_danh_muc { get; set; }
        public string ten_danh_muc { get; set; }

    }
}