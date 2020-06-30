using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;

namespace CSharpBasicsApp
{
    class Program
    {
        static void Main(string[] args)
        {
            /* int result = AddTwoNumbers(45, 23);

             Console.WriteLine("The answer is " + result);
             Console.ReadKey();

             string str = AddTwoStrings("Hello", "Class");

             Console.WriteLine("The answer is " + str);
             Console.ReadKey(); */

            //WhatsMyAge();

            WhatsInMyList();




        }

        static int AddTwoNumbers(int a, int b)
        {
            int c = a + b;
            return c;

        }

        static string AddTwoStrings(string a, string b)
        {
            string c = a + " " + b;
            return c;

        }

        static void WhatsMyAge()
        {
            string name = "";
            string age = "";

            Console.WriteLine("What is your name?");
            name = Console.ReadLine();

            Console.WriteLine("How old are you?");
            age = Console.ReadLine();
            int currentAge = int.Parse(age);
            int futureAge = 0;

           
            

            for (int i = 0; i < 10; i++)
            {
                futureAge = currentAge + i;

                if(i == 0)
                {
                    Console.WriteLine("You are currently " + currentAge + " years old.");
                }
                else if (i == 1)
                {
                    Console.WriteLine("In " + i + " year, you will be " + futureAge + " years old");
                }
                else
                {
                    Console.WriteLine("In " + i + " years, you will be " + futureAge + "years old");

                }
            
            }
            Console.ReadKey();
        }


        static void WhatsInMyList()
        {
            List<int> intList = new List<int>();
            intList.Add(34);
            intList.Add(14);
            intList.Add(66);
            intList.Add(78); 
            intList.Add(34);
            intList.Add(22);

            Console.WriteLine(intList.Count);
            Console.ReadKey();

            for (int i = 0; i < intList.Count; i++)
            {
                Console.WriteLine(intList[i]);              
            }
            Console.ReadKey();

            foreach(int value in intList)
            {
                Console.WriteLine(value);
            }
            Console.ReadKey();

        }




    }
}
