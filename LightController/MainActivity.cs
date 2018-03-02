using Android.App;
using Android.Widget;
using Android.OS;

namespace LightController
{
    [Activity(Label = "LightController", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        private Button btnLight;
        private bool lightOn = false;
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView (Resource.Layout.Main);
            btnLight = FindViewById<Button>(Resource.Id.btnLight);
            btnLight.Click += delegate {
                if (!lightOn) {
                    btnLight.Text = "On";
                    lightOn = true;
                }
                else{
                    btnLight.Text = "Off";
                    lightOn = false;
                }
                
            };
        }
    }
}

