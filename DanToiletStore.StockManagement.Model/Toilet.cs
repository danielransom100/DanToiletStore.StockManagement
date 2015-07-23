using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using DanToiletStore.StockManagment.Model.Annotations;

namespace DanToiletStore.StockManagment.Model
{
   public class Toilet: INotifyPropertyChanged
    {

        public int ToiletId { get; set; }
        public string ToiletName { get; set; }
        public int Price { get; set; }
        public string Descripiton { get; set; }
        //  public TYPE Country { get; set; }
        public bool InStock { get; set; }
        public int AmountInStock { get; set; }
        public DateTime FirstAddedToStockDate { get; set; }
        public int ImageId { get; set; }
       public event PropertyChangedEventHandler PropertyChanged;

       [NotifyPropertyChangedInvocator]
       protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
       {
           var handler = PropertyChanged;
           if (handler != null) handler(this, new PropertyChangedEventArgs(propertyName));
       }
    }
}


