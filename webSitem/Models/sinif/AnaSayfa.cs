using System.ComponentModel.DataAnnotations;


namespace webSitem.Models.sinif
{
    public class AnaSayfa
    {
        [Key]
        public int id { get; set; }
        public string profil { get; set; }
        public string isim { get; set; }
        public string unvan { get; set; }
        public string aciklama { get; set; }
        public string iletisim { get; set; }
        public string resim1 { get; set; }
        public string resim2 { get; set; }
        public string resim3 { get; set; }
        public string reklam1 { get; set; }
        public string reklam2 { get; set; }
        public string reklamlink1 { get; set; }
        public string reklamlink2 { get; set; }

    }
}