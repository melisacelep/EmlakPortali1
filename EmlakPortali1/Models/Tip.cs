namespace EmlakPortali1.Models
{
    public class Tip
    {

        public int TipId { get; set; }

        public string TipAd { get; set; }

        public int DurumId { get; set; }

        public virtual Durum  Durum { get; set; }
    }
}
