using AspNetCoreHero.ToastNotification.Helpers;
using Microsoft.EntityFrameworkCore;

namespace EmlakPortali1.Models
{
    public static class SeedData
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            // Şehir verileri
            modelBuilder.Entity<Sehir>().HasData(
                new Sehir { SehirId = 1, SehirAd = "İstanbul" },
                new Sehir { SehirId = 2, SehirAd = "Ankara" },
                new Sehir { SehirId = 3, SehirAd = "İzmir" }
            );

            // Semt verileri
            modelBuilder.Entity<Semt>().HasData(
                new Semt { SemtId = 1, SemtAd = "Kağıthane", SehirId = 1 },
                new Semt { SemtId = 2, SemtAd = "Keçiören", SehirId = 2 },
                new Semt { SemtId = 3, SemtAd = "Bornova", SehirId = 3 }
            );

            // Mahalle verileri
            modelBuilder.Entity<Mahalle>().HasData(
                new Mahalle { MahalleId = 1, MahalleAd = "Çağlayan", SemtId = 1 },
                new Mahalle { MahalleId = 2, MahalleAd = "İzzetpaşa", SemtId = 1 },
                new Mahalle { MahalleId = 3, MahalleAd = "Talatpaşa", SemtId = 1 }
            );

            // Durum verileri
            modelBuilder.Entity<Durum>().HasData(
                new Durum { DurumId = 1, DurumAd = "Kiralık" },
                new Durum { DurumId = 2, DurumAd = "Satılık" }
            );

            // Tip verileri
            modelBuilder.Entity<Tip>().HasData(
                new Tip { TipId = 1, TipAd = "Ev", DurumId = 1 },
                new Tip { TipId = 2, TipAd = "Ev", DurumId = 2 },
                new Tip { TipId = 3, TipAd = "Dükkan", DurumId = 1 },
                new Tip { TipId = 4, TipAd = "Dükkan", DurumId = 2 },
                new Tip { TipId = 5, TipAd = "Arsa", DurumId = 1 },
                new Tip { TipId = 6, TipAd = "Arsa", DurumId = 2 }
            );

            // Resim verileri
            modelBuilder.Entity<Resim>().HasData(
                new Resim { ResimId=1,ResimAd = "1.jpg", IlanId = 1 }             

            );




            // İlan verileri
            modelBuilder.Entity<Ilan>().HasData(
                new Ilan { IlanId = 1, ResimId=1  ,IlanAd = "Kiralık Ev", Açıklama="Ferah Ev" ,Fiyat=35000 ,OdaSayisi=5,BanyoSayisi=2,Kredi=true,MahalleId=1,SemtId=1,SehirId=1 ,DurumId=1 ,TipId=1 ,Alan=250,Telefon="05302302323",Kat="2.Kat"}
              
            );
        }
    }
}
