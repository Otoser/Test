using System.Data.Entity;
using System.Linq;
using AlcogolDomain;

namespace AlcogolRepository
{
    public interface IManufacturerRepository
    {
        IQueryable<ManufacturerEntity> GetAll();
        void Save();
        void Delete(ManufacturerEntity entity);
        void Add(ManufacturerEntity entity);
        void Update();
    }

    public class ManufacturerRepository : IManufacturerRepository
    {
        private readonly DbSet<ManufacturerEntity> _entities;
        private readonly DbContext _context;
        public ManufacturerRepository(DbContext context)
        {
            _context = context;
            _entities = _context.Set<ManufacturerEntity>();
        }
        public IQueryable<ManufacturerEntity> GetAll()
        {
            return _entities.AsQueryable();
        }
        public void Save()
        {
            _context.SaveChanges();
        }
        public void Delete(ManufacturerEntity entity)
        {
            _entities.Remove(entity);
        }
        public void Add(ManufacturerEntity entity)
        {
            _entities.Add(entity);
        }
        public void Update()
        {
            _context.SaveChanges();
        }
    }
}