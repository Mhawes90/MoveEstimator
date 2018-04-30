using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
 * Move Estimator
 * by Mark Hawes
 * week 3
 * updated: 9/13/17
 */

namespace MoveEstimatorGUI
{

    public partial class estimatorWindow : Form
    {
        // constant values
        const double BASE_RATE = 200, HOUR_RATE = 150, MILE_RATE = 2;

        public estimatorWindow()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void calcButton_Click(object sender, EventArgs e)
        {
            // changes totalTextBox to display the current total
            totalTextBox.Text = totalTextBox.Text + 
                calculateCost(Convert.ToDouble(hoursInput.Text),
                Convert.ToDouble(mileInput.Text)).ToString("c");
        }

        // calculates total cost
        private double calculateCost(double estHours, double estMiles)
        {
            return (estHours * HOUR_RATE) + (estMiles * MILE_RATE) + BASE_RATE;
        }
    }
}
