using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void NameAndAge()
        {
            string firstName = "Craig";
            string lastName = "Dunlap";
            int age = 29;
        }

        [TestMethod]
        public void Array()
        {
            string[] movie = { "Batman", "DieHard", "Inception", "Little Women" };
        }
        [TestMethod]
        public void ListOfDates()
        {
            List<DateTime> listOfDates = new List<DateTime>();
            DateTime today = DateTime.Now;
            listOfDates.Add(today);
            listOfDates.Add(new DateTime(2020, 12, 25));
            listOfDates.Add(new DateTime(2019, 06, 12));
            listOfDates.Add(new DateTime(2020, 11, 17));
        }

        [TestMethod]
        public void HowMuchSleepDidYouGet()
        {
            Console.WriteLine("How many hours of sleep did you get today?");
            int hours = 4;
            if (hours >= 10)
            {
                Console.WriteLine("Wow that's a lot of sleep");
            }
            else if (hours > 8 && hours < 10)
            {
                Console.WriteLine("You should be well rested.");
            }
            else if (hours > 4 && hours < 8)
            {
                Console.WriteLine("Get some sleep");
            }
        }

        [TestMethod]
        public void HowHasYourDayBeen()
        {
            string userDay = "okay";
            switch (userDay)
            {
                case "Great":
                        Console.WriteLine("Glad you're having a great day");
                    break;
                case "Good":
                    Console.WriteLine("Glad it's going good!");
                    break;
                case "Okay":
                    Console.WriteLine("Hope it gets better!");
                    break;
                case "Bad":
                    Console.WriteLine("That really stinks!");
                    break;
                case ":'(":
                    Console.WriteLine("This is us now");
                    break;
                default:
                    Console.WriteLine("Say something!");
                    break;
            }
        }

        [TestMethod]
        public void Supercalifragilisticexpialidocious()
        {
            string name = "Supercalifragilisticexpialidocious";
            foreach (char letter in name)
            {
                if(letter == 'i')
                {
                Console.WriteLine(letter);

                }
            else
                Console.WriteLine("not an i");
            }
        }

        [TestMethod]
        public void MathTest()
        {
            for (short i = 100;  i < 500; i+=100)
            {
                Console.WriteLine(i+" ");
            }

        }
    }
}
