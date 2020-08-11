using System;
using System.Collections.Generic;

namespace CSharpBasicsApp
{
    class Program
    {
        static void Main(string[] args)
        {
            /* int result = AddTwoNumbers(23, 34);
             string str = "The answer is ";
             Console.WriteLine(str + result);
             Console.ReadKey();

             string resultString = AddTwoStrings("Hello", "Class");
             Console.WriteLine(resultString);
             Console.ReadKey();*/


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
            string age = "";
            string name = "";

            Console.WriteLine("What is your name?  ");
            name = Console.ReadLine();

            Console.WriteLine("How old are you?  ");
            age = Console.ReadLine();




            int futureAge = 0;
            int currentAge = int.Parse(age);

            for (int i = 0; i < 10; i++)
            {
                futureAge = currentAge + i;
                if (i == 0)
                {
                    Console.WriteLine(name + " is " + currentAge + "  years old.");
                }
                else if (i == 1)
                {
                    Console.WriteLine("In " + i + " year " + name + " will be " + futureAge + " old.");

                }
                else 
                {
                    Console.WriteLine("In " + i + " years " + name + " will be " + futureAge + " old.");

                }
                
            }
            Console.ReadKey();
        }

        static void WhatsInMyList()
        {
            List<int> numList = new List<int>();
            numList.Add(14);
            numList.Add(34);
            numList.Add(45);
            numList.Add(77);
            numList.Add(32);

            Console.WriteLine("There are " + numList.Count + " items in the list.");

            for (int i = 0; i < numList.Count; i++)
            {
                Console.WriteLine(numList[i]);

            }


            foreach(int value in numList)
            {
                Console.WriteLine(value);
            }



            List<string> nameList = new List<string>();
            nameList.Add("cary");
            nameList.Add("john");
            nameList.Add("mike");
            nameList.Add("cary");
            nameList.Add("john");
            nameList.Add("cary");
            nameList.Add("john");
            nameList.Add("mike");
            nameList.Add("mike");
            Console.WriteLine("There are " + nameList.Count + " names in the list.");

            foreach (string name in nameList)
            {
                Console.WriteLine(name);
            }





            Console.ReadKey();

        }



    }
}
