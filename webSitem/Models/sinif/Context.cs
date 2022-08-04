using System.Data.Entity;


namespace webSitem.Models.sinif
{
    public class Context : DbContext
    {
        public DbSet<Admin> Admins { get; set; }
        public DbSet<AnaSayfa> AnaSAyfas{ get; set; }
        public DbSet<ikons> Ikons { get; set; }
        public System.Data.Entity.DbSet<webSitem.Models.sinif.iletisim> iletisims { get; set; }

        public System.Data.Entity.DbSet<webSitem.Models.sinif.egitim> egitims { get; set; }

        public System.Data.Entity.DbSet<webSitem.Models.sinif.hakkinda> hakkindas { get; set; }

    }
}