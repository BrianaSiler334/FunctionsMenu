using System.Drawing;
using System.Runtime.Intrinsics.X86;

namespace MenuSelectionForFunctions {
    internal class Program {
        static void Main(string[] args) {

            int userSelection = 0;

            while (userSelection != 12) {
                userSelection = Menu();

                //switch statement
                switch (userSelection) {
                    case 0: { Console.WriteLine("Please make a selection"); break; }
                    case 1: {RomanNumerals(); break; }
                    case 2: {Area(); break; }
                    case 3: {MassAndWeight(); break; }
                    case 4: {MagicDates(); break; }
                    case 5: {ColorMixer(); break; }
                    case 6: {BookClubPoints(); break; }
                    case 7: {SoftwareSales(); break; }
                    case 8: {CoinsGame(); break; }
                    case 9: {ShippingCharges(); break; }
                    case 10: {BMI(); break; }
                    case 11: {TimeCalculator(); break; }
                }//end switch


                if (userSelection != 12) {
                    Input("Press enter to go back to the menu");
                }//end if

            }//end while

                Console.WriteLine("Thanks for using my program");
                }//end main

        static int Menu() {
            int userSelection = 0;


            do {
                Console.Clear();
                Console.WriteLine("Please make a selection from the menu.");
                Console.WriteLine("1.Roman Numerals");
                Console.WriteLine("2.Area Of Rectangles");
                Console.WriteLine("3.Mass and Weight");
                Console.WriteLine("4.Magic Dates");
                Console.WriteLine("5.Color Mixer");
                Console.WriteLine("6.Book CLub Points");
                Console.WriteLine("7.Software Sales");
                Console.WriteLine("8.Change For Dollar Game");
                Console.WriteLine("9.Shipping Charges");
                Console.WriteLine("10.Body Mass Index Program Enhancement");
                Console.WriteLine("11. Time Calculator");
                Console.WriteLine("Press 12 to exit program.");

                userSelection = int.Parse(Input("Please make a selection"));

            } while (userSelection < 0 || userSelection > 12);

            return userSelection;
        }

                

                static string Input(string prompt) {
                    Console.WriteLine(prompt + ":");
                    return Console.ReadLine();
                }//end function

        static void RomanNumerals() {
            Console.Clear();
            int input = int.Parse(Input("Enter a number between 1 and 10"));
            Console.WriteLine($"The roman numeral for {input} is");
            switch (input) {
                case 1: { Console.WriteLine("I"); break; }
                case 2: { Console.WriteLine("II"); break; }
                case 3: { Console.WriteLine("III"); break; }
                case 4: { Console.WriteLine("IV"); break; }
                case 5: { Console.WriteLine("V"); break; }
                case 6: { Console.WriteLine("VI"); break; }
                case 7: { Console.WriteLine("VII"); break; }
                case 8: { Console.WriteLine("VIII"); break; }
                case 9: { Console.WriteLine("IX"); break; }
                case 10: { Console.WriteLine("X"); break; }
                default: { Console.WriteLine("Error"); break; }
            }//end switch
        }//end void function


        static void Area() {
            Console.Clear();
            double lengthOne = double.Parse(Input("Enter the length of the first rectangle"));
            double widthOne = double.Parse(Input("Enter the width of the first rectangle"));
            double OneArea = lengthOne * widthOne;
            Console.WriteLine($"The area of the first rectangle is {OneArea}");
            double lengthTwo = double.Parse(Input("Enter the length of the second rectangle"));
            double widthTwo = double.Parse(Input("Enter the width of the second rectangle"));
            double TwoArea = lengthTwo * widthTwo;
            Console.WriteLine($"The area of the second rectangle is {TwoArea}");

            if (OneArea > TwoArea) {
                Console.WriteLine($"The first rectangle with the area of {OneArea} has the higher area");
            } else if (OneArea == TwoArea) {
                Console.WriteLine("The rectangles are the same");
            } else if (TwoArea > OneArea) {
                Console.WriteLine($"The second rectangle with the area of {TwoArea} has the higher area");
            }//end if
        }//end functions



        static void MassAndWeight() {
            Console.Clear();
            Console.WriteLine("This program will allow you to enter an object's mass and calculate its weight. If the mass is more than 1000 Newtons, it is too heavy and if the mass is less than 10 Newtons, it is too light and if it is neither, it will show you the calculation");
            Console.WriteLine();
            double mass = double.Parse(Input("Please enter object's mass"));
            double weight = 0.0;

            weight = mass * 9.8;

            if (weight > 1000) {
                Console.WriteLine("The mass is too heavy");
            } else if (weight < 10) {

                Console.WriteLine("Its too light");

            }//end else

            Console.WriteLine($"The object weighs {weight:f2}");

        }//end function


        static void MagicDates() {
            Console.Clear();
            Console.WriteLine("This program will tell you whether or not the date entered is a magic date or not.");
            Console.WriteLine();
            int month = 0;
            int day = 0;
            int year = 0;

            month = int.Parse(Input("Please enter a month in numeric form"));
            day = int.Parse(Input("Please enter the day"));
            year = int.Parse(Input("Please enter a two digit year."));

            if (month * day == year) {
                Console.WriteLine("Its a magic date!!");
            } else if (month * day != year) {
                Console.WriteLine("The date is not magic!");
            }//end if/else
        }//end function



        static void ColorMixer() {
            Console.Clear();
            Console.WriteLine("This program will allow you to enter the names of two primary colors and show the colors they make together");

            Console.WriteLine();

            string color1 = Input("Please enter the name of the first primary color to mix");
            string color2 = Input("Please enter the name of the second primary color to mix");

            if (color1 == "red" && color2 == "blue") {
                Console.WriteLine("The color is purple");
            } else if (color1 == "blue" && color2 == "red") {
                Console.WriteLine("The color is purple");
            } else if (color1 == "red" && color2 == "yellow") {
                Console.WriteLine("The color is orange");
            } else if (color1 == "yellow" && color2 == "red") {
                Console.WriteLine("The color is orange");
            } else if (color1 == "blue" && color2 == "yellow") {
                Console.WriteLine("The color is green");
            } else if (color1 == "yellow" && color2 == "blue") {
                Console.WriteLine("The color is green");
            } else {
                Console.WriteLine("Error");
            }//end else
        }//end function


        static void BookClubPoints() {
            Console.Clear();
            Console.WriteLine("This bookstore has a book club that awards points to customers based on the number of books purchased each month on a scale of 1-4.\n");
            int userInput = int.Parse(Input("Enter the number of books you have purchased this month"));

            if (userInput == 0) {
                Console.WriteLine("You have received 0 points");
            } else if (userInput == 1) {
                Console.WriteLine("You have received 5 points");
            } else if (userInput == 2) {
                Console.WriteLine("You have received 15 points");
            } else if (userInput == 3) {
                Console.WriteLine("You have received 30 points");
            } else if (userInput == 4) {
                Console.WriteLine("You have received 60 points!");
            }//end if statement
        }//end function



        static void SoftwareSales() {
            Console.Clear();
            Console.WriteLine("The EagleKnight software company sells packages that retail for $99.00. We give discounts depending on how many packages you purchased. Enter the amount of packages you have purchased to see your discount..");
            Console.WriteLine();
            double discount = 0.0;
            double total = 0.0;
            double amount = 0.0;
            double packages = double.Parse(Input("Enter the number of packages you have purchased."));

            if (packages >= 10 && packages <= 19) {
                discount = 0.20;
                total = discount * 99;
                amount = 99 - total;
                Console.WriteLine($"Your discount is 20% and your total is {amount:f2}");
            } else if (packages >= 20 && packages <= 49) {
                discount = 0.30;
                total = discount * 99;
                amount = 99 - total;
                Console.WriteLine($"Your discount is 30% and your total is {amount:f2}");
            } else if (packages >= 50 && packages <= 99) {
                discount = 0.40;
                total = discount * 99;
                amount = 99 - total;
                Console.WriteLine($"Your discount is 40% and your total is {amount:f2}");
            } else if (packages >= 100) {
                discount = 0.50;
                total = discount * 99;
                amount = 99 - total;
                Console.WriteLine($"Your discount is 50% and your total is {amount:f2}");
            } else {
                Console.WriteLine("You are not eligible for a discount and your total is $99.00");
            }//end if
        }//end function



        static void CoinsGame() {
            Console.Clear();
            Console.WriteLine("This coin game is designed to have you enter the number of coins required to make exactly one dollar.");
            double pennies = 0.01;
            double nickels = 0.05;
            double dimes = 0.10;
            double quarters = 0.25;
            double target;
            double dollar = 1.00;

            pennies = pennies * double.Parse(Input("Please enter the amount of pennies needed"));
            nickels = nickels * double.Parse(Input("Please enter the amount of nickels needed"));
            dimes = dimes * double.Parse(Input("Please enter the amount of dimes needed"));
            quarters = quarters * double.Parse(Input("Please enter the amount of quarters needed"));

            target = pennies + nickels + dimes + quarters;

            if (target == dollar) {
                Console.WriteLine("Congratulations, you have won the game");
            } else if (target > dollar) {
                Console.WriteLine("Sorry, the amount you entered is more than $1.00");
            } else if (target < dollar) {
                Console.WriteLine("Sorry, the amount you entered is less than 1.00");
            }//end if
        }//end function


        static void ShippingCharges() {
            Console.Clear();
            Console.WriteLine("The Fast Freight Shipping Company charges weights per pound. Enter the weight of a package and we will let you know the shopping charges");

            double packWeight = double.Parse(Input("Enter the weight of the package"));
            double twoPoundsLess = 1.10;
            double overTwoPounds = 2.20;
            double overSixPounds = 3.70;
            double overTenPounds = 3.80;

            if (packWeight <= 2) {
                Console.WriteLine($"Your shipping charges are ${twoPoundsLess:f2}\n");
            } else if (packWeight > 2 && packWeight <= 6) {
                Console.WriteLine($"Your shipping charges are ${overTwoPounds:f2}\n");
            } else if (packWeight > 6 && packWeight <= 10) {
                Console.WriteLine($"Your shipping charges are ${overSixPounds:f2}\n");
            } else if (packWeight > 10) {
                Console.WriteLine($"Your shipping charges are ${overTenPounds:f2}\n");
            }//end if
        }//end function



        static void BMI() {
            Console.Clear();
            double weight = double.Parse(Input("Please enter your weight"));
            Console.WriteLine();
            double height = double.Parse(Input("Please enter your height in inches"));
            Console.WriteLine();
            double bmi = weight * 703 / Math.Pow(height, 2);


            if (bmi > 18.5 && bmi < 25) {
                Console.WriteLine("Your weight is considered to be optimal.");
            } else if (bmi < 18.5) {
                Console.WriteLine("According to Body Mass Index Scale, you are underweight");
            } else if (bmi > 25) {
                Console.WriteLine("According to the Body Mass Index Scale, you are overweight");
            }//end if
        }//end function



        static void TimeCalculator() {
            Console.Clear();
            Console.WriteLine("This program allows you to enter a number of seconds and if your number is higher than 60, 3,600, or 84,400, it will tell you how many minutes, hours, and days are in those seconds in that order.");
            double seconds = int.Parse(Input("Enter a number of seconds"));
            double minutes = 60;
            double hours = 3600;
            double days = 86400;


            if (seconds >= 60) {
                minutes = seconds / 60;
                Console.WriteLine($"{minutes} minutes");
            }
            if (seconds >= 3600) {
                hours = seconds / 3600;
                Console.WriteLine($"{hours} hours");
            }
            if (seconds >= 86400) {
                days = seconds / 86400;
                Console.WriteLine($"{days} days");
            }//end if

        }//end function
    }//end class
}//end namespace

