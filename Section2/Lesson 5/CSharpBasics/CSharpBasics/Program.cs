using System;
using System.Collections.Generic;

namespace CSharpBasics
{
    class Program
    {
        static void Main(string[] args)
        {
            // int num = AddTwoNumbers(10, 30);

            //string str = AddTwoStrings("Hello", "Vito");


            //Console.WriteLine(str);
            //Console.ReadKey();

            WhatsMyAge();

            //WhatsInMyList();


        }

        static int AddTwoNumbers(int num1, int num2)
        {
            int sum = num1 + num2;
            return sum;

        }

        static string AddTwoStrings(string str1, string str2)
        {
            string newString = str1 + " " + str2;
            return newString;
        }

        static void WhatsMyAge()
        {
            string name = "";
            string age = "";

            Console.WriteLine("What is your name?");
            name = Console.ReadLine();

            Console.WriteLine("What is your age?");
            age = Console.ReadLine();

            
          

            int currentAge = Int32.Parse(age);
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
                    Console.WriteLine("In " + i + " year " + name + " will be " + futureAge + " old.");

                }
                else
                {
                    //Console.WriteLine("In " + i + " years " + name + " will be " + futureAge + " old.");

                    Console.WriteLine(string.Format("In {0} years {1} will be {2} years old.", i, name, futureAge));

                }

            }
            Console.ReadKey();

        }

        static void WhatsInMyList()
        {
            List<int> numList = new List<int>();
            numList.Add(23);
            numList.Add(44);
            numList.Add(34);
            numList.Add(67);

            Console.WriteLine("there are " + numList.Count + " numbers in the list.");
            

            for (int i = 0; i < numList.Count; i++)
            {

                Console.WriteLine(numList[i]);
                
            }

            foreach (int num in numList)
            {
                Console.WriteLine(num);
            }


            Console.ReadKey();


        }


    }
}
