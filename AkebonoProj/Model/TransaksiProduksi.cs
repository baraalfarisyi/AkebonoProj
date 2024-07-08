using AkebonoProj.Models;

namespace AkebonoProj.Model
{
    public class TransaksiProduksi
    {
        public Guid Id { get; set; }
        public DateTime TglTransaksi { get; set; }
        public string NPK { get; set; }
        public string KodeItem { get; set; }
        public string KodeLokasi{ get; set; }
        public int QtyActual { get; set; }
        public virtual Karyawan? Karyawan { get; set; }
        public virtual Lokasi? Lokasi { get; set; }
        public virtual Items? Item { get; set; }
    }
}
