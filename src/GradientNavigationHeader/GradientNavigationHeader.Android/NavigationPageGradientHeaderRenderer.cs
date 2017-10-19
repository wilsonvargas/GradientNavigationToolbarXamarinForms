//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;

//using Android.App;
//using Android.Content;
//using Android.OS;
//using Android.Runtime;
//using Android.Views;
//using Android.Widget;
//using Xamarin.Forms.Platform.Android;
//using Xamarin.Forms;
//using GradientNavigationHeader.Controls;
//using GradientNavigationHeader.Droid;
//using Android.Graphics.Drawables;

//[assembly: ExportRenderer(typeof(NavigationPageGradientHeader), typeof(NavigationPageGradientHeaderRenderer))]
//namespace GradientNavigationHeader.Droid
//{
//    public class NavigationPageGradientHeaderRenderer : PageRenderer
//    {
//        protected override void OnElementChanged(ElementChangedEventArgs<Page> e)
//        {
//            base.OnElementChanged(e);

//            //run once when element is created
//            if (e.OldElement != null || Element == null)
//            {
//                return;
//            }

//            var control = (NavigationPageGradientHeader)this.Element;
//            var context = (MainActivity)this.Context;

//            context.SupportActionBar.SetBackgroundDrawable(new GradientDrawable(GradientDrawable.Orientation.RightLeft, new int[] { control.RightColor.ToAndroid(), control.LeftColor.ToAndroid() }));
//        }
//    }
//}