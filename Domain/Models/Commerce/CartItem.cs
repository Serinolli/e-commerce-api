namespace Domain.Models.Commerce {
    public class CartItem(Product product, int quantity): Entity 
    {
        public Product Product { get; set; } = product;
        public int Quantity { get; set; } = quantity;
    }
}