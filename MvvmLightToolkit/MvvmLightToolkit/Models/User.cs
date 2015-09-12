using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvvmLightToolkit.Models
{
    public class User : ObservableObject
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
                // RaisePropertyChanged("Name"); // A változó nevét átadva jelzi a felületnek a változást
                RaisePropertyChanged(() => this.Name); // Ugyanaz, csak egy Lambda kifejezéssel megadva
            }
        }
    }
}
