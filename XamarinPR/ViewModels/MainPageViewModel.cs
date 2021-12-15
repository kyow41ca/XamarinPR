using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Threading.Tasks;

namespace XamarinPR.ViewModels
{
    public class MainPageViewModel : BindableBase
    {
        private string _message;
        public string Message
        {
            get { return _message; }
            set { this.SetProperty(ref _message, value); }
        }

        public DelegateCommand UpdateMessageCommand { get; }

        public MainPageViewModel()
        {
            this.UpdateMessageCommand = new DelegateCommand(async () => await UpdateMessage());
        }

        private async Task UpdateMessage()
        {
            await Task.Run(() =>
            {
                this.Message = DateTime.Now.ToString();
            });
        }
    }
}
