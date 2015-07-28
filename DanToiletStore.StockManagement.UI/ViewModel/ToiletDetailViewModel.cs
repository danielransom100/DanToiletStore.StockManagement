using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using DanToiletStore.StockManagment.Model;
using DanToiletStore.StockManagment.Model.Annotations;

namespace DanToiletStore.StockManagement.UI.ViewModel
{
    public class ToiletDetailViewModel: INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public void RaisePropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }

        }
        private Toilet _selectedToilet;
        public Toilet SelectedToilet
        {
            get { return _selectedToilet; }
            set
            {
                _selectedToilet = value;
                RaisePropertyChanged("SelectedToilet");
            }
        }
    }
}
