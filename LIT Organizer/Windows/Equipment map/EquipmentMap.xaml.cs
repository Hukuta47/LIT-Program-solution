using LIT_Organizer.Windows.Equipment_map.Classes;
using LIT_Organizer.Windows.Equipment_map.Pages;
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
using System.Windows.Shapes;

namespace LIT_Organizer.Windows.Equipment_map
{
    /// <summary>
    /// Логика взаимодействия для EquipmentMap.xaml
    /// </summary>
    public partial class EquipmentMap : Window
    {
        public static FrameHelper frameHelper;
        public EquipmentMap()
        {
            InitializeComponent();
            frameHelper = new FrameHelper(mainFrame);
            mainFrame.Content = new ListDevicePage();
        }
    }
}
