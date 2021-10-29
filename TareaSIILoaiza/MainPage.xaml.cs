using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace TareaSIILoaiza
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        

        private void btnCalc_Clicked(object sender, EventArgs e)
        {
            try
            {
                double nS1 = Convert.ToDouble(txtNs1.Text);
                double nE1 = Convert.ToDouble(txtNe1.Text);
                double calc1 = (nS1*0.3) + (nE1*0.2);
                txtNp1.Text = calc1.ToString();

                double nS2 = Convert.ToDouble(txtNs2.Text);
                double nE2 = Convert.ToDouble(txtNe2.Text);
                double calc2 = (nS2 * 0.3) + (nE2 * 0.2);
                txtNp2.Text = calc2.ToString();

                double tot = calc1 + calc2;
                txtNt.Text = (tot).ToString();

                if (tot >= 7) {
                    txtMsg.Text = "APRUEBA";
                    txtMsg.TextColor = Color.Green;
                }else if (tot >= 5 && tot <=6.9)
                {
                    txtMsg.Text = "SUPLETORIO";
                    txtMsg.TextColor = Color.Orange;
                }else if (tot < 5)
                    {
                        txtMsg.Text = "REPROBADO";
                        txtMsg.TextColor = Color.Red;
                    }
            }
            catch (Exception ex) {
                DisplayAlert("ERROR",ex.Message,"OK");
            }
        }
    }
}
