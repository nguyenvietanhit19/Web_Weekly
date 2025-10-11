namespace Day08_CodeFirst.Models
{
    public class Customer
    {
        public string Id { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Photo { get; set; } = string.Empty;
        public string Activated { get; set; } = string.Empty;
        public bool Admin { get; set; }

        public virtual List<Order> Orders { get; set; } = new List<Order>();
    }
}
