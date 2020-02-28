using System.ComponentModel.DataAnnotations;

namespace Dost.Patiler.Barinak.Models.Database
{
    public class hayvan_yiyecek_tipleri
    {
        [Key]
        public int yiyecek_id { get; set; }
        public string aciklama { get; set; }
        public string resim { get; set; }
    }
}