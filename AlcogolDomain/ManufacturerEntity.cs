using System.Collections.Generic;
namespace AlcogolDomain
{
    public class ManufacturerEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual List<ProductsEntity> ProductsEntities { get; set; } 
    }
}