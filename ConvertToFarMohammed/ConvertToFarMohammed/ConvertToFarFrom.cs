/*
 * Created by: Mohammed Alnajeh
 * Created on: 2018-11-30
 * Created for: ICS3U Programming
 * Daily Assignment – Day #30 - Area Procedure
 * This program...
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

namespace ConvertToFarMohammed
{
    public partial class frmConvertToFar : Form
    {
        public frmConvertToFar()
        {
            InitializeComponent();
        }

        public double ConvertToFar( double Celsius)
        {
            //declare  variables
            double far = 0;

            //convert from farinhieght to celsius
            far = Celsius * (9) / (double)(5) + 32;

            return far;
            
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            //declare local variaalbles
            double usercelsius;

            //convert from string to a double
            usercelsius = double.Parse(txtCelsuis.Text);

            //calling function
            usercelsius = ConvertToFar(usercelsius);
            
            //convert to string
            lblAns.Text = string.Format("{0:0.00}", usercelsius) + "far";



        }
    }
}
