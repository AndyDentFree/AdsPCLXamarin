using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Foundation;
using UIKit;

using Xamarin.Forms.Platform.iOS;
using iOS.CustomRenders;
using iAd;
using Xamarin.Forms;
using AdsPCL;


[assembly: ExportRenderer(typeof(MyBanner), typeof(CustomBannerRenderer))]
namespace iOS.CustomRenders
{
    public class CustomBannerRenderer : ViewRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Xamarin.Forms.View> e)
        {
            base.OnElementChanged(e);

            var adBannerView = new ADBannerView(new CoreGraphics.CGRect(0, 386, 320, 50));
            base.SetNativeControl(adBannerView);

        }
    }
}