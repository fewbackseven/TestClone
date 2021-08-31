using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TestClone
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {

            //Image File_Image = new Image();
            //File_Image.Source = ImageSource.FromFile("book1.png");
            InitializeComponent();

            

        }

        private void OnCreateBtnClicked(object sender,EventArgs e)
        {
            DisplayAlert("Do you like it?", "Lets continue", "cancel");
        }
        
    }
}
