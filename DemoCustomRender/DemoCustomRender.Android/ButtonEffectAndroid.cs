using System;
using System.ComponentModel;
using DemoCustomRender;
using DemoCustomRender.Droid;
using DemoCustomRender.Effects;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ResolutionGroupName("DemoCustomRender")]
[assembly: ExportEffect(typeof(ButtonBorderEffect), "ButtonBorderEffect")]
namespace DemoCustomRender.Droid
{
    public class ButtonEffectAndroid : PlatformEffect
    {
        //Android.Graphics.Color originalBackgroundColor = new Android.Graphics.Color(0, 0, 0, 0);
       // Android.Graphics.Color backgroundColor;
       // Android.Graphics.Color borderColor;
        public ButtonEffectAndroid()
        {
        }

        protected override void OnAttached()
        {
            try 
            {

                // backgroundColor = Android.Graphics.Color;
                //borderColor = Android.Graphics.Color.Transparent;
                Control.SetBackgroundColor(Android.Graphics.Color.Transparent);
                //Control.SetBackgroundResource(borderColor);

            }
            catch (Exception ex)
            {
                Console.WriteLine("Cannot set property on attached control. Error: ", ex.Message);
            }
        }

        protected override void OnDetached()
        {
            
        }

        
    }
}
