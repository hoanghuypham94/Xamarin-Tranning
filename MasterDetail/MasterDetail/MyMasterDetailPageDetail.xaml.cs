using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Contacts;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MasterDetail
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MyMasterDetailPageDetail : ContentPage
    {
        public MyMasterDetailPageDetail()
        {
            InitializeComponent();
             
        }
        
        private void Button_NextPage(object sender, EventArgs e)
        {

            var contact = new Contact(){
                Name = "Mr.1",
                Number = "099999999",
            };


            var secondPage = new D();
            secondPage.BindingContext = contact;

            Navigation.PushAsync(new D());
        }

        
        
    }
}
