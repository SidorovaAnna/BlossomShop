using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace BlossomShop.Models
{
    //заполняем табл. в Индексе начальными значениями

    public class BlossomDbInitializer : DropCreateDatabaseAlways<BlossomContext>
    {
        protected override void Seed(BlossomContext db)
        {
            db.Blossoms.Add(new Blossom { Name = "Ромашка", Description = "Полевой цветок с белыми лепестками. подходит для гадания", Price = 15 });
            db.Blossoms.Add(new Blossom {Name="Лютик", Description= "Полевой цветок с желтыми лепестками. Сорняк.", Price = 20});
            db.Blossoms.Add(new Blossom { Name = "Василек", Description = "Полевой цветок с синими лепестками. водится во ржи.", Price = 50});
            
            base.Seed(db);
        }
    }
}