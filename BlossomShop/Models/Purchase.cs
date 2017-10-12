using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BlossomShop.Models
{
    public class Purchase
    {
        // ID покупки
        public int PurchaseId { get; set; }
        // фио клиента
        public string Client { get; set; }
        // номер телефона
        public string Phone { get; set; }
        // адрес доставки
        public string Address { get; set; }
        // ID книги
        public int BlossomId { get; set; }
        // дата покупки
        public DateTime Date { get; set; }
    }
}