using System;
using Xamarin.Forms;

namespace MasterDetail
{
    public class TextChangedBehavior : Behavior<Entry>
    {
        protected override void OnAttachedTo(Entry bindable)
        {
            bindable.TextChanged += TextcolorChanged;
            base.OnAttachedTo(bindable);
        }

        protected override void OnDetachingFrom(Entry bindable)
        {
            bindable.TextChanged -= TextcolorChanged;
            base.OnDetachingFrom(bindable);
        }

        void TextcolorChanged(object sender, TextChangedEventArgs e)
        {
            double result;
            bool isValid = double.TryParse(e.NewTextValue, out result);
            
            //((Entry)sender).MaxLength <  ? Color.Default : Color.Red;
            bool isLength = e.NewTextValue.Length <= 10;
            //((Entry)sender).TextColor = isLength ? Color.Default : Color.Red;
            if(isLength == false)
            {
                ((Entry)sender).TextColor = Color.Red;//quá 10 số 
            }
            else
            {
                ((Entry)sender).TextColor = isValid ? Color.Default : Color.Orange;
            }
        }
    }
}
