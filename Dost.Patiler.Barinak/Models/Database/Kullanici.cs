using System.ComponentModel.DataAnnotations;

namespace Dost.Patiler.Barinak.Models.Database
{
    public class Kullanici
    {
        [Key]
        public int kullanici_id { get; set; }
        public string ad { get; set; }
        public string soyad { get; set; }

        public string email { get; set; }
        public string sifre { get; set; }

        public string sehir { get; set; }
    }
}