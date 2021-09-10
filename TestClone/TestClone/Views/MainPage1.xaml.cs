using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using TestClone.Helpers;
using TestClone.Views;

namespace TestClone.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage1 : Shell
    {
        public MainPage1()
        {
            InitializeComponent();
        }
    }
}