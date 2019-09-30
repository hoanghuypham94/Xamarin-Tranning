using System;
using Android.Content;
using Android.Graphics.Drawables;
using DemoCustomRender;
using DemoCustomRender.Droid;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
[assembly: ExportRenderer(typeof(BorderCustomRenderEntry), typeof(BorderEntryRendererAndroid
))]
namespace DemoCustomRender.Droid
{
    public class BorderEntryRendererAndroid : EntryRenderer
    {
        

        public BorderEntryRendererAndroid(Context context) : base(context)
        {
        }
        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);
            if (e.OldElement == null)
            {
                var gradientDrawable = new GradientDrawable();
                gradientDrawable.SetCornerRadius(3f);
                gradientDrawable.SetStroke(1, Android.Graphics.Color.LightSlateGray);
                gradientDrawable.SetColor(Android.Graphics.Color.LightGray);
                Control.SetBackground(gradientDrawable);

                Control.SetPadding(5, Control.PaddingTop, Control.PaddingRight,
                Control.PaddingBottom);
            }
        }
    }
}
