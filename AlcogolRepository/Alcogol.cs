using AlcogolDomain;

namespace AlcogolRepository
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class Alcogol : DbContext
    {
        // Контекст настроен для использования строки подключения "Alcogol" из файла конфигурации  
        // приложения (App.config или Web.config). По умолчанию эта строка подключения указывает на базу данных 
        // "AlcogolRepository.Alcogol" в экземпляре LocalDb. 
        // 
        // Если требуется выбрать другую базу данных или поставщик базы данных, измените строку подключения "Alcogol" 
        // в файле конфигурации приложения.

        public virtual DbSet<ProductsEntity> Products { get; set; }
       // public virtual DbSet<BasketEntity> Basket { get; set; }
       // public virtual DbSet<BranchesEntity> Branches { get; set; }
       // public virtual DbSet<ListTheUserEntity> ListTheUser { get; set; }
        public virtual DbSet<ManufacturerEntity> Manufacturer { get; set; }
        //public virtual DbSet<ReviwesEntity> Reviwes { get; set; }

        static Alcogol()
        {
            Database.SetInitializer<Alcogol>(new AlcogolDbIntializer());
        }
        public Alcogol()
            : base("Alcogol")
        {
        }


      
        // Добавьте DbSet для каждого типа сущности, который требуется включить в модель. Дополнительные сведения 
        // о настройке и использовании модели Code First см. в статье http://go.microsoft.com/fwlink/?LinkId=390109.

        // public virtual DbSet<MyEntity> MyEntities { get; set; }
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}