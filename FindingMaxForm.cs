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
 /*
  * Created by: Tolu Adebayo
  * Created on: 15-June-2018
  * Created for: ICS3U Programming
  * Daily Assignment – Day #37 - Find Max Value
  * This program checks the max Value of a list of numbers
 */

        public frmFindingMax()
        {
            InitializeComponent();
        }

        // set MAX_ARRAY_SIZE to public
        const int MAX_ARRAY_SIZE = 10;

        private int GetMaxValue(int[] arrayOfNumbers)
        {
            // identify variables
            int tmpmaxValue = -1;
            int currentValue;


            for (int counter = 0; counter < MAX_ARRAY_SIZE; counter++)
            {
                currentValue = arrayOfNumbers[counter];

                if (tmpmaxValue < currentValue)
                {
                    tmpmaxValue = currentValue;
                }
            }

            // Return maxValue
            return tmpmaxValue;

        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            
            const int MAX_RANDOM_NUMBER = 500;
            int[] arrayOfIntegers = new int[MAX_ARRAY_SIZE];
            int counter, randomNumber, maxValue;
            Random randomNumberGenerator = new Random();

           
            for (counter = 0; counter < arrayOfIntegers.Length; counter ++)
            {
                // Generate Random Number
                randomNumber = randomNumberGenerator.Next(1, MAX_RANDOM_NUMBER + 1);
                // assign the random number to the cell
                arrayOfIntegers[counter] = randomNumber;
                // add random numbers to the lost box
                this.lstArrayNumbers.Items.Add(randomNumber);
            }
           

            // get Max value in the array
            maxValue = GetMaxValue(arrayOfIntegers);
            // Display the max value in the label
            this.lblAnswer.Text = "The Max Value is: " + maxValue;

        }

     

        private void FindingMaxForm_Load(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


    }
}
