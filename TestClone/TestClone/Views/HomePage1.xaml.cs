using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using TestClone.ViewModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TestClone.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HomePage1 : ContentPage
    {
        public HomePage1()
        {
            InitializeComponent();
            BindingContext = new HomePage1ViewModel();
        }
    }
}