using System.ComponentModel;
using System.Diagnostics;
using System.Threading;
using System.Windows.Controls;

namespace AsyncExamples
{
    public class BackgroundWorkerExample : IAsyncExample
    {
        private BackgroundWorker bgWorker;
        private TextBlock outputControl;

        #region Constructor

        public BackgroundWorkerExample()
        {
            bgWorker = new BackgroundWorker();
            bgWorker.WorkerReportsProgress = true;
            bgWorker.DoWork += BgWorker_DoWork;
            bgWorker.ProgressChanged += BgWorker_ProgressChanged;
            bgWorker.RunWorkerCompleted += BgWorker_RunWorkerCompleted;
        }

        #endregion

        #region Interface methods

        public void RunExampleAsync()
        {
            Debug.WriteLine("BackgroundWorker: RunExampleAsync() called");
            bgWorker.RunWorkerAsync();
            Debug.WriteLine("BackgroundWorker: RunExampleAsync() finished");
        }

        public void SetOutputField(TextBlock control)
        {
            outputControl = control;
        }

        #endregion

        #region Event Handlers

        private void BgWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            // Resource intensive task running
            for (int i = 0; i < 4; ++i)
            {
                bgWorker.ReportProgress(i * 25);
                Thread.Sleep(1000);
            }
        }

        private void BgWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            outputControl.Text = "BackgroundWorker Progress: " + e.ProgressPercentage;
        }

        private void BgWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            outputControl.Text = "BackgroundWorker Finished";
        }

        #endregion
    }
}
