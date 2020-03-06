
using System.ComponentModel.DataAnnotations;
namespace Dost.Patiler.Barinak.Models.Database
{
    public class hayvan_hastaliklari
    {
        [Key]
        public int hastalik_id { get; set; }
        public string hastalik_adi { get; set; }
        public string bulasici { get; set; }
    }
}