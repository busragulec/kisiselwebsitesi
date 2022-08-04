using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace webSitem.Models.sinif
{
    public class iletisim
    {
        [Key]

        public int id { get; set; }
        public string baslik { get; set; }
        public string telefon { get; set; }
        public string mail { get; set; }
        public string harita { get; set; }
    }
}