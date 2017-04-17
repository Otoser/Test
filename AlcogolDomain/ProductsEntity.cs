using System.Collections.Generic;

namespace AlcogolDomain
{
    public class ProductsEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public int Excerpt { get; set; }
        public int Discount { get; set; }
        public int Amount { get; set; }
      //  public int ReviwesEntityId { get; set; }
//        public virtual ReviwesEntity ReviwesEntity { get; set; }
//        public int BranchesEntityId { get; set; }
//        public virtual BranchesEntity BranchesEntity { get; set; }
//        public virtual List<BasketEntity> BasketEntity { get; set; }
        public int ManufacturerEntityId { get; set; }
       public virtual ManufacturerEntity ManufacturerEntity { get; set; }
        public int AverageRating { get; set; }
    }
}