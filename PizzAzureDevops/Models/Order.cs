namespace PizzAzureDevops.Models
{
    public class Order
    {
        public int Id { get; set; }
        public string CustomerName { get; set; }
        public int PizzaId { get; set; }
        public Pizza Pizza { get; set; }
        public int Quantity { get; set; }
    }
}
