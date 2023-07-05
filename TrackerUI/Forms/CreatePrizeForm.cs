using System;
using System.Windows.Forms;
using TrackerLibrary;

namespace TrackerUI
{
    public partial class CreatePrizeForm : Form
    {
        public CreatePrizeForm()
        {
            InitializeComponent();
        }
        
        // TODO - When a Amount is added, no percentage can be added and vice versa
        private void CreatePrizeButton_Click(object sender, EventArgs e)
        {
            if (!ValidateForm())
            {
                MessageBox.Show("Entered wrong format. Please keep the following forrmat:\n" +
                                        "Place Number:  number\n" +
                                        "Place Name:  character\n" +
                                        "Prize Amount:  number\n" +
                                        "Prize Percentage:  number", "Wrong format",
                                        MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                PrizeModel model = new PrizeModel(  placeNumberValueTextbox.Text,
                                                    placeNameValueTextbox.Text,
                                                    prizeAmountValueTextbox.Text,
                                                    prizePercentageValueTextbox.Text);
                
                //foreach (IDataConnector db in GlobalConfig.Connection)
                //{
                //    db.CreatePrize(model);
                //}
                
                GlobalConfig.Connection.CreatePrize(model);

                placeNumberValueTextbox.Text = "Enter number";
                placeNameValueTextbox.Text = "Enter name";
                prizeAmountValueTextbox.Text = "Enter amount";
                prizePercentageValueTextbox.Text = "enter percentage";
            } 
        }

        private bool ValidateForm()
        {
            bool output = true;

            // Validate Place Number field
            if (int.TryParse(placeNumberValueTextbox.Text, out int placeNumber) == false && placeNumber < 1)
            {
                output = false;
            }

            // Validate Place Name field
            if (placeNameValueTextbox.Text.Length == 0)
            {
                output = false;
            }

            // Validate Prize Amount field
            if (decimal.TryParse(prizeAmountValueTextbox.Text, out decimal prizeAmount) == false || prizeAmount < 0)
            {
                output = false;
            }

            // Validate Prize Percentage field
            if (double.TryParse(prizePercentageValueTextbox.Text, out double prizePercentage) == false 
                                                                            && prizePercentage < 0     
                                                                            && prizePercentage > 100)
            {
                output = false;
            }

            return output;
        }
    }
}
/*

The foreach-loop in the CreatePrizeButton_Click method is a good example of how we can use the GlobalConfig class to access the connections list. It iterates through all the connections and adds the newly created prize model to the database. This is a good example on how to use static classes and methods to access data from anywhere in the application.











*/