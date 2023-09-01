using System.ComponentModel.DataAnnotations.Schema;


namespace Prova_desenvolvedor.Models
{
    public class Order
    {
        public int? Id { get; set; }
        public Ativo Code { get; set; }
        public int Type { get; set; }
        public int Qntd { get; set; }
        public decimal Price { get; set; }
        public DateTime Date { get; set; }
        public Order()
        {
            Date = DateTime.Now;
        }
    }
}