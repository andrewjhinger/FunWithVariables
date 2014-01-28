using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FunWithVariables
{
    public partial class FunWithVariables : Form
    {
        public FunWithVariables()
        {
            string myFirstName = "Johnson";
            int myAge = 95;
            double thePriceOfGasPerGallon = 3.10;

            InitializeComponent();

            string infoAboutMe = "My name is " +myFirstName + ", \n" +
                "I am " + myAge.ToString() + " years old, " + "\n" +
                " and the price of a gallon\n" +
                "of gas is " + thePriceOfGasPerGallon.ToString() + ".\n";

            Label myInfoTextLabel = new Label();
            myInfoTextLabel.AutoSize = true;
            myInfoTextLabel.Text = infoAboutMe;
            this.Controls.Add(myInfoTextLabel);

            int myInteger = 32;
            long myLong = 32;

            float myFloat = 500F;
            double myDouble = 500;

            long myIntegerLongResult = myInteger + myLong;
            double myFloatDoubleResult = myFloat + myDouble;
            int myIntegerMathResult = myInteger + 20 / 2 * 10;
            float myFloatMathResult = myFloat - 10.5F / (2 * 10);

            Console.WriteLine("myIntegerLongResult: " + myIntegerLongResult);
            Console.WriteLine("myFloatDoubleResult: " + myFloatDoubleResult);

            Console.WriteLine("myIntegerMathResult: " + myIntegerMathResult);
            Console.WriteLine("myFloatMathResult: " + myFloatMathResult);


        }
    }
}
