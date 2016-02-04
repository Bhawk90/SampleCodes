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
            
            SimpleIoc.Default.Register<CollectionViewModel>();
            SimpleIoc.Default.Register<ScenariosViewModel>();
        }

        #endregion

        #region Public Members

        public CollectionViewModel CollectionViewModel { get { return SimpleIoc.Default.GetInstance<CollectionViewModel>(); } }
        public ScenariosViewModel ScenariosViewModel { get { return SimpleIoc.Default.GetInstance<ScenariosViewModel>(); } }

        #endregion
    }
}
