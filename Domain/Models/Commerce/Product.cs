namespace Domain.Models.Commerce {
    public class Product(string name, string description, decimal price, string category, int stock, int condition, string? variationKey) : Entity {
        public string Name { get; set; } = name;
        public string Description { get; set; } = description;
        public decimal Price { get; set; } = price;
        public string Category { get; set; } = category;
        public int Stock { get; set; } = stock;        
        public int Condition { get; set; } = stock;        
        public string? VariationKey { get; set; } = variationKey;
    }
}
