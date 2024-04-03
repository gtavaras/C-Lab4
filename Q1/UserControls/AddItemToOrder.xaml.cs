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
using Microsoft.EntityFrameworkCore.Migrations.Operations;
using OMSLibrary.Models;
using Q1.ViewModels;

namespace Q1.UserControls
{
    /// <summary>
    /// Interaction logic for AddItemToOrder.xaml
    /// </summary>
    public partial class AddItemToOrder : UserControl
    {
        public AddItemToOrder()
        {
            InitializeComponent();
            DataContext = new AddItemToOrderViewModel();
        }

        private void ClearButton_Clicked(object sender, RoutedEventArgs e)
        {
            txtBoxQty.Clear();
            ProductComboBox.SelectedItem = null;
            BasketComboBox.SelectedItem = null;
        }

        private void SaveButton_Clicked(object sender, RoutedEventArgs e)
        {
            /*ComboBox? comboBox1 = sender as ComboBox;
            BasketShopperInfo? selectedBasketId = comboBox1.SelectedItem as BasketShopperInfo;
            */
            /*if (selectedBasketId != null)
            {
                int basketID = selectedBasketId.BasketId;
            }
            

            ComboBox? comboBox2 = sender as ComboBox;
            ProductInfo? selectedProductInfo = comboBox2.SelectedItem as ProductInfo;
            if (selectedProductInfo != null)
            {
                int productID = selectedProductInfo.IdProduct;
            }
            
            int quantity = Convert.ToInt32(txtBoxQty.Text);*/
          
           
        }
    }
}
