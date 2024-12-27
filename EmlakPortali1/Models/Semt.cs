namespace EmlakPortali1.Models
{
    public class Semt
    {
        public int SemtId { get; set; }

        public string SemtAd { get; set; }

        public int SehirId { get; set; }

        public virtual Sehir  Sehir { get; set; }

        public List<Mahalle> Mahalles { get; set; }


    }
}
