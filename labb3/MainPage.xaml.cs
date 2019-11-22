using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace labb3
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();

        }

        private void OnLowClicked(object sender, EventArgs args)
        {
            if (UserInput.Text != null)
            {
                Belopp.Text = UserInput.Text + " SEK";
                Moms.Text = Eight.Text;

                double amount = double.Parse(UserInput.Text);

                var calcVal = amount * 0.92;
                UtBelopp.Text = calcVal.ToString() + " SEK";

                var calcVat = amount * 0.08;
                UtMoms.Text = calcVat.ToString() + " SEK";
            }
        }

        private void OnMidClicked(object sender, EventArgs args)
        {
            if (UserInput.Text != null)
            {
                Belopp.Text = UserInput.Text + " SEK";
                Moms.Text = Twelve.Text;

                double amount = double.Parse(UserInput.Text);

                var calcVal = amount * 0.88;
                UtBelopp.Text = calcVal.ToString() + " SEK";

                var calcVat = amount * 0.12;
                UtMoms.Text = calcVat.ToString() + " SEK";
            }
        }

        private void OnHighClicked(object sender, EventArgs args)
        {
            if (UserInput.Text != null)
            {
                Belopp.Text = UserInput.Text + " SEK";
                Moms.Text = TwentyFive.Text;

                double amount = double.Parse(UserInput.Text);

                var calcVal = amount * 0.75;
                UtBelopp.Text = calcVal.ToString() + " SEK";

                var calcVat = amount * 0.25;
                UtMoms.Text = calcVat.ToString() + " SEK";
            }
        }
    }
}
