using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace GradientNavigationHeader
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new GradientNavigationHeader.Controls.NavigationPageGradientHeader(new MainPage())
            {
                LeftColor = Color.FromHex("#36ED81"),
                RightColor = Color.FromHex("#109F8D")
            };


            //MainPage = new NavigationPage(new MainPage());
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
