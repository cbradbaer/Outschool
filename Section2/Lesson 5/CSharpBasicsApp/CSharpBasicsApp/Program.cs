using System;
using System.Collections.Generic;

namespace CSharpBasicsApp
{
    class Program
    {
        static void Main(string[] args)
        {
            /* int result = AddTwoNumber(23, 34);

              Console.WriteLine("The Answer is:  " + result);
              Console.ReadKey();

              string strResult = AddTwoStrings("Hello", "Class");

              Console.WriteLine(strResult);
              Console.ReadKey();
            */

            // WhatsMyAge();

            WhatsInMyList();

        }

        static int AddTwoNumber(int a, int b)
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

            Console.WriteLine("What's your name?");
            name = Console.ReadLine();

            Console.WriteLine("How old are you?");
            age = Console.ReadLine();

            //Console.WriteLine(name + " is " + age + " years old");
            //Console.ReadKey();

            int futureAge = 0;
            int currentAge = int.Parse(age);

            for (int i=0; i<10; i++)
            {
                futureAge = currentAge + i;
                if(i == 0)
                {
                    Console.WriteLine(name + " is " + currentAge + " years old");
                }
                else if (i == 1)
                {
                    Console.WriteLine("In " + i + " year " + name + " will be " + futureAge + " years old");
                }
                else
                {
                    Console.WriteLine("In " + i + " years " + name + " will be " + futureAge + " years old");

                }

            }

            Console.ReadKey();



        }

        static void WhatsInMyList()
        {
            List<int> numList = new List<int>();
            numList.Add(10);
            numList.Add(23);
            numList.Add(44);
            numList.Add(34);
            numList.Add(77);
            numList.Add(145);

            for (int i=0; i<numList.Count; i++)
            {
                Console.WriteLine(numList[i]);

            }

            foreach (int num in numList)
            {

                Console.WriteLine(num);
            }



            List<string> nameList = new List<string>();
            nameList.Add("cary");
            nameList.Add("john");
            nameList.Add("mike");
            nameList.Add("cary");
            nameList.Add("john");
            nameList.Add("mike");
            nameList.Add("cary");
            nameList.Add("john");
            nameList.Add("mike");
            Console.WriteLine("There are " + nameList.Count + " names in the list.");

            foreach (string name in nameList)
            {
                Console.WriteLine(name);
            }


            Console.WriteLine("Press and key to continue...");
            Console.ReadKey();


        }



    }
}
