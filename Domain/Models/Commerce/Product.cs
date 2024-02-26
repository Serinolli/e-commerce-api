using Domain.Models.Commerce.Enums;

namespace Domain.Models.Commerce
{
    public class Product : Entity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public string Category { get; set; }
        public int Stock { get; set; }
        public ProductCondition Condition { get; set; }
        public string? VariationKey { get; set; }

        public Product(string name, string description, decimal price, string category, int stock, ProductCondition? condition, string? variationKey)
        {
            Name = name;
            Description = description;
            Price = price;
            Category = category;
            Stock = stock;
            Condition = condition ?? ProductCondition.NotInformed;
            VariationKey = variationKey;
        }
    }
}
