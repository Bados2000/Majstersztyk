using System;

using Android.App;
using Android.Widget;
using Android.OS;
using Android.Support.Wearable.Activity;

namespace AplikacjaNaZegarek
{

    [Activity(Label = "@string/app_name", MainLauncher = true)]
    public class MainActivity : WearableActivity
    {
        TextView textView;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.s2;

            textView = FindViewById<TextView>(Resource.Id.text);
            SetAmbientEnabled();
        }
        async void GoToS2(object sender, EventArgs args)
        {
            await.Navigation
    }

        static void Main(string[] args)
        {
            // Get current DateTime. It can be any DateTime object in your code.  
            DateTime aDate = DateTime.Now;

            // Format Datetime in different formats and display them  
           
            Console.WriteLine(aDate.ToString("dddd, dd MMMM yyyy HH:mm:ss"));
            Console.ReadKey();
        }

    }
}
