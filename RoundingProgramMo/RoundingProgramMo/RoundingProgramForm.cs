/*
 * Created by: Mohammed Alnajeh
 * Created on: 2018-12-12
 * Created for: ICS3U Programming
 * Daily Assignment – Day #31 - Rounding Program
*/


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RoundingProgramMo
{
    public partial class frmRoundingProgram : Form
    {
        public frmRoundingProgram()
        {
            InitializeComponent();
        }
        //procedure: Round Decimals
        //Input: usersNumber, usersNumDec
        //Output: usersNum rounded to usersNumDec Places
        //Description: takes users decimals number and rounds it to the amount of the places selected by user 
        private void RoundDecimals(ref double usersDecimal, int usersChoiceDecimal)
        {

            //round the users number to the amount of decimals places selected 
            usersDecimal = usersDecimal * Math.Pow(10, usersChoiceDecimal);
            usersDecimal = usersDecimal + 0.5;
            usersDecimal = Math.Truncate(usersDecimal);
            usersDecimal = usersDecimal / Math.Pow(10, usersChoiceDecimal);

            //display the rounded number in a message box
            MessageBox.Show("The rounded decimal is " + usersDecimal);    
        }

        private void btnRound_Click(object sender, EventArgs e)
        {
            double userNum;
            int userNumDec;

            userNum = Convert.ToDouble(txtDecimalNum.Text);
            userNumDec = Convert.ToInt16(nudDecimalPlaces.Value);

            this.RoundDecimals(ref userNum, userNumDec);
        }
    }
}
