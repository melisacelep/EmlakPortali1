using Microsoft.AspNetCore.Mvc;
using EmlakPortali1.Models;
using EmlakPortali1.ViewModels;

namespace EmlakPortali1.Controllers
{
    public class IlanlarController : Controller
    {
        private readonly AppDbContext _context;

        public IlanController(AppDbContext context)
        {
            _context = context;
        }

        // İlan Ekleme Sayfasını Göster
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        // İlan Kaydetme İşlemi
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Ilan model)
        {
            if (ModelState.IsValid)
            {
                // Ilan'dan Ilanlar nesnesi oluştur
                var ilan = new Ilan
                {
                    IlanAd = model.IlanAd,
                    Açıklama = model.Açıklama,
                    BanyoSayisi = model.BanyoSayisi,
                    OdaSayisi = model.OdaSayisi,
                    Alan=model.Alan,
                    Adres=model.Adres,

                    Fiyat = model.Fiyat,
                    
                    

                // Veritabanına kaydet
                _context.Ilan.Add(Ilan);
                _context.SaveChanges();

                // Başarılı işlem sonrası yönlendirme
                return RedirectToAction("Index", "Home");
            }

            // Model doğrulama hataları varsa tekrar formu göster
            return View(model);
        }
    }
}
