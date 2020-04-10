using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xamarin.Essentials;
using System.Diagnostics;

namespace ExampleHackApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page3 : ContentPage
    {
        public Page3()
        {
            InitializeComponent();
        }

        private async void ButtonClicked(object sender, EventArgs e) 
        {
            try
            {
                var location = await Geolocation.GetLastKnownLocationAsync();

                if (location == null)
                {
                    location = await Geolocation.GetLocationAsync(new GeolocationRequest
                    { 
                    DesiredAccuracy = GeolocationAccuracy.Medium,
                    Timeout = TimeSpan.FromSeconds(30)
                    
                    });
                }

                if (location == null)
                {
                    LabelLocation.Text = "No GPS";
                }

                else
                {
                    LabelLocation.Text = $"{location.Latitude}, {location.Longitude}";
                }
            }

            catch (Exception ex) 
            {

                Debug.WriteLine($"Wrong lmaooo");
            }
        }
    }
}