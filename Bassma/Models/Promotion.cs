namespace Bassma.Models
{
    public class Promotion
    {
        public int Id { get; set; }
        public string Description { get; set; }

        public int Produit_id { get;set; }
        
        public double NewPrix { get; set; }

        public string DateDebut { get; set; }

        public string DateFin {  get; set; }


    }
}
