using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.RightsManagement;
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
    public class ToiletDetailViewModel: INotifyPropertyChanged
    {
        private ToiletDataService _toiletDataService;

        public event PropertyChangedEventHandler PropertyChanged;

        public void RaisePropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }

        }

        public ICommand SaveCommand { get; set; }
        public ICommand DeleteCommand { get; set; }

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

        public ToiletDetailViewModel()
        {
            _toiletDataService = new ToiletDataService();

            SaveCommand = new CustomCommand(SaveToilet, CanSaveToilet);
            DeleteCommand = new CustomCommand(DeleteToilet, CanDeleteToilet);

            Messenger.Default.Register<Toilet>(this, OnToiletReceived);
        }

        private void OnToiletReceived(Toilet toilet)
        {
            _selectedToilet = toilet;
        }

        private void SaveToilet(object obj)
        {
            _toiletDataService.UpdateToilet(_selectedToilet);
            Messenger.Default.Send<UpdateListMessage>(new UpdateListMessage());
        }

        private bool CanSaveToilet(object obj)
        {
            return true;
        }

        private void DeleteToilet(object obj)
        {
            _toiletDataService.DeleteToilet(_selectedToilet);
            Messenger.Default.Send<UpdateListMessage>(new UpdateListMessage());
        }

        private bool CanDeleteToilet(object obj)
        {
            return true;
        }



    }
}
