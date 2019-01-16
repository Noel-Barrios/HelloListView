using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace HelloListView
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();


            ListViewIs.ItemsSource = new List<string>
            {
                "Hello", "World", "ListViewDemonstration"
            };
        }


    }
}
