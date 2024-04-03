using OMSLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Q1.ViewModels;

namespace Q1.UserControls
{
    /// <summary>
    /// Interaction logic for ListOrderDetail.xaml
    /// </summary>
    public partial class ListOrderDetail : UserControl
    {
        
        public ListOrderDetail()
        {
            InitializeComponent();
            DataContext = new ListOrderDetailViewModel();
        }

        private void BasketComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ComboBox? comboBox = sender as ComboBox;
            BasketShopperInfo? selectedBasketId = comboBox.SelectedItem as BasketShopperInfo;
            //DataContext.UpdateBasketItemInfo(selectedBasketId.BasketId);
        }
    }
}
