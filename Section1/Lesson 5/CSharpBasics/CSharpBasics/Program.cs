using System;
using System.Collections.Generic;

namespace CSharpBasics
{
    class Program
    {
        static void Main(string[] args)
        {
            // int Value = AddTwoNumbers(100,50);

            // string Value2 = AddTwoStrings("Cary", "Baer");

            /*  Console.WriteLine(Value);
              Console.WriteLine(Value2);
              Console.ReadKey();  */

            //WhatsMyAge();

            WhatsInMyList();

        }

        static int AddTwoNumbers(int num1, int num2)
        {

            int result = num1 + num2;
            return result;

        }

        static string AddTwoStrings(string str1, string str2)
        {

            string result = str1 + " " + str2;
            return result;

        }

        static void WhatsMyAge()
        {
            string age = "";
            string name = "";

            Console.WriteLine("What's your name?");
            name = Console.ReadLine();
            Console.WriteLine("What's your age?");
            age = Console.ReadLine();

            int currentAge = int.Parse(age);

            

            int futureAge = 0;

            for (int i = 0; i < 10; i++)
            {
                futureAge = currentAge + i;

                if (i == 0)
                {
                    Console.WriteLine(name + " is " + age + " years old.");
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
            Console.ReadKey();

        }


        static void WhatsInMyList()
        {
            List<int> numList = new List<int>();

            numList.Add(15);
            numList.Add(22);
            numList.Add(2234);
            numList.Add(-34);

            Console.WriteLine("There are " + numList.Count + " items in the list.");
            
            for (int i = 0; i < numList.Count; i++)
            {
                Console.WriteLine(numList[i]);
            }

            foreach(int val in numList)
            {
                Console.WriteLine(val);
            }
            
            Console.ReadKey();

        }

    }
}
