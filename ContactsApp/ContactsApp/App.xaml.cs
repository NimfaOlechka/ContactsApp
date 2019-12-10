using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using ContactsApp.Views;

namespace ContactsApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage( new ContactsListViewPage());
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
