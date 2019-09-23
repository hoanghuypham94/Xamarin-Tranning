using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace MasterDetail
{
    public partial class D : ContentPage
    {
        public D()
        {
            
            InitializeComponent();
            var lblName = new Label { Font = Font.SystemFontOfSize(NamedSize.Medium) };
            lblName.SetBinding(Label.TextProperty, "Name");
            var lblNumber = new Label { Font = Font.SystemFontOfSize(NamedSize.Medium) };
            lblNumber.SetBinding(Label.TextProperty, "Number");

        }

        private void ButtonAddbefore_Clicked(object sender, EventArgs e)
        {
            Navigation.InsertPageBefore(new DemoAbsoluteLayout(), this);
        }
       
        private void ButtonNext_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new DemoGrid());
        }

        private void ButtonRemove_Clicked(object sender, EventArgs e)
        {
            if (this.Navigation.NavigationStack.Count - 2 > 0)
            {
                Navigation.RemovePage(this.Navigation.NavigationStack[this.Navigation.NavigationStack.Count - 2]);
            }
        }
    }
}
