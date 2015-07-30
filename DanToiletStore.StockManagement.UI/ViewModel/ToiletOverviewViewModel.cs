using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using DanToiletStore.StockManagement.UI.Messages;
using DanToiletStore.StockManagement.UI.Service;
using DanToiletStore.StockManagement.UI.Utility;
using DanToiletStore.StockManagment.Model;
using DanToiletStore.StockManagment.Model.Annotations;

namespace DanToiletStore.StockManagement.UI.ViewModel
{
    public class ToiletOverviewViewModel: INotifyPropertyChanged

    {
        public event PropertyChangedEventHandler PropertyChanged;
        private ToiletDataService _toiletDataService;
        private DialogService _dialogService;

        public ICommand EditCommand { get; set; }

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
            _dialogService = new DialogService();
            LoadData();
            LoadCommand();

            Messenger.Default.Register<UpdateListMessage>(this, OnUpdateListMessageReceived);
        }

        private void OnUpdateListMessageReceived(UpdateListMessage obj)
        {
            LoadData();
        }

        private void LoadCommand()
        {
            EditCommand = new CustomCommand(EditToilet, CanEditToilet);
        }

        private void EditToilet(object obj)
        {
            _dialogService.InitShowDialog();
            Messenger.Default.Send<Toilet>(_selectedToilet);
            _dialogService.ShowDialog();
        }

        private bool CanEditToilet(object obj)
        {
            return _selectedToilet != null;
        }

        private void LoadData()
        {
             Toilets = _toiletDataService.GetAllToilets();
             _dialogService.CloseDialog();
        }
    }
}
