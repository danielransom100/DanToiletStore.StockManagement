using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DanToiletStore.StockManagment.Model;

namespace DanToiletStore.StockManagement.DAL
{
    public interface IToiletRepository
    {
        Toilet GetAToilet();

        List<Toilet> GetToilets();

        Toilet GetToiletById(int id);

        void DeleteToilet(Toilet toilet);

        void UpdateToilet(Toilet toilet);

    }
}
