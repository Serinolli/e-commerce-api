namespace Domain.Models.Commerce {
    public class CartItem: Entity 
    {
        public Product Product { get; set; }
        public int Quantity { get; set; }

        public CartItem(Product product, int quantity) {
            Product = product;
            Quantity = quantity;
        }
    }
}