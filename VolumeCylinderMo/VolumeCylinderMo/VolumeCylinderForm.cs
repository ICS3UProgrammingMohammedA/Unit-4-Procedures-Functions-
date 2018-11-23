/*
 * Created by: Mohammed Alnajeh
 * Created on: 2018 - 11-22
 * Created for: ICS3U Programming
 * Daily Assignment – Day #33 - Volume of a Cylinder
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

namespace VolumeCylinderMo
{
    public partial class frmVolumeCylinder : Form
    {
        public frmVolumeCylinder()
        {
            InitializeComponent();
            lblAnswer.Hide();
        }


        private double CalculateVolume (double userRadius, double userHeight)
        {
            //declare local variables
            double Volume = 0;

            Volume = Math.PI * Math.Pow(userRadius, 2) * userHeight;

            //return the volum to the procedure
            return Volume;
            
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            //declare variables
            double radius, height, uservolume;

            //convert the string to a double 
            radius = double.Parse(txtRadius.Text);
            height = double.Parse(txtHeight.Text);

            //call the procedure
            uservolume = CalculateVolume(radius, height);

            lblAnswer.Text = string.Format("{0:0.00}", uservolume) + "Cm³";

            //showing the hidden label
            lblAnswer.Show();
        }
    }
  
}
