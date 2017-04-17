using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using AlcogolDomain;

namespace AlcogolRepository
{
   public class AlcogolDbIntializer : DropCreateDatabaseIfModelChanges<Alcogol>
        
        
    {
        protected override void Seed(Alcogol context)
        {
            //context.Branches.Add(new BranchesEntity
            //    {
            //    DirectorName="Витя",
            //    Adress="северный",
            //    City="Бердск",
            //    Phone="89139853325",
            //    Mail="Dorovef_pityx@mail.ru"

            //});
            //context.Branches.Add(new BranchesEntity
            //{
            //    DirectorName = "Андрей",
            //    Adress = "северный",
            //    City = "Бердск",
            //    Phone = "89534456778",
            //    Mail = "Andrey_programmist_sportsmen@mail.ru"

            //});
            //context.Branches.Add(new BranchesEntity
            //{
            //    DirectorName = "Влад",
            //    Adress = "северный",
            //    City = "Бердск",
            //    Phone = "89538852562",
            //    Mail = "Vlad_programmist_sportsmen@mail.ru"

            //});
            //context.Branches.Add(new BranchesEntity
            //{
            //    DirectorName = "Коля",
            //    Adress = "Южный",
            //    City = "Бердск",
            //    Phone = "89139853459",
            //    Mail = "Малышь_228@mail.ru"

            //});
            //context.Branches.Add(new BranchesEntity
            //{
            //    DirectorName = "Артем",
            //    Adress = "центр",
            //    City = "Бердск",
            //    Phone = "89139433325",
            //    Mail = "Собака забияка@mail.ru"

            //});
            //context.Manufacturer.Add(new ManufacturerEntity
            //{
            //    CompanyName = "Святые",
            //    ReviewsCompany = "Всем советую отличная компания",
            //    Mail = "sin@mail.ru",
            //    Phone = "89146443547",
            //    Contract = false


            //});
            context.Manufacturer.Add(new ManufacturerEntity
            {

                Name = "Пиво"

            });
            context.Manufacturer.Add(new ManufacturerEntity
            {
                Name = "Водка"

            });
            //context.Manufacturer.Add(new ManufacturerEntity
            //{
            //    CompanyName = "Огурцы",
            //    ReviewsCompany = "Хорошая компания",
            //    Mail = "papa@mail.ru",
            //    Phone = "891464682347",
            //    Contract = true


                //});
                //context.Manufacturer.Add(new ManufacturerEntity
                //{
                //    CompanyName = "Помидоры",
                //    ReviewsCompany = "Так себе компания",
                //    Mail = "mama@mail.ru",
                //    Phone = "89123213124",
                //    Contract = true


                //});

                //context.Reviwes.Add(new ReviwesEntity
                //{
                //    Evaluation = 2,
                //    Comment = "Хорошее",
                //    Time = "Ваще хз что за время",
                //    Marks = 5

                //});
                //context.Reviwes.Add(new ReviwesEntity
                //{
                //    Evaluation = 5,
                //    Comment = "Самое лучшее",
                //    Time = "Ваще хз что за время",
                //    Marks = 2

                //});

                //context.Reviwes.Add(new ReviwesEntity
                //{
                //    Evaluation = 1,
                //    Comment = "Офигенское",
                //    Time = "Ваще хз что за время",
                //    Marks = 3

                //});

                //context.Reviwes.Add(new ReviwesEntity
                //{
                //    Evaluation = 4,
                //    Comment = "Отличное",
                //    Time = "Ваще хз что за время",
                //    Marks = 4

                //});
                //context.Reviwes.Add(new ReviwesEntity
                //{
                //    Evaluation = 3,
                //    Comment = "От души",
                //    Time = "Ваще хз что за время",
                //    Marks = 1

                //});

                context.Products.Add(new ProductsEntity
            {
                Name = "Водка",
                Price = 150,
                Excerpt = 2,
                Discount = 10,
                Amount = 1,
              //  ReviwesEntityId=4,
                AverageRating=3,
                ManufacturerEntityId=1,
               // BranchesEntityId=2


            });
            context.Products.Add(new ProductsEntity
            {
                Name = "Эрландский Эль",
                Price = 90,
                Excerpt = 2,
                Discount = 20,
                Amount = 3,
               // ReviwesEntityId = 4,
                AverageRating = 3,
                ManufacturerEntityId = 1,
               // BranchesEntityId = 1


            });
            context.Products.Add(new ProductsEntity
            {
                Name = "Сладовар",
                Price = 80,
                Excerpt = 2,
                Discount = 5,
                Amount = 3,
              //  ReviwesEntityId = 5,
                AverageRating = 4,
                ManufacturerEntityId = 1,
               // BranchesEntityId = 3


            });
            context.Products.Add(new ProductsEntity
            {
                Name = "Чешское светлое",
                Price = 60,
                Excerpt = 2,
                Discount = 10,
                Amount = 3,
                //ReviwesEntityId = 1,
                AverageRating = 5,
                ManufacturerEntityId = 1,
               // BranchesEntityId = 3


            });
            context.Products.Add(new ProductsEntity
            {
                Name = "Чешское темное",
                Price = 70,
                Excerpt = 3,
                Discount = 9,
                Amount = 3,
              //  ReviwesEntityId = 2,
                AverageRating = 3,
                ManufacturerEntityId = 1,
               // BranchesEntityId = 5


            });



           // base.Seed(context);
            context.SaveChanges();
        }
    }
}
