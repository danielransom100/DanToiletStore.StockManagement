using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using DanToiletStore.StockManagement.UI.Service;
using DanToiletStore.StockManagment.Model;
using DanToiletStore.StockManagment.Model.Annotations;

namespace DanToiletStore.StockManagement.UI.ViewModel
{
    public class ToiletOverviewViewModel: INotifyPropertyChanged

    {
        public event PropertyChangedEventHandler PropertyChanged;
        private ToiletDataService _toiletDataService;

        public void RaisePropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }

        }

        private ObservableCollection<Toilet> _toilets;
        public ObservableCollection<Toilet> Toilets
        {
            get { return _toilets; }
            set
            {
                _toilets = value;
                RaisePropertyChanged("Toilets");
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

        public ToiletOverviewViewModel()
        {
            _toiletDataService = new ToiletDataService();
            LoadData();
        }

        private void LoadData()
        {
             Toilets = _toiletDataService.GetAllToilets();
        }
    }
}
