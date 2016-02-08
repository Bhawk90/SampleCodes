using MvvmCrossCommuncation.Core.Models;
using MvvmCrossCommuncation.Core.ViewModels;
using MvvmCrossCommuncation.Scenarios;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MvvmCrossCommuncation
{
    public partial class MainWindow : Window
    {
        #region Data Members

        private ScenariosViewModel ViewModel;

        #endregion

        #region Constructor

        public MainWindow()
        {
            InitializeComponent();
            this.ViewModel = this.DataContext as ScenariosViewModel;
            this.RegisterScenarios();
        }

        #endregion

        #region Logic

        private void RegisterScenarios()
        {
            this.ViewModel.ScenarioCollection = new List<Scenario>()
            {
                new Scenario() { Title = "Messenger Service Scenario", PageType = typeof(MessengerScenario) },
                new Scenario() { Title = "Cross Communication Scenario", PageType = typeof(CrossCommunicationScenario) },
            };
        }

        #endregion

        #region Event Handlers

        private void ScenariosCollection_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var scenario = ((sender as ListView).SelectedItem as Scenario);
            
            this.ScenarioFrame.Navigate(Activator.CreateInstance(scenario.PageType));
            this.ScenarioTitle.Text = scenario.Title;
        }

        #endregion
    }
}
