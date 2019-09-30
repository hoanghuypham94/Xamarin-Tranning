using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace DemoCustomRender
{
    public partial class RadioButtonCustomRenderer : ContentPage
    {
        bool radio, radio1;
        public RadioButtonCustomRenderer()
        {
            InitializeComponent();
            radio = false;
            radio1 = false;
        }

        public void OnButtonTapped(Object sender, EventArgs e)
        {
            radio = true;
            foto.Source = "check.png";

            if (radio1.Equals(true))
            {
                foto.Source = "uncheck.png";
                radio1 = false;
            }

        }

        public void OnButtonTapped1(Object sender, EventArgs e)
        {
            radio1 = true;
            foto1.Source = "check.png";

            if (radio.Equals(true))
            {
                foto1.Source = "uncheck.png";
                radio = false;
            }
        }

        private void Antworti_Clicked(object sender, EventArgs e)
        {
            if (radio == true)
                textradiobtn.Text = label.Text;
            if (radio1 == true)
                textradiobtn.Text = label1.Text;
        }
    }
}
