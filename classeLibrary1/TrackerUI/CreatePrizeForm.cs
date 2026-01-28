using Library1;
using Library1.DataAccess;
using Library1.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace TrackerUI
{
    public partial class CreatePrizeForm : Form
    {
        public object Prize { get; internal set; }

        public CreatePrizeForm()
        {
            InitializeComponent();

        }
        private void prizeAmountValue_TextChanged(object sender, EventArgs e)
        {

        }


        private void placeNumberValue_TextChanged(object sender, EventArgs e)
        {

        }

        private void placeNameValues_TextChanged(object sender, EventArgs e)
        {

        }

        private void createPrizeBotton_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                PrizeModel model = new PrizeModel(
                placeNameValues.Text,
                placeNumberValue.Text,
                prizeAmountValue.Text,
                prizePercentageValue.Text
                );


                foreach (IDataConnection db in GlobalConfig.Connections)
                {
                    db.CreatePrize(model);
                }
                placeNameValues.Text = "";
                placeNumberValue.Text = "";
                prizeAmountValue.Text = "0";
                prizePercentageValue.Text = "0";
                   

            }
            else
            {
                MessageBox.Show("This form has invalid information. Please check it and try again.");
            }
        }
        private bool ValidateForm()
        { 
            bool output = true;
            int placeNumber = 0;
            bool placeNumberValidNumber = int.TryParse(placeNumberValue.Text, out placeNumber);
            if(placeNumberValidNumber == false)
            { 
                output = false;

            }
            if(placeNumber < 1)
            {
                output = false;
            }
            if(placeNumberValue.Text.Length == 0)
            {
                output = false;
            }
            decimal prizeAmount = 0;
            double percentage = 0;

            bool prizeAmountValid = decimal.TryParse(prizeAmountValue.Text, out prizeAmount);
            bool prizePercentageValid = double.TryParse(prizePercentageValue.Text, out percentage);

            if(prizeAmountValid == false || prizePercentageValid == false)
            {
                output = false;
            }
            if(prizeAmount <= 0 && percentage <= 0)
            {
                output = false;
            }
            if(percentage < 0 || percentage > 100)
            {
                output = false;
            }


            return output;
        }
    }
}
