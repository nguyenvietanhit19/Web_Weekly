namespace Day08_CodeFirst.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public double UnitPrice { get; set; }
        public string Image { get; set; } = string.Empty;
        public DateTime ProductDate { get; set; }
        public bool Available { get; set; }
        public int CategoryId { get; set; }
        public string Description { get; set; } = string.Empty;

        // Khóa ngoại - liên kết
        public virtual Category Category { get; set; }
        public virtual List<OrderDetail> OrderDetails { get; set; } = new List<OrderDetail>();

    }
}
