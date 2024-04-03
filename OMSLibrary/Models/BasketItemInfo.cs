using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OMSLibrary.Models
{
    public class BasketItemInfo
    {
        public int IdBasket { get; set; }
        public int IdBasketItem { get; set; }
        public short IdProduct { get; set; }
        public string ProductName { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
    }
}
