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
using DanToiletStore.StockManagment.Model;

namespace DanToiletStore.StockManagement.UI.View
{
    /// <summary>
    /// Interaction logic for ToiletDetailView.xaml
    /// </summary>
    public partial class ToiletDetailView : Window
    {
        public Toilet SelectedToilet { get; set; }

        public ToiletDetailView()
        {
            InitializeComponent();
            this.Loaded += ToiletDetailView_Loaded;
        }

        private void ToiletDetailView_Loaded(object sender, RoutedEventArgs e)
        {
            this.DataContext = SelectedToilet;
        }

        private void SaveToiletButton_OnClick(object sender, RoutedEventArgs e)
        {
            

        }
    }
}
