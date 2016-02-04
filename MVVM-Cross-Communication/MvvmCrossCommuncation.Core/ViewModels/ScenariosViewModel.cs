using GalaSoft.MvvmLight;
using MvvmCrossCommuncation.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvvmCrossCommuncation.Core.ViewModels
{
    public class ScenariosViewModel : ViewModelBase
    {
        #region Data Members

        private List<Scenario> _ScenarioCollection = new List<Scenario>();
        public List<Scenario> ScenarioCollection
        {
            get
            {
                return _ScenarioCollection;
            }
            set
            {
                _ScenarioCollection = value;
                RaisePropertyChanged(() => ScenarioCollection);
            }
        }

        #endregion

        #region Constructor

        public ScenariosViewModel() { }

        #endregion
    }
}
