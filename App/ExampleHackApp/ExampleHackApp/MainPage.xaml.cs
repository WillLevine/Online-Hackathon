using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;


namespace ExampleHackApp
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        
        void GiveHelp_Handle_Clicked(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new Page1());
        }

        void GetHelp_Handle_Clicked(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new Page2());
        }

        void MyMessages_Handle_Clicked(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new Page3());
        }

        void MyCard_Handle_Clicked(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new Page4());
        }

    }
}
