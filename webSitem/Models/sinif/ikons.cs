using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace webSitem.Models.sinif
{
    public class ikons
    {
        [Key]
        public int ikonid { get; set; }
        public string ikon { get; set; }
        public string link { get; set; }
    }
}