using OMSLibrary.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q1.ViewModels
{
    public class ListOrderDetailViewModel : ViewModelBase
    {
        private ObservableCollection<BasketShopperInfo>? _basketShopperInfo;
        private ObservableCollection<BasketItemInfo>? _basketItemInfo;

        public ObservableCollection<BasketShopperInfo> BasketShopperInfo
        {
            get { return _basketShopperInfo; }
            set { SetProperty(ref _basketShopperInfo, value); }
        }

        public ObservableCollection<BasketItemInfo> BasketItemInfo
        {
            get { return _basketItemInfo; }
            set { SetProperty(ref _basketItemInfo, value); }
        }


        public ListOrderDetailViewModel()
        {
            _basketShopperInfo = dbmanager.getBasketShopperInfo();
            _basketItemInfo = dbmanager.getBasketItemInfo(3);

        }

        public void UpdateBasketItemInfo(int selectedBasketId)
        {
            // Update BasketItemInfo based on the selected basket ID
            _basketItemInfo = dbmanager.getBasketItemInfo(selectedBasketId);
        }


    }
}
