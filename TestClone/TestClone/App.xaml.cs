using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using TestClone.Views;
using TestClone.ViewModel;
using System.Collections.Generic;

namespace TestClone
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            List<string> KhataBook=  new List<string>();
            HomeViewModel hs = new HomeViewModel();
            KhataBook = hs.Khatabook;
            
            /*
            if (KhataBook==null||KhataBook.Count==0)
                MainPage = new MainPage();
            else
            */
                MainPage = new MainPage1();
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
