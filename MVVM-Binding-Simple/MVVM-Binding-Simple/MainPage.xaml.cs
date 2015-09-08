using MVVM_Binding_Simple.ViewModels;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Core;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

namespace MVVM_Binding_Simple
{
    public sealed partial class MainPage : Page
    {
        // A ViewModel, ahol tárolni fogjuk azokat az adattagokat, melyre az adatkötést elvégezzük
        MainViewModel ViewModel = new MainViewModel();

        public MainPage()
        {
            this.InitializeComponent();

            // Erre azért van szükség, hogy az adatkötéseket feldolgozó egység tudja, hol keresse az adattagokat
            this.DataContext = ViewModel;
        }

        private void btnChangeName_Click(object sender, RoutedEventArgs e)
        {
            ViewModel.ChangeName(txtNewName.Text);
        }

        private void btnShowUsers_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(CollectionView));
            
        }
    }
}
