using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using DanToiletStore.StockManagement.UI.View;

namespace DanToiletStore.StockManagement.UI.Service
{
    public class DialogService
    {
        Window _toiletDetailView = null;

        public void InitShowDialog()
        {
            _toiletDetailView = new ToiletDetailView();
        }
        
        public void ShowDialog()
        {
            _toiletDetailView.ShowDialog();
        }

        public void CloseDialog()
        {
            if (_toiletDetailView != null)
                _toiletDetailView.Close();
        }


    }
}
