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

namespace modulzaro
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ShipmentFormViewModel _vm;
        public MainWindow()
        {
            InitializeComponent();
            _vm = new ShipmentFormViewModel();
            DataContext = _vm;
        }

    /*    private void ShipmentClick(object sender, RoutedEventArgs e)
        {
            ShipmentFormViewModel vm = new ShipmentFormViewModel(new Shipment()) { IsNew = true };
       ShipmentFormViewModel shipmentForm = new ShipmentFormView { DataContext = vm };
            shipmentForm.ShowDialog();
            var shipmentList = _vm.shipmentList;
            if (shipmentForm.DialogResult == true)
            {
                shipmentList.Add(vm.Shipment);
                vm.Save();
            }
        }

        private void PickShipClick(object sender, MouseButtonEventArgs e)
        {

            {
                if (_vm.SelectShip == null)
                    return;
                var errorMessage = _vm.SelectedShip();
                if (errorMessage != null)
                    MessageBox.Show(errorMessage);
            } */


        }
    }
}