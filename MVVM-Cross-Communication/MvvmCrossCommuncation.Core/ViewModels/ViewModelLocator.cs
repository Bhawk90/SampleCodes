using GalaSoft.MvvmLight.Ioc;
using Microsoft.Practices.ServiceLocation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvvmCrossCommuncation.Core.ViewModels
{
    public class ViewModelLocator
    {
        #region Constructor

        static ViewModelLocator()
        {
            ServiceLocator.SetLocatorProvider(() => SimpleIoc.Default);
            
            SimpleIoc.Default.Register<CrossCommunicationViewModel>();
            SimpleIoc.Default.Register<ScenariosViewModel>();
            SimpleIoc.Default.Register<MessengerScenarioViewModel>();
        }

        #endregion

        #region Public Members

        public CrossCommunicationViewModel CrossCommunicationViewModel { get { return SimpleIoc.Default.GetInstance<CrossCommunicationViewModel>(); } }
        public ScenariosViewModel ScenariosViewModel { get { return SimpleIoc.Default.GetInstance<ScenariosViewModel>(); } }
        public MessengerScenarioViewModel MessengerScenarioViewModel { get { return SimpleIoc.Default.GetInstance<MessengerScenarioViewModel>(); } }

        #endregion
    }
}
