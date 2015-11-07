using System;
using System.Diagnostics;
using System.Threading;
using System.Windows;
using System.Windows.Controls;

namespace AsyncExamples
{
    public class ThreadExample : IAsyncExample
    {
        private Thread thread;
        private TextBlock outputControl;

        #region Constructor

        public ThreadExample()
        {
            thread = new Thread(new ThreadStart(ResourceIntensiveTask));
        }

        #endregion

        #region Interface Methods

        public void RunExampleAsync()
        {
            Debug.WriteLine("Thread: RunExampleAsync() called");
            thread.Start();
            Debug.WriteLine("Thread: RunExampleAsync() finished");
        }

        public void SetOutputField(TextBlock control)
        {
            
            outputControl = control;
        }

        #endregion

        #region Logic

        private void WriteToOutput(string txt)
        {
            // Since we are on a different Thread then the UI, we must use a Dispatcher to communicate with it.
            // Without using a Dispatcher to the UI Thread, we would receive a cross-thread violation.
            outputControl.Dispatcher.BeginInvoke((Action)(() =>
            {
                outputControl.Text = txt;
            }));
        }

        public void ResourceIntensiveTask()
        {
            // Resource intensive task running
            for (int i = 0; i < 4; ++i)
            {
                WriteToOutput("Thread Progress: " + 25 * i);
                Thread.Sleep(1000);
            }

            WriteToOutput("Thread Finished");
        }

        #endregion
    }
}
