using OMSLibrary.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q1.DataAccess
{
    public class DBManager
    {
        public OmsContext dbContext;
        public DBManager()
        {
            dbContext = new OmsContext();
        }

        //list product id and name
        public ObservableCollection<OMSLibrary.Models.ProductInfo> getProducts()
        {
            ObservableCollection<OMSLibrary.Models.ProductInfo> products = new ObservableCollection<OMSLibrary.Models.ProductInfo>();

            var query = from product in dbContext.Products
                        select new OMSLibrary.Models.ProductInfo
                        {
                            IdProduct = product.IdProduct,
                            ProductName = product.IdProduct + " " + product.ProductName
                        };

            foreach (var item in query)
            {
                products.Add(item);
            }

            return products;


        }


        //list Shopper email + basket Id
        public ObservableCollection<BasketShopperInfo> getBasketShopperInfo()
        {
            ObservableCollection<BasketShopperInfo> basketShoppers = new ObservableCollection<BasketShopperInfo>();

            var query = from basket in dbContext.Baskets
                        join shopper in dbContext.Shoppers
                        on basket.IdShopper equals shopper.IdShopper
                        select new BasketShopperInfo { BasketId = basket.IdBasket, ShopperEmail = shopper.Email + " " + basket.IdBasket };

            foreach (var item in query)
            {
                basketShoppers.Add(item);
            }

            return basketShoppers;
        }

        //list basketitem for the grid
        public ObservableCollection<BasketItemInfo> getBasketItemInfo(int id)
        {
            ObservableCollection<BasketItemInfo> basketItems = new ObservableCollection<BasketItemInfo>();

            var query = from item in dbContext.BasketItems
                        join product in dbContext.Products on item.IdProduct equals product.IdProduct
                        where item.IdBasket == id
                        select new BasketItemInfo
                        {
                            IdBasket = (int)item.IdBasket,
                            IdBasketItem = item.IdBasketItem,
                            IdProduct = (short)item.IdProduct,
                            ProductName = product.ProductName,
                            Price = (decimal)product.Price,
                            Quantity = (int)item.Quantity
                        };

            foreach (var item in query)
            {
                basketItems.Add(item);
            }

            return basketItems;

        }

        //Insert the information in the database
        public void InsertBasketItem(int idBasketItem, short idProduct, byte quantity, int idBasket)
        {
            BasketItem newItem = new BasketItem
            {
                IdBasketItem = idBasketItem,
                IdProduct = idProduct,
                Quantity = quantity,
                IdBasket = idBasket
            };

            dbContext.BasketItems.Add(newItem);
            dbContext.SaveChanges();
        }


    }
}
