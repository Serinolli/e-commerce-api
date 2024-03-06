using System.Xml.Linq;

namespace Domain.Models.Commerce 
{
    public class Category: Entity 
    {
        public string Name { get; set; } 
        public string Description { get; set; }

        public Category() 
        {
            Name = "";
            Description = "";
        }
        public Category(string name, string description)
        {
            Name = name;
            Description = description;
        }
    }
}