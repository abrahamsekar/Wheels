using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Mattson
{
    public partial class App : Application
    {
        public static Task Navigation { get; internal set; }

        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new Mattson.UI.Views.LoginPage()) { BarBackgroundColor = Color.FromHex("#1EADFA"), BarTextColor = Color.White };

        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
