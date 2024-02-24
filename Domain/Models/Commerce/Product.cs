using Domain.Models.Commerce; 

namespace Domain.Models.Commerce {
    public class Product(string name, string description, decimal price, string category, int stock, ProductCondition? condition, string? variationKey) : Entity {
        public string Name { get; set; } = name;
        public string Description { get; set; } = description;
        public decimal Price { get; set; } = price;
        public string Category { get; set; } = category;
        public int Stock { get; set; } = stock;        
        public ProductCondition Condition { get; set; } = condition ?? ProductCondition.NotInformed;        
        public string? VariationKey { get; set; } = variationKey;
    }
}
