using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BlossomShop.Models
{
    public class Blossom
    {
        // ID цветка
        public int Id { get; set; }
        // название цветка
        public string Name { get; set; }
        // описание
        public string Description { get; set; }
        // цена
        public int Price { get; set; }
    }
}