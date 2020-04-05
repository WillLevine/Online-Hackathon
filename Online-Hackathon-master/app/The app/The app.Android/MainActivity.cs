using System;

using Android.App;
using Android.Content.PM;
using Android.Runtime;
using Android.OS;
using Android.Gms.Maps;
using Android.Gms.Maps.Model;

namespace The_app.Droid
{
    [Activity(Label = "The_app", Icon = "@mipmap/icon", Theme = "@style/MainTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity, IOnMapReadyCallback
    {



        protected override void OnCreate(Bundle savedInstanceState)
        {
            TabLayoutResource = Resource.Layout.Tabbar;
            ToolbarResource = Resource.Layout.Toolbar;

            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.Map);

            var mapFragment = (SupportMapFragment)SupportFragmentManager.FindFragmentById(Resource.Id.map);
            mapFragment.GetMapAsync(this);


            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            global::Xamarin.Forms.Forms.Init(this, savedInstanceState);
            LoadApplication(new App());
        }

        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            
        }


        public void OnMapReady(GoogleMap map)
        {
            map.MapType = GoogleMap.MapTypeNormal;
            MarkerOptions markerOptions = new MarkerOptions();
            markerOptions.SetPosition(new LatLng(16.03, 108));
            map.AddMarker(markerOptions);

            map.UiSettings.ZoomControlsEnabled = true;
            map.UiSettings.CompassEnabled = true;




        }


    }
}