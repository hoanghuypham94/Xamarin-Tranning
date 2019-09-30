using System;
using DemoCustomRender;
using DemoCustomRender.iOS;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;
[assembly: ExportRenderer(typeof(BorderCustomRenderEntry), typeof(BorderEntryRendererIOS))]
namespace DemoCustomRender.iOS
{
    public class BorderEntryRendererIOS :EntryRenderer
    {
        bool radio, radio1;
        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);
            if (e.OldElement == null)
            {
                
                Control.Layer.CornerRadius = 5;
                //Control.Layer.BorderColor = Color.Transparent.ToCGColor() ;
                Control.Layer.BorderWidth = 1;
                Control.Layer.BorderColor = Color.LightSlateGray.ToCGColor();
                Control.TextAlignment = UITextAlignment.Left;
                //Control.Layer. = Color.Aqua;
                //Control.Layer.B
                
            }

        }
        
    }
}

