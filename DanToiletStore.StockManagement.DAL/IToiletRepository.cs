using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DanToiletStore.StockManagment.Model;

namespace DanToiletStore.StockManagement.DAL
{
    public interface IToiletRepository
    {
        Toilet GetAToilet();

        ObservableCollection<Toilet> GetToilets();

        Toilet GetToiletById(int id);

        void DeleteToilet(Toilet toilet);

        void UpdateToilet(Toilet toilet);

    }
}
