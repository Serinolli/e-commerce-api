namespace Domain.Models.Commerce {
    public class Cart(List<CartItem> products): Entity {
        public List<CartItem> Products { get; set; } = products;
    }

}