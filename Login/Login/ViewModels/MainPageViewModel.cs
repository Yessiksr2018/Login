using Login.Helpers;
using Login.Views;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace Login.ViewModels
{
    public class MainPageViewModel : ViewModelBase
    {
        public INavigation Navigation { get; set; }
        public ICommand LogoutCommand { get; set; }
        private string _message;

        public string Message
        {
            get { return _message; }
            set { SetProperty(ref _message, value); }
        }

        public MainPageViewModel()
        {
            LogoutCommand = new Command(Logout);
            Message = "Welcome to Main Page!";
        }

        private async void Logout()
        {
            Settings.IsLoggedIn = false;
            await Navigation.PushAsync(new LoginPage());
        }
    }
}
