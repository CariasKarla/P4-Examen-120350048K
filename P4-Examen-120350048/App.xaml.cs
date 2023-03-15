using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace P4_Examen_120350048
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new Views.PageLocalizacion());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
