using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StupideSunday
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person Person1 = new Person();

            Person1.name = "John Doe";
            Person1.age = 25;
            Person1.gender = "Male";

            Console.WriteLine(Person1.ToString());

            int[] numbers = new int[6];
            int countDouble1 = 0, count0 = 0, countDoubleBigger3 = 0;

            for (int i = 0; i < 100; i++)
            {
                for (int k = 0; k < 6; k++)
                {
                    Console.WriteLine("Enter a number");
                    numbers[k] = int.Parse(Console.ReadLine());
                }
                countDouble1 = check(numbers);
                Console.WriteLine("There is a sequence of " + countDouble1);
                if (countDouble1 == 0)
                    count0++;
                else if (countDouble1 >= 3)
                    countDoubleBigger3++;
            }
            Console.WriteLine("There are " + countDoubleBigger3 + " arrays with a sequence bigger then 2");
            Console.WriteLine("There are " + count0 + " arrays with a sequence equal then 0");
        }
        static string pswd(string gender, int month, string name)
        {
            string NewPassword = "";

            int genderNum = 11;

            if (gender == "male")
                genderNum = 22;

            NewPassword += genderNum + name[0];

            if (month < 10)
                NewPassword += "0";

            NewPassword += month;

            return NewPassword;
        }
        static void AccountArray(int NumberOFCostumers)
        {
            string[] Passwords = new string[NumberOFCostumers];

            string gender, name;
            int month;

            for (int i = 0; i < NumberOFCostumers; i++)
            {
                Console.WriteLine("please enter your gender");
                gender = Console.ReadLine();

                Console.WriteLine("please enter your month of birth");
                month = int.Parse(Console.ReadLine());

                Console.WriteLine("please enter your name");
                name = Console.ReadLine();

                Passwords[i] = pswd(gender, month, name);
            }
        }
        static int check(int[] numbers)
        {
            int CountDouble = 1;
            for (int m = 0; m < 6; m++)
            {
                if (numbers[m] % 2 == 0 && numbers[m + 1] % 2 == 0)
                {
                    CountDouble++;
                }
                else if (CountDouble > 1 && numbers[m] % 2 == 0 && numbers[m + 1] % 2 != 0)
                    break;
            }
            if (CountDouble == 1)
                return 0;
            else
                return CountDouble;
        }
    }
    class Person
    {
        public string name;
        public int age;
        public string gender;

        public string ToString()
        {
            return "name:" + name + "\nage:" + age + "\ngender:" + gender;
        }
    }
}
