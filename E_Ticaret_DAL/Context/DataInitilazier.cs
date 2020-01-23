using E_Ticaret_Entity.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Ticaret_DAL.Context
{
    public class DataInitilazier:DropCreateDatabaseIfModelChanges<DataContext>
    {
        protected override void Seed(DataContext context)
        {
            var kategoriler = new List<Category>()
            {
                new Category(){Name="Daire", Description="Kiralık"},
          
            };

            //foreach (var kategori in kategoriler)
            //{
            //    context.Categories.Add(kategori);
            //}

            context.Categories.AddRange(kategoriler);
            context.SaveChanges();

            var urunler = new List<Product>()
            {
                new Product(){ Name = "Sea view property ",Description = "Miami", Price =110000 , SquareMeter =150 ,RoomQuantity="3+1", heat="Doğalgaz", IsSell=true, CategoryId = 1,Image="property_1.jpg"},
                new Product(){ Name = "Sea view property2",Description = "Miami2", Price =120000 , SquareMeter =250 ,RoomQuantity="4+1", heat="Jeotermal", IsSell=true, CategoryId = 1,Image="property_2.jpg"},
                new Product(){ Name = "Sea view property3",Description = "Miami3", Price =130000 , SquareMeter =350 ,RoomQuantity="5+1", heat="Klima", IsSell=true, CategoryId = 1,Image="property_3.jpg"},
                new Product(){ Name = "Sea view property4",Description = "Miami4", Price =140000 , SquareMeter =450 ,RoomQuantity="3+1", heat="Doğalgaz", IsSell=true, CategoryId = 1,Image="property_1.jpg"},
                new Product(){ Name = "Sea view property5",Description = "Miami5", Price =150000 , SquareMeter =550 ,RoomQuantity="4+1", heat="Jeotermal", IsSell=true, CategoryId = 1,Image="property_2.jpg"},
                new Product(){ Name = "Sea view property6",Description = "Miami6", Price =160000 , SquareMeter =650 ,RoomQuantity="5+1", heat="Klima", IsSell=true, CategoryId = 1,Image="property_3.jpg"},
                new Product(){ Name = "Sea view property7",Description = "Miami7", Price =170000 , SquareMeter =750 ,RoomQuantity="3+1", heat="Doğalgaz", IsSell=true, CategoryId = 1,Image="property_1.jpg"},
                new Product(){ Name = "Sea view property8",Description = "Miami8", Price =180000 , SquareMeter =850 ,RoomQuantity="4+1", heat="Jeotermal", IsSell=true, CategoryId = 1,Image="property_2.jpg"},
                new Product(){ Name = "Sea view property9",Description = "Miami9", Price =190000 , SquareMeter =950 ,RoomQuantity="5+1",heat="Klima", IsSell=true, CategoryId = 1,Image="property_3.jpg"},
                new Product(){ Name = "Sea view property10",Description = "Miami10", Price =200000 , SquareMeter =100 ,RoomQuantity="3+1", heat="Doğalgaz", IsSell=true, CategoryId = 1,Image="property_1.jpg"},
                new Product(){ Name = "Sea view property11",Description = "Miami11", Price =210000 , SquareMeter =200 ,RoomQuantity="4+1", heat="Jeotermal", IsSell=true, CategoryId = 1,Image="property_2.jpg"},
                new Product(){ Name = "Sea view property12",Description = "Miami12", Price =220000 , SquareMeter =300 ,RoomQuantity="5+1",heat="Klima", IsSell=true, CategoryId = 1,Image="property_3.jpg"},

            };

            foreach (var urun in urunler)
            {
                context.Products.Add(urun);
            }

            context.SaveChanges();

            base.Seed(context);


        }
    }
}
