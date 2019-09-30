using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace DemoCustomRender
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        
        bool radio, radio1,radio2;
        public MainPage()
        {
            InitializeComponent();
            radio = false;
            radio1 = false;
            radio2 = false;

        }

        public void OnButtonTapped(Object sender, EventArgs e)
        {
            
            foto.Source = "check.png";
            foto1.Source = "uncheck1.png";
            foto2.Source = "uncheck1.png";

            radio = true;
            radio1 = false;
            radio2 = false;
            

        }

        public void OnButtonTapped1(Object sender, EventArgs e)
        {
            foto.Source = "uncheck1.png";
            foto1.Source = "check.png";
            foto2.Source = "uncheck1.png";

            radio = false;
            radio1 = true;
            radio2 = false;
        }

        public void OnButtonTapped2(Object sender, EventArgs e)
        {
            foto.Source = "uncheck1.png";
            foto1.Source = "uncheck1.png";
            foto2.Source = "check.png";

            radio = false;
            radio1 = false;
            radio2 = true;
        }

        public void CheckedChanged(object sender, EventArgs e)
        {
            if (radio == true)
                textradiobtn.Text = label.Text;
            if (radio1 == true)
                textradiobtn.Text = label1.Text;
            if (radio2 == true)
                textradiobtn.Text = label2.Text;
        }
    }
}
