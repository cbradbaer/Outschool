using System;
using System.Collections.Generic;
using System.Net.Sockets;

namespace CSharpBasicsApp
{
    class Program
    {
        static void Main(string[] args)
        {
            /* int returnValue = 0;
             returnValue = AddTwoNumbers(15, 24);

             Console.WriteLine("The return value is: " + returnValue);
             Console.ReadKey();

             string returnString = "";
             returnString = AddTwoStrings("Hello", "Class");
             Console.WriteLine(returnString);
            */

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



        static void WhatsInMyList()
        {

            List<int> numList = new List<int>();
            numList.Add(14);
            numList.Add(23);
            numList.Add(44); 
            numList.Add(89); 
            numList.Add(12);
            numList.Add(14);
            numList.Add(23);
            numList.Add(44);
            numList.Add(89);
            numList.Add(12);


            Console.WriteLine("There are " + numList.Count + " numbers in the list");
            Console.ReadKey();
            for (int i = 0; i < numList.Count; i++)
            {
                Console.WriteLine(numList[i]);

            }
            Console.ReadKey();


            foreach (int value in numList)
            {
                Console.WriteLine(value);

            }
            Console.ReadKey();

        }




        static void WhatsMyAge()
        {
            string age = "";
            string name = "";
            Console.WriteLine("What is your name?  ");
            name = Console.ReadLine();

            Console.WriteLine("How old are you?  ");
            age = Console.ReadLine();

            Console.WriteLine(name + " is " + age + " years old");
            Console.ReadKey();

            int futureAge = 0;
            int currentAge = int.Parse(age);

            for (int i =0; i <= 10; i++)
            {
                futureAge = currentAge + i;

                if (i == 0)
                {
                    Console.WriteLine(name + " is currently " + currentAge + " years old.");
                }
                else if (i == 1)
                    {
                        Console.WriteLine("In " + i + " year " + name + " will be " + futureAge + " years old.");

                    }
                else
                {
                    Console.WriteLine("In " + i + " years " + name + " will be " + futureAge + " years old.");

                }
                
                

            }

        }

    }
}
