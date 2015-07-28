using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DanToiletStore.StockManagment.Model;

namespace DanToiletStore.StockManagement.DAL
{
    public class ToiletRepository : IToiletRepository
    {
        private static ObservableCollection<Toilet> Toilets;

        public ToiletRepository()
        {
            
        }

        public Toilet GetAToilet()
        {
            if (Toilets == null)
                LoadToilets();
           return Toilets.FirstOrDefault();
        }

        public ObservableCollection<Toilet> GetToilets()
        {
            if (Toilets == null)
                LoadToilets();
            return Toilets;
        }

        public Toilet GetToiletById(int id)
        {
            if (Toilets == null)
                LoadToilets();
            return Toilets.FirstOrDefault(c => c.ToiletId == id);
        }

        public void DeleteToilet(Toilet toilet)
        {
            Toilets.Remove(toilet);
        }

        public void UpdateToilet(Toilet toilet)
        {
            var toiletToUpdate = Toilets.FirstOrDefault(t => t.ToiletId == toilet.ToiletId);
            toiletToUpdate = toilet;
        }

        private void LoadToilets()
        {
            Toilets = new ObservableCollection<Toilet>()
            {
                new Toilet()
                {
                    ToiletId = 1,
                    ToiletName = "Thunderer",
                    Descripiton = "Deals with anything you can throw at it",
                    ImageId = 1,
                    AmountInStock = 5,
                    InStock = true,
                    FirstAddedToStockDate = new DateTime(2015, 7, 1),
                    Price = 80
                },
                new Toilet()
                {
                    ToiletId = 2,
                    ToiletName = "Shocker",
                    Descripiton = "Shock factor",
                    ImageId = 2,
                    AmountInStock = 0,
                    InStock = false,
                    FirstAddedToStockDate = new DateTime(2015, 6, 25),
                    Price = 100
                }
            };
        }
    }
}
