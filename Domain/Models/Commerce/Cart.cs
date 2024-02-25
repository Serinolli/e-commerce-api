namespace Domain.Models.Commerce {
    public class Cart: Entity 
    {
        public List<CartItem> Products { get; set; } = [];
    }

}