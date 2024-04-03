using OMSLibrary.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q1.ViewModels
{
    public class AddItemToOrderViewModel : ViewModelBase
    {
        private ObservableCollection<BasketShopperInfo> _basketShopperInfo;
        private ObservableCollection<ProductInfo> _products;

        public ObservableCollection<BasketShopperInfo> BasketShopperInfo
        {
            get { return _basketShopperInfo; }
            set { SetProperty(ref _basketShopperInfo, value); }
        }

        public ObservableCollection<ProductInfo> ProductInfo
        {
            get { return _products; }
            set { SetProperty(ref _products, value); }
        }


        public AddItemToOrderViewModel()
        {
            _basketShopperInfo = dbmanager.getBasketShopperInfo();
            _products = dbmanager.getProducts();

        }
    }

}
