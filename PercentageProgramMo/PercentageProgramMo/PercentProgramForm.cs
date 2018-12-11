/*
 * Created by: Mohammed Alnajeh
 * Created on: 2018-12-10
 * Created for: ICS3U Programming
 * Daily Assignment – Day #30 - Temperature Converter
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

namespace PercentageProgramMo
{
    public partial class frmPercentProgram : Form
    {
        public frmPercentProgram()
        {
            InitializeComponent();  
        }

        private int ConvertToPercent(string level)
        {
            int percentage;

            switch (level)
            {
                case "4++":
                    percentage = 98;
                    break;
                case "4+":
                    percentage = 95;
                    break;
                case "4":
                    percentage = 85;
                    break;
                case "4-":
                    percentage = 80;
                    break;
                case "3+":
                    percentage = 78;
                    break;
                case "3":
                    percentage = 75;
                    break;
                case "3-":
                    percentage = 72;
                    break;
                case "2+":
                    percentage = 68;
                    break;
                case "2":
                    percentage = 65;
                    break;
                case "2-":
                    percentage = 62;
                    break;
                case "1+":
                    percentage = 58;
                    break;
                case "1":
                    percentage = 55;
                    break;
                case "1-":
                    percentage = 52;
                    break;
                case "0+":
                    percentage = 45;
                    break;
                case "0":
                    percentage = 40;
                    break;
                case "0-":
                    percentage = 35;
                    break;
                case "0--":
                    percentage = 30;
                    break;
                case "0---":
                    percentage = 20;
                    break;
                case "0----":
                    percentage = 10;
                    break;

                default:
                    percentage = -1;
                    break;
            }
            return percentage;
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            string level = "";
            int percentage;

            level = Convert.ToString(txtGrade.Text);
            Console.WriteLine(level);

            percentage = ConvertToPercent(level);

            this.lblAverage.Text = ("Percentage = " + percentage + "%");
        }
    }
}
