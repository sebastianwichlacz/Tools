using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tools.Core;

namespace Tools.ViewModel
{
    public class MainViewModel : ObservableObject
    {
        public ToolsViewModel Tool { get; set; }

        private object _currentView;

        public object CurrentView
        {
            get { return _currentView; }
            set
            {
                _currentView = value;
                OnPropertyChanged();
            }
        }
        //test
        public MainViewModel()
        {
            Tool = new ToolsViewModel();
        }
    }
}
