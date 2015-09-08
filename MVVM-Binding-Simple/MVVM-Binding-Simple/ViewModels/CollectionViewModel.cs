using MVVM_Binding_Simple.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVM_Binding_Simple.ViewModels
{
    public class CollectionViewModel
    {
        public List<User> Users { get; set; }
        //public ObservableCollection<User> Users { get; set; }

        public CollectionViewModel()
        {
            Users = new List<User>();
            //Users = new ObservableCollection<User>();

            Users.Add(new User() { Name = "Administrator" });
            Users.Add(new User() { Name = "root" });
            Users.Add(new User() { Name = "Blackhawk" });
            Users.Add(new User() { Name = "User001" });
            Users.Add(new User() { Name = "Cortana" });
        }
    }
}
