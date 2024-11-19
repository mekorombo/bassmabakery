namespace Bassma.Models
{
    public class Paiement
    {
        public int Id { get; set; }

        public int Commande_id { get; set; }

        public string statut {  get; set; }
    }
}
