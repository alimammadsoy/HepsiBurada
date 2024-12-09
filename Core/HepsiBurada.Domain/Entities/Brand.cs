using HepsiBurada.Domain.Common;

namespace HepsiBurada.Domain.Entities
{
    public class Brand : EntityBase
    {
        public Brand()
        {
            
        }

        public Brand(string name)
        {
            this.Name = name;
        }

        public string Name { get; set; }
    }
}
