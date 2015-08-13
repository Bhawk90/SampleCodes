using MVVM_Binding_Simple.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVM_Binding_Simple.ViewModels
{
    public class MainViewModel
    {
        public User User { get; set; }

        public MainViewModel()
        {
            User = new User() { Name = "Cortana" };
        }

        public void ChangeName(string newName)
        {
            User.Name = newName;
        }
    }
}
