using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using TestClone.ViewModel;

namespace TestClone.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MorePage : ContentPage
    {
        public MorePage()
        {
            InitializeComponent();
            BindingContext = new MenuListModel();
            
        }
        
        
        async void OnSettingsTapped(object sender, EventArgs e)
        {
             await MyScroll.ScrollToAsync(_Settings1, ScrollToPosition.End, true);
            //var Chekc = ((ListView)sender).SelectedItem as string;
            //if(Chekc=="Office1")
            //await Navigation.PushAsync(new MainPage());                                        
        }

        async void OnHelpSupportTapped(object sender,EventArgs e)
        {
            await MyScroll.ScrollToAsync(_Settings2, ScrollToPosition.End, true);
        }

        async void OnAboutTapped(object sender, EventArgs  e)
        {
            await MyScroll.ScrollToAsync(_Settings3, ScrollToPosition.End, true);
        }


    }
}