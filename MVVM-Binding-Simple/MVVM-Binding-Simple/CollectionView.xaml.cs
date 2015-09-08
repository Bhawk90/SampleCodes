using MVVM_Binding_Simple.ViewModels;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

namespace MVVM_Binding_Simple
{
    public sealed partial class CollectionView : Page
    {
        CollectionViewModel ViewModel = new CollectionViewModel();

        public CollectionView()
        {
            this.InitializeComponent();
            this.DataContext = ViewModel;
        }

        private void btnAddNewUser_Click(object sender, RoutedEventArgs e)
        {
            ViewModel.Users.Add(new Models.User() { Name = txtUserName.Text });
            txtUserName.Text = String.Empty;
        }
    }
}
