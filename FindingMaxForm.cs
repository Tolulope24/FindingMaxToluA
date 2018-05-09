using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FindingMaxToluA
{
    public partial class frmFindingMax : Form
    {
       
        public frmFindingMax()
        {
            InitializeComponent();
        }

        private void FindingMaxForm_Load(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private int GetMaxValue(int[] arrayOfNumbers)
        {

            return

        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            // declare local variables and constants
            const int MAX_ARRAY_SIZE = 10;
            const int MAX_RANDOM_NUMBER = 500;
            int[] arrayOfIntegers = new int[MAX_ARRAY_SIZE];
            int counter, randomNumber, maxValue;
            Random randomNumberGenerator = new Random();

            // Generate Random Number
            randomNumber = randomNumberGenerator.Next(1, MAX_RANDOM_NUMBER + 1);
           
            for (counter = 0; counter < arrayOfIntegers.Length; counter ++)
            {
                // assign the random number to the cell
                arrayOfIntegers[counter] = randomNumber;
                // add random numbers to the lost box
                this.lstArrayNumbers.Items.Add(randomNumber);
            }
             if ( MAX_ARRAY_SIZE < MAX_RANDOM_NUMBER )
             {
                maxValue = 

             }

            // get Max value in the array
            maxValue = GetMaxValue(arrayOfIntegers);
            // Display the max value in the label
            this.lblAnswer.Text = "The Max Value is: " + maxValue;

        }
    }
}
