using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace AsyncExamples
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        #region Constructor

        public MainWindow()
        {
            InitializeComponent();
        }

        #endregion

        #region Event Handlers

        private void btnBackgroundWorker_Click(object sender, RoutedEventArgs e)
        {
            RunAsyncExample(new BackgroundWorkerExample());
        }

        private void btnThread_Click(object sender, RoutedEventArgs e)
        {
            RunAsyncExample(new ThreadExample());
        }

        private void btnAsync_Click(object sender, RoutedEventArgs e)
        {
            RunAsyncExample(new AsyncExample());
        }

        #endregion

        #region Logic

        public void RunAsyncExample(IAsyncExample example)
        {
            example.SetOutputField(txtOutput);
            example.RunExampleAsync();
        }

        #endregion
    }
}
