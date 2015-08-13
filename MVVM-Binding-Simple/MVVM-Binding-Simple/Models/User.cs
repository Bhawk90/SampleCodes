using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVM_Binding_Simple.Models
{
    public class User : INotifyPropertyChanged
    {
        private string _Name;
        public string Name
        {
            get
            {
                return _Name;
            }
            set
            {
                _Name = value;
                OnPropertyChanged("Name");
            }
        }

        /*
            Az INotifyPropertyChanged interface implementálásával oldjuk meg, hogy az adatkötésekben megadott adattagok változtatását
            a felület is átvegye.

            Próbáld ki: kommenteld ki az OnPropertyChanged("Name"); sort, és egy új név megadása után nyomd meg a felületen a gombot. Majd tedd vissza és tedd meg ugyanezt!
        */
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null) handler(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
