using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace AsyncExamples
{
    public interface IAsyncExample
    {
        void RunExampleAsync();
        void SetOutputField(TextBlock control);
    }
}
