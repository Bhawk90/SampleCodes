using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace AsyncExamples
{
    public class AsyncExample : IAsyncExample
    {
        private TextBlock outputControl;

        #region Constructor

        public AsyncExample()
        {
            
        }

        #endregion

        #region Interface Methods

        public async void RunExampleAsync()
        {
            Debug.WriteLine("Async/await: RunExampleAsync() called");
            await ResourceIntensiveTask();
            Debug.WriteLine("Async/await: RunExampleAsync() finished");
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

        public async Task ResourceIntensiveTask()
        {
            // Resource intensive task running
            for (int i = 0; i < 4; ++i)
            {
                WriteToOutput("Async/await Progress: " + 25 * i);
                await Task.Delay(1000);
            }

            WriteToOutput("Async/await Finished");
        }

        #endregion
    }
}
