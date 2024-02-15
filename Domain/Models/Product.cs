namespace Domain.Models {
    public class Product : Entity {
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public string Category { get; set; }
        public int Stock { get; set; }        
        public Product(Guid id, string nome, string descricao, decimal preco, string categoria, int estoque)
        {
            Id = id;
            Name = nome;
            Description = descricao;
            Price = preco;
            Category = categoria;
            Stock = estoque;
        }
    }
}
