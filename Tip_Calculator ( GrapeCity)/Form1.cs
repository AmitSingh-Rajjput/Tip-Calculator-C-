using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tip_Calculator___GrapeCity_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Declaration of the variable .

        double bill;         // to store bill amount.
        double tip;          // to store tip percentage.        
        double total_per_person; // to store total per person bill.
        int no_of_person;      // to store total number of person.
        double tip_amount;     // to store tip amount.
        double tip_person;     // to store tip amount per person.
        double total_bill;     // to store total bill amount per person.


        private void clearbtn_Click(object sender, EventArgs e) 
        {
            // clear text boxes and output
            
            billtextbox.Clear();
            Tiptestbox.Value=0;    
            persontextbox.Value=1;    // Here we set no of person equal to 1.Because person can't be 0.
            tippersontextbox.Clear();
            totaltextbox.Clear();
        }

        private void calculatebtn_Click(object sender, EventArgs e)
        {
            // calculates the bill amount per person and tip amount per person entered by user.        
            totaltextbox.Text = "";
            tippersontextbox.Text = "";


            try
            {
                

                bill = double.Parse(billtextbox.Text); 
                
                
                tip = double.Parse(Tiptestbox.Text);

                     
                no_of_person = int.Parse(persontextbox.Text);
                
                tip_amount = bill * (tip / 100);    // Here we store total tip amount in tip_amount.
                tip_person = tip_amount / no_of_person; // Here we store tip per person in tip_person.
                total_bill = bill + tip_amount;         // Calculate total bill.
                total_per_person = total_bill / no_of_person;  // Calculate total amount per person.
                tippersontextbox.Text = tip_person.ToString("c2");
                totaltextbox.Text = total_per_person.ToString("c2");
                        
          
            }
            // catches error with bill - double.Parse(billTextBox.Text);
            catch
            {
                MessageBox.Show("Please enter the bill amount");
                billtextbox.Focus();
                billtextbox.SelectAll();
            }
        }

        private void Exitbtn_Click(object sender, EventArgs e)
        {
            //To exit the application.

            Application.Exit();
        }

        private void billtextbox_KeyPress(object sender, KeyPressEventArgs e)

        {
            // Event for validate bill text box. To take only numerical and float type data.
            
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar !='.')
                e.Handled=true ;
        }

       
    }
}
