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
       private int _toiletId;
       private string _toieltName;
       private int _price;

       public int ToiletId
       {
           get { return _toiletId; }
           set
           {
               _toiletId = value;
               RaisePropertyChanged("ToiletID");
           }
       }

       public string ToiletName
       {
           get { return _toieltName; }
           set
           {
               _toieltName = value;
               RaisePropertyChanged("ToiletName");
           }
       }

       public int Price
       {
           get { return _price; }
           set
           {
               _price = value;
               RaisePropertyChanged("Price");
           }
       }

        public string Descripiton { get; set; }
        //  public TYPE Country { get; set; }
        public bool InStock { get; set; }
        public int AmountInStock { get; set; }
        public DateTime FirstAddedToStockDate { get; set; }
        public int ImageId { get; set; }
        public event PropertyChangedEventHandler PropertyChanged;

       public void RaisePropertyChanged(string propertyName)
       {
           if (PropertyChanged != null)
           {
               PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
           }
               
       }
    }
}


