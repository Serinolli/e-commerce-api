namespace Domain.Models.Commerce {
    public class Cart: Entity {
        public List<CartItem> Products { get; set; }

        public Cart(List<CartItem> products) {
            Products = products;
        }
    }

}