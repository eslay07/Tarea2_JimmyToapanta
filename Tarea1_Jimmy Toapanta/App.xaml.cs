using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Tarea1_Jimmy_Toapanta
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new Login());//habilitar la nacegacion entre ventanas 
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
