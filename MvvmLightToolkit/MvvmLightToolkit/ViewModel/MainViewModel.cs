using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using MvvmLightToolkit.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvvmLightToolkit.ViewModel
{
    public class MainViewModel : ViewModelBase
    {
        public User User { get; set; }

        public MainViewModel()
        {
            User = new User() { Name = "Cortana" };
            ChangeNameCommand = new RelayCommand<string>(ChangeName, val => this.AllowChangeName == true);
        }

        #region Commands

        private bool _AllowChangeName = true;
        public bool AllowChangeName
        {
            get
            {
                return _AllowChangeName;
            }
            set
            {
                _AllowChangeName = value;
                RaisePropertyChanged(() => this.AllowChangeName);
                ChangeNameCommand.RaiseCanExecuteChanged();
            }
        }

        public RelayCommand<string> ChangeNameCommand { get; private set; }

        private async void ChangeName(string newName)
        {
            // Letiltjuk a névváltást - Ennek megváltoztatásával a gomb is letiltásra kerül
            AllowChangeName = false;

            // Várunk 1 másodpercet a név megváltoztatása előtt
            await Task.Delay(1000);

            // Megváltoztatjuk a nevet
            User.Name = newName;

            // Újra engedélyezzük a névváltást
            AllowChangeName = true;
        }

        #endregion

    }
}
