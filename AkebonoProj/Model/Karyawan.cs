using AkebonoProj.Areas.Identity.Data;
using AkebonoProj.Model;
using System.ComponentModel.DataAnnotations;

namespace AkebonoProj.Models
{
    public class Karyawan
    {
        [Key]
        public string NPK { get; set; }
        public Guid UserId { get; set; }
        public string Name { get; set; }
        public string Alamat { get; set; }
        public virtual List<TransaksiProduksi> TransaksiProduksis { get; set; } = new();
        public virtual AkebonoProjUser AkebonoProjUser { get; set; }
    }
}
