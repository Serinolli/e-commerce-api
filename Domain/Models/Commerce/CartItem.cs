namespace Domain.Models.Commerce {
    public class CartItem: Entity 
    {
        public Product? Product { get; set; }
        public Guid ProductId { get; set; }
        public int Quantity { get; set; }

    }
}