using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Calculator
{
    public partial class MainPage : ContentPage
    {

        decimal result; 
        string buffer="";
        char op;
        decimal[] operand = new decimal[2];
        int step = 1;
        

        public MainPage()
        {
            InitializeComponent();
            OnClear(this, null);
         
           
        }

        

        public void OnClear(object sender, EventArgs e)
        {
                if (buffer.Length == 0)
                {
                    step = 1;
                    operand[0] = operand[1] = 0;
                    op = ' ';
                    result = 0;
                }
                else
                    buffer = "";
                lblresult.Text = "0";
      
        }
      

        private void OnSelectOperator(object sender, EventArgs e)
        {
           

            Button b = sender as Button;
            op = b.Text[0];
           
            if (buffer.Length == 0)
                operand[step - 1] = result;
            else
                operand[step - 1] = Decimal.Parse(buffer);
            if (step == 2)
            {
                OnCalculator(null, null);
               
         
                operand[0] = result;
                step = 2;
            }
            else
            {
                lblresult.Text = operand[0].ToString("#,#.########");
                step++;
            }
            lblresult.Text = op.ToString();
            buffer = "";

        }

        private void OnCalculator(object sender, EventArgs e)
        {
            if (buffer.Length != 0)
                operand[1] = decimal.Parse(buffer);
            switch (op)
            {
                case '+': result = operand[0] + operand[1]; break;
                case '-': result = operand[0] - operand[1]; break;
                case 'x': result = operand[0] * operand[1]; break;
                case '/': result = operand[0] / operand[1]; break;
            }          

            lblresult.Text = result.ToString("#,#.########");
            step = 1;
            buffer = "";
        }
     
        

        private void OnSelectNumber(object sender, EventArgs e)
        {
           

            Button b = sender as Button;
            if ((b == null) || (b.Text == "0" && buffer.Length == 0)|| buffer.Length>=9)
                return;

            buffer += b.Text;
            buffer = Convert.ToDecimal(buffer).ToString("#,#.#######");
            lblresult.Text = buffer;
           

        }

        private void OnSelectNagete(object sender, EventArgs e)
        {
            if (buffer.Contains('-'))
                buffer = buffer.Replace("-", "");
            else
                buffer = "-" + buffer;
            lblresult.Text = buffer;
        }

        private void OnSelectDot(object sender, EventArgs e)
        {
            if (!buffer.Contains(','))
            {
                buffer = buffer + ",";
                lblresult.Text = buffer;
            }

        }

     

        private void OnSwiped(object sender, SwipedEventArgs e)
        {
            if (buffer.Length > 0)
            {
                buffer = buffer.Remove(buffer.Length - 1);
                lblresult.Text = "" + buffer;
            }
            else {
                buffer = "";
                lblresult.Text = "0";
            }
           

        }
    }
}
