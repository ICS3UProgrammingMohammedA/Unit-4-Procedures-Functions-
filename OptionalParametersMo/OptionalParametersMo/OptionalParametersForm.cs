/*
 * Created by: Mohammed Alnajeh
 * Created on: 2018-12-06
 * Created for: ICS3U Programming
 * Daily Assignment – Day #32 - Address Program
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

namespace OptionalParametersMo
{
    public partial class frmOptionalParameters : Form
    {
        public frmOptionalParameters()
        {
            InitializeComponent();
        }

        private void PrintAddress(string streetaddress, string City, string Province, string PostalCode, string ApartmentNumber)
        {
            MessageBox.Show("your address is " + streetaddress + " " + City + " " + Province + " " + PostalCode + " " + ApartmentNumber);
        }

        private void PrintAddress(string streetaddress, string City, string Province, string PostalCode)
        {
            MessageBox.Show("your address is " + streetaddress + " " + City + " " + Province + " " + PostalCode);
        }


        private void btnEnter_Click(object sender, EventArgs e)
        {
            //declare local variables 
            string userApartmentNum, userStreetAddress , userCity  ,userPostalCode  ,userProvince ;

            //get names from the textbox
            userApartmentNum = this.txtEnterUnit.Text;
            userStreetAddress = this.txtEnterAddress.Text;
            userCity = this.txtEnterCity.Text;
            userPostalCode = this.txtEnterPostalCode.Text;
            userProvince = this.txtEnterProvince.Text;

            //the user entring the address
            if ( userApartmentNum == "")
            {
                MessageBox.Show("please enter your street address");
            }
            else if (userCity == "")
            {
                MessageBox.Show("please enter your City");
            }
            else if (userPostalCode == "")
            {
                MessageBox.Show("please enter your Postal Code");
            }
            else if (userProvince == "")
            {
                MessageBox.Show("please enter your Province");
            }
            //if the user doesn't enter an apartment number, call the procedure that accepts four strings
            else if (userApartmentNum == "")
            {
                PrintAddress(userStreetAddress, userCity, userProvince, userPostalCode);
            }
            //if the user enetrs an apartment number, call the procedure that accepts five strings
            else
            {
                PrintAddress(userStreetAddress, userCity, userProvince, userPostalCode, userApartmentNum);
            }
        }
    }
    

}

