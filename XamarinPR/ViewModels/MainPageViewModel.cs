using Prism.Commands;
using Prism.Mvvm;

using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xamarin.Forms;
using XamarinPR.Consts;

namespace XamarinPR.ViewModels
{
    public class MainPageViewModel : BindableBase
    {
        private List<CustomControl.Param> _uiList;
        public List<CustomControl.Param> UIList
        {
            get { return _uiList; }
            set { this.SetProperty(ref _uiList, value); }
        }

        public Command<CustomControl.Param> ListItemSelectedCommand { get; }

        public MainPageViewModel()
        {
            _uiList = new List<CustomControl.Param>()
            {
                CustomControl.Param.Checkbox,
                CustomControl.Param.LineChart,
            };

            ListItemSelectedCommand = new Command<CustomControl.Param>(async item => await OnTapped(item));
        }

        private async Task OnTapped(CustomControl.Param item)
        {
            await Task.Run(() =>
            {
                System.Diagnostics.Debug.WriteLine(item);
                switch (item)
                {
                    case CustomControl.Param.Checkbox:
                        break;

                    case CustomControl.Param.LineChart:
                        break;
                }
            });
        }
    }
}
