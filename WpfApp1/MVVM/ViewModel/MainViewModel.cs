using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using WpfApp1.Core;

namespace WpfApp1.MVVM.ViewModel
{
    internal class MainViewModel : ObervableObject
    {

        public RelayCommand HomeViewCommand{ get; set; }
        public RelayCommand SecondaryViewCommand { get; set; }

        public SecondViewModel SecondaryVM { get; set; }
        public HomeViewModel HomeVM { get; set; }

        private object _currentView;

        public object CurrentView {  
            get { return _currentView; } 
            set { _currentView = value;
                OnPropertyChanged();
            }
        }

        public MainViewModel() { 
            HomeVM = new HomeViewModel();
            SecondaryVM= new SecondViewModel();
            CurrentView = HomeVM;

            HomeViewCommand = new RelayCommand(o =>
            {
                CurrentView = HomeVM;
            });

            SecondaryViewCommand = new RelayCommand(o =>
            {
                CurrentView = SecondaryVM;
            });
        }


    }
}
