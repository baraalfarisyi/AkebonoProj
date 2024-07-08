using System.ComponentModel.DataAnnotations;

namespace AkebonoProj.Model
{
    public class Achievment
    {
        [Key]
        public string Kode { get; set; }
        public DateTime TimeFrom { get; set; }
        public DateTime TimeTo { get; set; }

    }
}
