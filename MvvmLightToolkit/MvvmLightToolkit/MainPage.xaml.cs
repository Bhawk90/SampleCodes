using MvvmLightToolkit.ViewModel;
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

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace MvvmLightToolkit
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
    }
}
