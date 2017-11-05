using Android.App;
using Android.Gms.Maps;
using Android.Gms.Maps.Model;
using Android.Widget;
using Android.OS;

namespace App2
{
    [Activity(Label = "App2", MainLauncher = true, Icon = "@mipmap/icon")]
    public class MainActivity : Activity, IOnMapReadyCallback
    {
        private GoogleMap nMap;


        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);
            setUpMap();
        }

        private void setUpMap()
        {
            if (nMap == null)
            {
                FragmentManager.FindFragmentById<MapFragment>(Resource.Id.map).GetMapAsync(this);
            }
        }

        public void OnMapReady(GoogleMap googleMap)
        {
            nMap = googleMap;
            LatLng latlng = new LatLng(-12.463440, 130.845642);

            MarkerOptions options = new MarkerOptions()
                .SetPosition(latlng)
                .SetTitle("Darwin")
                .Draggable(true);

            nMap.AddMarker(options);
        }
    }
}

