using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TournamentTracker;

namespace ApplicationUI
{
    public partial class CreatePrizeForm : Form
    {
        IPrizeRequester callingForm;
        public CreatePrizeForm(IPrizeRequester caller)
        {
            InitializeComponent();

            callingForm = caller;
        }

        private void createPrizeButton_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                PrizeModel model = new PrizeModel(
                    placeNameValue.Text,
                    placeNumberValue.Text,
                    prizeAmountValue.Text,
                    prizePercentageValue.Text);


                GlobalConfig.Connection.CreatePrize(model);

                callingForm.PrizeComplete(model);

                this.Close();
            }
            else
            {
                MessageBox.Show("Nem megfelelő adatok. Kérjük próbálja újra.");
            }
        }

        private bool ValidateForm()
        {
            bool output = true;
            int placeNumber = 0;
            bool placeNumberValidNumber = int.TryParse(placeNumberValue.Text, out placeNumber);

            //Place Number Validation
            if (!placeNumberValidNumber)
            {
                output = false;
            }

            if (placeNumber<1)
            {
                output = false;
            }

            //Place Name Validation
            if(placeNameValue.Text.Length == 0)
            {
                output = false;
            }

            //Place Amount & Perccentage Validation
            decimal prizeAmount = 0;
            int prizePercentage = 0;

            bool prizeAmountValid = decimal.TryParse(prizeAmountValue.Text, out prizeAmount);
            bool prizePercentageValid = int.TryParse(prizePercentageValue.Text, out prizePercentage);

            if (!prizeAmountValid || !prizePercentageValid) 
            {
                output = false;
            }

            if (prizeAmount <= 0 && prizePercentage <= 0) 
            {
                output = false;
            }

            if (prizePercentage < 0 || prizePercentage > 100) 
            {
                output = false;
            }

            return output;
        }
    }
}
