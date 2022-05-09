using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xamarin.Essentials;

[assembly: Xamarin.Forms.Dependency(typeof(AlgoritmForegraundPR.Droid.AndroidServiceHelper))]
namespace AlgoritmForegraundPR.Droid
{

    public class AndroidServiceHelper : IAndroidService
    {
        private static Context context = global::Android.App.Application.Context;
        void IAndroidService.StartService()
        {
            var intent = new Intent(context, typeof(DataSource));

            if (Android.OS.Build.VERSION.SdkInt >= Android.OS.BuildVersionCodes.O)
            {
                context.StartForegroundService(intent);
            }
            else
            {
                context.StartService(intent);
            }

          //  Accelerometer.Start(SensorSpeed.UI);

        }

        void IAndroidService.StopService()
        {
            var intent = new Intent(context, typeof(DataSource));
            context.StopService(intent);
        }
    }
}