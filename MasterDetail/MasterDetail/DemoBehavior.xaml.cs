using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace MasterDetail
{
    public partial class DemoBehavior : ContentPage
    {
        public DemoBehavior()
        {
            InitializeComponent();
        }

        void NextPage_Behavior(object sender,EventArgs e)
        {
            Navigation.PushAsync(new DemoCalculator());
        }
    }
}
