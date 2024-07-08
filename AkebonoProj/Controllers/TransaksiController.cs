using AkebonoProj.Data;
using AkebonoProj.Model;
using AkebonoProj.Model.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;

namespace AkebonoProj.Controllers
{
    public class TransaksiController : Controller
    {
        protected readonly AkebonoProjContext _dbContext;
        public TransaksiController(AkebonoProjContext dbContext)
        {
            _dbContext = dbContext;
        }

        
        [HttpGet]
        public async Task<ActionResult> Index()
        {
            var transaksi = await (from tp in _dbContext.TransaksiProduksis
                                   join l in _dbContext.Lokasis on tp.KodeLokasi equals l.Kode
                                   select new
                                   {
                                       TglTransaksi = tp.TglTransaksi,
                                       KodeItem = tp.KodeItem,
                                       QtyActual = tp.QtyActual,
                                       KodeLokasi = tp.KodeLokasi,
                                       NPK = tp.NPK,
                                       NamaLokasi = l.NameLocation,
                                       CreatedBy = Guid.Parse(User.FindFirstValue(ClaimTypes.NameIdentifier))
                                   }
                                   ).ToListAsync();
            return View(transaksi);

        }

        [HttpGet]
        public ActionResult Insert()
        {

            return View();
        }

        [Route("Transaksi")]
        [HttpPost]
        public async Task<ActionResult> Insert(TransaksiInput transaksiInput)
        {
            static string GetKodeLokasi(string namaLokasi)
            {
                if (namaLokasi == "Lokasi 1")
                {
                    return "L001";
                }
                else if (namaLokasi == "Lokasi 2")
                {
                    return "L002";
                }
                else if (namaLokasi == "Lokasi 3")
                {
                    return "L003";
                }
                else if (namaLokasi == "Lokasi 4")
                {
                    return "L004";
                }
                else
                {
                    throw new ArgumentException("Kode lokasi tidak valid");
                }
            }

            var transaksi = new TransaksiProduksi()
            {
                TglTransaksi = transaksiInput.TanggalHariIni ?? DateTime.Now,
                KodeItem = transaksiInput.KodeItem ?? "",
                QtyActual = transaksiInput.QtyActual ?? 0,
                KodeLokasi = GetKodeLokasi(transaksiInput.NameLocation ?? ""),
                NPK = transaksiInput.NPK ?? ""
            };

            await _dbContext.TransaksiProduksis.AddAsync(transaksi);
            await _dbContext.SaveChangesAsync();

            return RedirectToAction("Index");
        }
    }
}
