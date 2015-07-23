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
using DanToiletStore.StockManagement.UI.Service;
using DanToiletStore.StockManagment.Model;

namespace DanToiletStore.StockManagement.UI.View
{
    /// <summary>
    /// Interaction logic for ToiletOverviewView.xaml
    /// </summary>
    public partial class ToiletOverviewView : Window
    {
        private Toilet toilet;
        private List<Toilet> toilets;

        public ToiletOverviewView()
        {
            InitializeComponent();

            LoadData();
        }

        private void LoadData()
        {
            var toiletDetailView = new ToiletDetailView();
            toilets = ToiletDataService.GetAllToilets();
            ToiletListView.ItemsSource = toilets;

        }

        private void ToiletListView_OnSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
