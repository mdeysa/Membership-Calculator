using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment4
{
    public partial class Form1 : Form
    {
        double adults = 50.00;
        double seniors = 40.00;
        double students = 25.00;
        double children = 15.00;
        double yoga = 10.00;
        double zumba = 15.00;
        double karate = 20.00;
        double water = 25.00;
        double trainer = 50.00;
        double rate;
        double total1;
        double total2;
        double subtotal;
        double salesTax;
        double finalTotal;
        int months;
        const double TAX = .08;



        public Form1()
        {
            InitializeComponent();
        }

        // returns the rate of the selected membership type
        private double calcBaseFee(int months, double rate)
        {
              
            if(radioButtonAdult.Checked)
            {
                rate = adults;
            }
            else if (radioButtonSenior.Checked)
            {
                rate = seniors;
            }
            else if (radioButtonStudents.Checked)
            {
                rate = students;
            }
            else if (radioButtonChildren.Checked)
            {
                rate = children;
            }


            //input validation for months
            if (int.TryParse(textBox1.Text, out months))
            {
                total1 = months * rate;
            }
            else
            {
                MessageBox.Show("Invalid input for months");
            }

            return total1;
        }

        private double calcAddFee(int months)
        {
            if (checkBoxYoga.Checked)
            {
                total2 += yoga;
            }
            if (checkBoxZumba.Checked)
            {
                total2 += zumba;
            }
            if (checkBoxKarate.Checked)
            {
                total2 += karate;
            }
            if (checkBoxWater.Checked)
            {
                total2 += water;
            }
            if (checkBoxTrainer.Checked)
            {
                total2 += trainer;
            }

            //input validation for months
            if (int.TryParse(textBox1.Text, out months))
            {
                total2 = months * total2;
            }
            else
            {
                MessageBox.Show("Invalid input for months");
            }


            return total2;
        }


        // calculation of subtotal
        private double SubTotal(double total1, double total2)
        {
            subtotal = total1 + total2;
            
            return subtotal;
        }        
        

        // sales tax calculation 
        private double SalesTax(double subtotal, double tax)
        {
            salesTax = subtotal * TAX;

            return salesTax;
        }        


        private void buttonTotal_Click(object sender, EventArgs e)
        {
            total1 = calcBaseFee(months, rate);
            total2 = calcAddFee(months);
            subtotal = SubTotal(total1, total2);
            salesTax = SalesTax(subtotal, TAX);
            finalTotal = subtotal + salesTax;
            
            MessageBox.Show("Your total comes out to: $" + finalTotal.ToString());
            // clears previous data 
            months = 0;
            rate = 0;
            total1 = 0;
            total2 = 0;
            subtotal = 0;
            salesTax = 0;
            finalTotal = 0;
            textBox1.Text = " ";

           

        }

        // exit the application 
        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBox1.Text = " ";
            months = 0;
            rate = 0;
            total1 = 0;
            total2 = 0;
            subtotal = 0;
            salesTax = 0;
            finalTotal = 0;

        }
    }
}
