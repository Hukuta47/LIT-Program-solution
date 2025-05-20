using LIT_Organizer.Database;
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

namespace LIT_Organizer.Windows.Equipment_map.Pages
{
    /// <summary>
    /// Логика взаимодействия для ListDevicePage.xaml
    /// </summary>
    public partial class ListDevicePage : Page
    {
        public ListDevicePage()
        {
            InitializeComponent();

            DataGrid_ListCabinets.ItemsSource = App.dbEntites.CabinetDevicesEmployees.ToList();
        }

        private void CabinetButtonClick(object sender, RoutedEventArgs e)
        {
            string CabinetName = ((sender as Button).DataContext as CabinetDevicesEmployees).CabinetName;
            Cabinet cabinet = App.dbEntites.Cabinet.First(findCabinet => findCabinet.CabinetName == CabinetName);
            EquipmentMap.frameHelper.FrameEquipmentMap.Navigate(new EditingCabinetPage(cabinet));

        }
    }
}
