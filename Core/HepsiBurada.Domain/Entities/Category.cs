using HepsiBurada.Domain.Common;

namespace HepsiBurada.Domain.Entities
{
    public class Category : EntityBase
    {
        public int ParentId { get; set; }

        public string Name { get; set; }

        public int Priority { get; set; }

        public ICollection<Detail> Details { get; set; }
        public ICollection<Product> Products { get; set; }

        public Category()
        {
        }

        public Category(int parentId, string name, int priority)
        {
            this.ParentId = parentId;
            this.Name = name;
            this.Priority = priority;
        }

        
    }
}
