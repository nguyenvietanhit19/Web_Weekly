namespace Day08_CodeFirst.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string NameVN { get; set; } = string.Empty;

        public virtual List<Product> Products { get; set; } = new List<Product>();
    }
}
