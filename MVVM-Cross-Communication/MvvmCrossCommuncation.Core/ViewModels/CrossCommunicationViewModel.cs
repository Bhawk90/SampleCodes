using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvvmCrossCommuncation.Core.ViewModels
{
    public class CrossCommunicationViewModel : ViewModelBase
    {
        #region Data Members

        public string LastMessage
        {
            get
            {
                return new ViewModelLocator().MessengerScenarioViewModel.Messages.FirstOrDefault();
            }
        }

        #endregion

        #region Constructor

        public CrossCommunicationViewModel() { }

        #endregion
    }
}
