using System.Security.Policy;

namespace EmlakPortali1.Models
{
    public class Resim
    {
        public int ResimId { get; set; }
        public string ResimAd { get; set; }

        

        public int IlanId { get; set; }
        public virtual Ilan Ilan { get; set; }
    }
}
