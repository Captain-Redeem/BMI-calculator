using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMI_calculator
{
    class BMI_template
    {
        //this property collects input from the user and stores it in the variable.
        //this variable collects data as string and it collects the patient name.
        public string Name
        {
            get;
            set;
        }

        //this property collects input from the user and stores it in the variable.
        //this variable collects data as string and it collects patient age.
        public string Age
        {
            get;
            set;
        }

        //this property collects input from the user and stores it in the variable.
        //this variable collects data as decimals and it collects the weight of patient.
        public decimal Weight
        {
            get;
            set;
        }

        //this property collects input from the user and stores it in the variable.
        //this variable collects data as decimals and it collects the weight of the patient.
        public decimal Height
        {
            get;
            set;
        }

        //this property collects input from the user and stores it in the variable.
        //this variable collects data as decimals and it is meant to retreive patient BMI as a decimal.
        private decimal BMI
        {
            get;
            set;
        }

        //display method to display patient name
        public void DisplayName()
        {
            Console.WriteLine("Your name is: " + Name);
        }

        //display method to display patient age
        public void DisplayAge()
        {
            Console.WriteLine("Your age is: " + Age);
        }

        //display method to display patient weight in KG
        public void DisplayWeight()
        {
            Console.WriteLine("your weight is: " + Weight + " KG");
        }

        //display method to display patient height in metres
        public void DisplayHeight()
        {
            Console.WriteLine("Your height is: " + Height + " metres");
        }

        //method to verify patient identity through name
        public string checkpatient()
        {
            if (Name == "Usman")
            {
                return "This patient is registered Wakefield hospital";
            }

            else if (Name == "Khalifa")
            {
                return "This patient is registered with Wakefield Hospital";
            }
            else
            {
                return "This patient is not registered with us";
            }
        }


        public string CheckBMI()
        {
            if (BMI <= 18.5m)
            {
                return "You are in underweight range";
            }
            else if (BMI >= 18.6m && BMI <= 24.9m)
            {
                return "You are in a healthy weight range";
            }
            else if (BMI >= 25.0m && BMI <= 29.9m)
            {
                return "You are in the overweight range";
            }
            else if (BMI >= 30m && BMI <= 39.9m)
            {
                return "you are in obese range";
            }
            else
            {
                return "you are severely obese";
            }
        }

        public void CalculateBMI()
        {
            BMI = Weight / (Height * Height);
            BMI = Math.Round(BMI, 2);
            Console.WriteLine(BMI + " is your BMI");
        }
    }
}
