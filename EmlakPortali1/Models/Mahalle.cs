namespace EmlakPortali1.Models
{
    public class Mahalle
    {
        public int MahalleId { get; set; }
        public string MahalleAd { get; set;}

        public int SemtId { get; set; }

        public virtual Semt Semt { get; set; }
    }
}
