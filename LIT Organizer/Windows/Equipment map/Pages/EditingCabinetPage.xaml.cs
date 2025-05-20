using LIT_Organizer.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;


namespace LIT_Organizer.Windows.Equipment_map.Pages
{
    public partial class EditingCabinetPage : Page
    {
        Cabinet SelectedCabinet;
        public EditingCabinetPage(Cabinet SelectedCabinet)
        {
            this.SelectedCabinet = SelectedCabinet;
            InitializeComponent();
        }
    }
}
