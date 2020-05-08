using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp1.Base;

namespace WpfApp1.ViewModels
{
    class MainViewModel : BaseVM
    {
        public RelayCommand<object> UpdateViewCommand { get; set; }

        private BaseVM _selectedViewModel ;

        public BaseVM SelectedViewModel
        {
            get { return _selectedViewModel; }
            set
            {
                //_selectedViewModel = value;
                //OnPropertyChanged(nameof(SelectedViewModel));
                SetProperty(ref _selectedViewModel, value);
            }
        }

        public MainViewModel()
        {
            UpdateViewCommand = new RelayCommand<object>(UpdateView, CanUpdateView);
            _selectedViewModel = new StartMenuViewModel();
        }

        public void UpdateView(object param)
        {

            if (param.ToString() == "StartMenu")
            {
                SelectedViewModel = new StartMenuViewModel();
            }
            else if (param.ToString() == "Application")
            {
                
                SelectedViewModel = new ApplicationViewModel();
            }
        }

        public bool CanUpdateView(object param)
        {
            return true;
        }
    }
}
