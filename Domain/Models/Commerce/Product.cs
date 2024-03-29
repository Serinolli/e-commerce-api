using Domain.Models.Commerce.Enums;

namespace Domain.Models.Commerce
{
    public class Product : Entity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public Category? Category { get; set; }
        public int Stock { get; set; }
        public ProductCondition Condition { get; set; }
        public string? VariationKey { get; set; }

        public Product()
        {
            Name = string.Empty;
            Description = string.Empty;
            Price = 0;
            Condition = ProductCondition.NotInformed;
        }

        public Product(string name, string description, decimal price, int stock, Category? category, ProductCondition? condition, string? variationKey)
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
