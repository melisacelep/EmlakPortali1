namespace EmlakPortali1.Models
{
    public class Ilan
    {
        public int IlanId { get; set; }

        public string IlanAd { get; set; }

        public string Açıklama { get; set; }

        public double Fiyat {  get; set; }  

        public int OdaSayisi { get; set; }

        public int BanyoSayisi { get; set; }

        public bool Kredi {  get; set; }    

        public int Alan { get; set; }

        public string Kat {  get; set; }    

        public string Telefon { get; set; }

        public string Adres { get; set; }

        public string UserName { get; set; }    

        public int SehirId { get; set; }

        public int SemtId { get; set; }

        public int DurumId { get; set; }

        public int MahalleId { get; set ; }

        public Mahalle Mahalle { get; set; }

        public int TipId { get; set; }  

        public Tip Tip {  get; set; }

        public int ResimId { get; set; }
        public Resim Resim { get; set; }
        public List<Resim> Resims { get; set; }
        public bool IsActive { get; set; }



    }
}


