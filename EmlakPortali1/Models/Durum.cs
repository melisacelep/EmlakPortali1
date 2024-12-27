namespace EmlakPortali1.Models
{
    public class Durum
    {
        public int DurumId { get; set; }

        public string DurumAd { get; set; }

        public List<Tip> Tips { get; set;}
    }
}
