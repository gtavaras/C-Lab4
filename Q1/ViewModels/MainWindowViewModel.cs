using Q1.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Q1.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        private ViewModelBase _CurrentViewModel;

        readonly ListOrderDetailViewModel _orderDetailViewModel = new ListOrderDetailViewModel();
        readonly AddItemToOrderViewModel _addItemViewModel = new AddItemToOrderViewModel();


        public ViewModelBase CurrentViewModel
        {
            get { return _CurrentViewModel; }
            set
            {
                SetProperty(ref _CurrentViewModel, value);
            }
        }

        public DelegateCommand View1Command { get; set; }
        public DelegateCommand View2Command { get; set; }

        public DelegateCommand ExitCommand { get; set; }

        public MainWindowViewModel()
        {
            View1Command = new DelegateCommand(ShowOrderDetail);
            View2Command = new DelegateCommand(AddItem);
            ExitCommand = new DelegateCommand(ExitApp);
            CurrentViewModel = _orderDetailViewModel;
        }


        private void ShowOrderDetail()
        {
            CurrentViewModel = _orderDetailViewModel;
        }


        private void AddItem()
        {
            CurrentViewModel = _addItemViewModel;
        }

        private void ExitApp()
        {
            Application.Current.Shutdown();
        }
    }
}
