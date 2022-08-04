using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace webSitem.Models.sinif
{
    public class egitim
    {
        [Key]

        public int id { get; set; }
        public string baslik { get; set; }
        public string ilkokul { get; set; }
        public string ortaokul { get; set; }
        public string lise { get; set; }
        public string uni { get; set; }
        public string bolum { get; set; }
    }
}