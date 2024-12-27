
namespace EmlakPortali1.Models
{
    public class Sehir
    {
        public int SehirId { get; set; }

        public string SehirAd { get;set; }

        public List<Semt> Semts { get; set; }
    }
}
