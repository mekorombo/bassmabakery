namespace Bassma.Models
{
    public class Commande
        
    {
        public int Id { get; set; }
        public double PrixTotal { get; set; }

        public int User_id { get; set; }

        public string date {  get; set; }
    }
}
