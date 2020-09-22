using System;
using System.Collections.Generic;

namespace CSharpBasics
{
    class Program
    {
        static void Main(string[] args)
        {

            //int result = AddTwoNumbers(45, 53);

            //Console.WriteLine(result);
            //Console.ReadKey();

            //string strResult = AddTwoStrings("Hello", "There");

            //Console.WriteLine(strResult);
            //Console.ReadKey(); 

            WhatMyAge();

          //  WhatsInMyList();



        }


        static int AddTwoNumbers(int num1, int num2)
        {
            int value = num1 + num2;
            return value;

        }


        static string AddTwoStrings(string str1, string str2)
        {
            string value = str1 + " " + str2;
            return value;

        }


        static void WhatMyAge()
        {
            string age = "";
            string name = "";

            Console.WriteLine("What's your name?  ");
            name = Console.ReadLine();

            Console.WriteLine("How old are you?  ");
            age = Console.ReadLine();

            


            int futureAge = 0;
            int currentAge = 0;

            currentAge = int.Parse(age);


            for (int i=0; i < 10; i++)
            {

                futureAge = currentAge + i;

                if (i == 0)
                {
                    Console.WriteLine(name + " is " + age + " years old.");
                }
                else if (i == 1)
                {
                    Console.WriteLine("In " + i + " year " + name + " will be " + futureAge + " old");
                    Console.WriteLine(string.Format("In {0} year {1} will be {2} old",i, name, futureAge));
                }
                else
                {

                    Console.WriteLine("In " + i + " years " + name + " will be " + futureAge + " old");
                }

                       

            }

            Console.ReadKey();


        }



            static void WhatsInMyList()
        {
            List<int> numList = new List<int>();

            numList.Add(34);
            numList.Add(33);
            numList.Add(342);
            numList.Add(13);
            numList.Add(334);
            numList.Add(32);

            Console.WriteLine("There are " + numList.Count + " number in the list.");
            Console.ReadKey();

            foreach(int num in numList)
            {
                Console.WriteLine(num);

            }


            for(int i= 0; i < numList.Count; i++)
            {
                Console.WriteLine(numList[i]);

            }


            Console.ReadKey();

        }




    }
}
