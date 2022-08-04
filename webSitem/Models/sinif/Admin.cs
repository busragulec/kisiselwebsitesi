using System.ComponentModel.DataAnnotations;


namespace webSitem.Models.sinif
{
    public class Admin
    {
        [Key]
        public int id { get; set; }
        public string kullaniciAdi { get; set; }
        public string sifre { get; set; }
    }
}