
using System.ComponentModel.DataAnnotations;

namespace AkebonoProj.Model
{
    public class Lokasi
    {
        [Key]
        public string Kode { get; set; }
        public string NameLocation { get; set; }
        public virtual List<TransaksiProduksi> TransaksiProduksis { get; set; } = new();
    }
}
