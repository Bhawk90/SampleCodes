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

        public CrossCommunicationViewModel CrossCommunicationViewModel { get { return CurrentServiceLocator.GetInstance<CrossCommunicationViewModel>(); } }
        public ScenariosViewModel ScenariosViewModel { get { return CurrentServiceLocator.GetInstance<ScenariosViewModel>(); } }
        public MessengerScenarioViewModel MessengerScenarioViewModel { get { return CurrentServiceLocator.GetInstance<MessengerScenarioViewModel>(); } }

        #endregion

        #region Private Members

        private SimpleIoc CurrentServiceLocator { get { return ServiceLocator.Current as SimpleIoc; } }

        #endregion
    }
}
