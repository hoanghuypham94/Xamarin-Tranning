using System;

using Xamarin.Forms;

namespace MasterDetail
{
    public class calculator : ContentPage
    {
        public calculator()
        {
            Content = new StackLayout
            {
                Children = {
                    new Label { Text = "Hello ContentPage" }
                }
            };
        }
    }
}

