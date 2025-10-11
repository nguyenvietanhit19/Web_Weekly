namespace Day08_CodeFirst.Models
{
    public class Order
    {
        public int Id { get; set; }
        public string CustomerId { get; set; } = string.Empty;
        public DateTime OrderDate { get; set; }
        public string Address { get; set; } = string.Empty;
        public double Amount { get; set; }
        public string Description { get; set; } = string.Empty;

        public virtual Customer Customer { get; set; }
        public virtual List<OrderDetail> OrderDetails { get; set; } = new List<OrderDetail>();
    }
}
