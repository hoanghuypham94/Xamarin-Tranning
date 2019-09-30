using System;
using System.Linq;
using DemoCustomRender.Effects;
using DemoCustomRender.iOS;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ResolutionGroupName("DemoCustomRender")]
[assembly: ExportEffect(typeof(ButtonEffectIOS), "ButtonBorderEffect")]
namespace DemoCustomRender.iOS
{
    public class ButtonEffectIOS : PlatformEffect
    {
        

        protected override void OnAttached()
        {
            Button button = Element as Button;
            if (button == null)
                return;
            try
            {
                var effect = (ButtonEffect)Element.Effects.FirstOrDefault(e => e is ButtonEffect);
              
                    Control.Layer.CornerRadius = effect.Radius;
                    Control.Layer.BorderColor = effect.Color.ToCGColor();
                    Control.Layer.ShadowColor = effect.Color.ToCGColor();
                    Control.Layer.ShadowOffset = new CoreGraphics.CGSize(effect.DistanceX, effect.DistanceY);
                    Control.Layer.ShadowOpacity = 1.0f;
                    
                
            }
            catch (Exception)
            {
                Console.WriteLine();
            }
        }

        protected override void OnDetached()
        {
            
        }
    }
}
