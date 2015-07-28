using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls.Primitives;
using DanToiletStore.StockManagement.UI.ViewModel;

namespace DanToiletStore.StockManagement.UI
{
    public class ViewModelLocator
    {
        private static ToiletOverviewViewModel toiletOverviewViewModel = new ToiletOverviewViewModel();
        private static ToiletDetailViewModel toiletDetailViewModel = new ToiletDetailViewModel();

        public static ToiletDetailViewModel ToiletDetailViewModel
        {
            get { return toiletDetailViewModel; }
        }

        public static ToiletOverviewViewModel ToiletOverviewViewModel
        {
            get { return toiletOverviewViewModel; }
        }
    }
}
