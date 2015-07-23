using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DanToiletStore.StockManagment.Model;
using DanToiletStore.StockManagement.DAL;

namespace DanToiletStore.StockManagement.UI.Service
{
    public class ToiletDataService
    {
        static IToiletRepository _repository = new ToiletRepository();

        public ToiletDataService(){}

        public Toilet GetToiletDetail(int toiletId)
        {
            return _repository.GetToiletById(toiletId);
        }

        public static List<Toilet> GetAllToilets()
        {
            return _repository.GetToilets();
        }

        public void UpdateToilet(Toilet toilet)
        {
            _repository.UpdateToilet(toilet);
        }

        public void DeleteToilet(Toilet toilet)
        {
            _repository.DeleteToilet(toilet);
        }
    }
}
