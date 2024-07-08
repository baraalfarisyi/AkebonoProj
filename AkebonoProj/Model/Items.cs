using AkebonoProj.Model;
using System.ComponentModel.DataAnnotations;

namespace AkebonoProj.Models
{
    public class Items
    {
        [Key]
        public string Kode{ get; set; }
        public string NameItem { get; set; }
        public virtual List<TransaksiProduksi> TransaksiProduksis { get; set; } = new();
        public virtual Planning? Planning { get; set; }
    }
}
