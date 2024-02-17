namespace Domain.Models.Commerce {
    public class Product(string name, string description, decimal price, string category, int stock) : Entity {
        public string Name { get; set; } = name;
        public string Description { get; set; } = description;
        public decimal Price { get; set; } = price;
        public string Category { get; set; } = category;
        public int Stock { get; set; } = stock;        
    }
}
