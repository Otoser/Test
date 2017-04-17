using System.Data.Entity;
using System.Linq;
using AlcogolDomain;

namespace AlcogolRepository
{
    public interface IProductRepository
    {
        IQueryable<ProductsEntity> GetAll();
        void Save();
        void Delete(ProductsEntity entity);
        void Add(ProductsEntity entity);
        void Update();
        void SaveProduct(ProductsEntity product);
        ProductsEntity DeleteProduct(int Id);
    }

    public class ProductRepository : IProductRepository
    {
        private readonly DbSet<ProductsEntity> _entities;
        private readonly DbContext _context;
        public ProductRepository(DbContext context)
        {
            _context = context;
            _entities = _context.Set<ProductsEntity>();
        }
        public IQueryable<ProductsEntity> GetAll()
        {
            return _entities.AsQueryable();
        }
        public void Save()
        {
            _context.SaveChanges();
        }
        public void Delete(ProductsEntity entity)
        {
            _entities.Remove(entity);
        }
        public void Add(ProductsEntity entity)
        {
            _entities.Add(entity);
        }
        public void Update()
        {
            _context.SaveChanges();
        }
        public void SaveProduct(ProductsEntity product)
        {
            if (product.Id == 0)
                _entities.Add(product);
            else
            {
                ProductsEntity dbEntry = _entities.Find(product.Id);
                if (dbEntry != null)
                {
                    dbEntry.Name = product.Name;
                    dbEntry.Excerpt = product.Excerpt;
                    dbEntry.Price = product.Price;
                    dbEntry.ManufacturerEntityId = product.ManufacturerEntityId;
                    dbEntry.Discount = product.Discount;
                    dbEntry.Amount = product.Amount;
                    dbEntry.AverageRating = product.AverageRating;
                }
            }
            _context.SaveChanges();
        }
        public ProductsEntity DeleteProduct(int gameId)
        {
            ProductsEntity dbEntry = _entities.Find(gameId);
            if (dbEntry != null)
            {
                _entities.Remove(dbEntry);
                _context.SaveChanges();
            }
            return dbEntry;
        }
    }
}