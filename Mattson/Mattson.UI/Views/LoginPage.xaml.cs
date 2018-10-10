using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mattson.ViewModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Mattson.UI.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {

            public LoginPage()
            {

           
                var login = new LoginViewModel();
                this.BindingContext = login;
                login.DisplayInvalidLoginPrompt += () => DisplayAlert("Error", "Invalid Login, try again", "OK");
              //  login.Loginsuccess += () => Navigation.PushAsync(new CaselistPage());
                InitializeComponent();

                //Username.Completed += (object sender, EventArgs e) =>
                //{
                //    Password.Focus();
                //};

                //Password.Completed += (object sender, EventArgs e) =>
                //{
                //    login.SubmitCommand.Execute(null);
                //};

            }

        }
    }

   