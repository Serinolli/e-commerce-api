namespace Domain.Models.Commerce {
    public class Category(string name, string description): Entity 
    {
        public string Name { get; set; } = name;
        public string Description { get; set; } = description;
    }

}