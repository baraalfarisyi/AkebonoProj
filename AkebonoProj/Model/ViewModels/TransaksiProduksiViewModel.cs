namespace AkebonoProj.Model.ViewModels
{
    public class TransaksiProduksiViewModel
    {
        public DateTime TglTransaksi { get; set; }
        public string KodeItem { get; set; }
        public int QtyActual { get; set; }
        public string KodeLokasi { get; set; }
        public string NPK { get; set; }
        public string NamaLokasi { get; set; }
    }
}
