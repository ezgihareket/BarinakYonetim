using System.ComponentModel.DataAnnotations;

namespace Dost.Patiler.Barinak.Models.Database
{
    public class hayvan_cinsleri
    {
        [Key]
        public int cins_id { get; set; }
        public string adi { get; set; }
        public string aciklama { get; set; }

        public string resim { get; set; }
    }
}