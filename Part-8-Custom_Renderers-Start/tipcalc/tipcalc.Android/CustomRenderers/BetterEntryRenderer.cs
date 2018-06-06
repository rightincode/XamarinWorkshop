using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
//using tipcalc.Droid.CustomRenderers;
//using tipcalcapp.CustomRenderers;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

//[assembly: ExportRenderer(typeof(BetterEntry), typeof(BetterEntryRenderer))]
namespace tipcalc.Droid.CustomRenderers
{
    //public class BetterEntryRenderer : EntryRenderer
    //{
    //    public BetterEntryRenderer(Context context) : base(context)
    //    {
    //    }

    //    protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
    //    {
    //        base.OnElementChanged(e);

    //        if (Control != null)
    //        {
    //            Control.SetBackgroundColor(global::Android.Graphics.Color.Transparent);
    //        }
    //    }

    //    protected override void OnElementPropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs args)
    //    {
    //        base.OnElementPropertyChanged(sender, args);
    //        try
    //        {
    //            if (args.PropertyName == "IsFocused")
    //            {
    //                if (Control.IsFocused)
    //                {
    //                    Control.SetBackgroundColor(Android.Graphics.Color.Wheat);
    //                }
    //                else
    //                {
    //                    Control.SetBackgroundColor(Android.Graphics.Color.Transparent);
    //                }
    //            }
    //        }
    //        catch (Exception ex)
    //        {
    //            Console.WriteLine("Cannot set property on attached control. Error: ", ex.Message);
    //        }
    //    }
    //}
}