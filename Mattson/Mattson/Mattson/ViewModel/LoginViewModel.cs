using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using Mattson.ViewModel;

namespace Mattson.ViewModel
{
    public class LoginViewModel
    {
        public Action DisplayInvalidLoginPrompt;
        public Action Loginsuccess;
        public event PropertyChangedEventHandler PropertyChanged = delegate { };
        private string username;

        public string Username
        {
            get { return username; }
            set
            {
                username = value;
                PropertyChanged(this, new PropertyChangedEventArgs("Username"));
            }
        }
        private string password;
        public string Password
        {
            get { return password; }
            set
            {
                password = value;
                PropertyChanged(this, new PropertyChangedEventArgs("Password"));
            }
        }
        public ICommand SubmitCommand { protected set; get; }
        public LoginViewModel()
        {
            SubmitCommand = new Command(OnSubmit);
        }
        public void OnSubmit()
        {
            if (username != "admin" || password != "conevo")
            {
                DisplayInvalidLoginPrompt();
            }
            else
            {
                Loginsuccess();
            }

        }
    }
}
