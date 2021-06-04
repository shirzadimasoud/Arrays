using System;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main()
        {

            //Console.Write("Enter first number =");
            //double f_num = Convert.ToDouble(Console.ReadLine());
            //Console.Write("Enter second number =");
            //double s_num = Convert.ToDouble(Console.ReadLine());
            //Console.Write("Enter third number =");
            //double t_num = Convert.ToDouble(Console.ReadLine());
            //double average = (f_num + s_num + t_num) / 3;
            //var ave = string.Format("{0:0.00}", average); // var data type ro khodesh tashkhis mide
            //Console.WriteLine($"Average is = {ave}");
            //Console.WriteLine();
            //float float_number = Convert.ToSingle(Console.ReadLine());
            //Console.WriteLine(float_number);


            // *********************************************** Shallow Copy (shortcut to main object):

            int[] arr1 = new int[] { 1, 2, 3 };
            int[] arr2 = arr1;  // By this, We copied arr1 address to arr2 and now, both will refer to one place in memory (heap)
            arr2[2] = 10000;

            for (int i = 0; i < arr1.Length; i++)
            {
                Console.WriteLine($"arr1[{i}] = {arr1[i]}");
            }
            for (int i = 0; i < arr2.Length; i++)
            {
                Console.WriteLine($"arr2[{i}] = {arr2[i]}");
            }
            Console.WriteLine();

            // *********************************************** Deep Copy:

            int[] arr3 = new int[] { 1, 2, 3 };
            int[] arr4 = arr3.Clone() as int[]; 
            arr4[2] = 10000;

            for (int i = 0; i < arr3.Length; i++)
            {
                Console.WriteLine($"arr3[{i}] = {arr3[i]}");
            }
            Console.WriteLine();
            for (int i = 0; i < arr4.Length; i++)
            {
                Console.WriteLine($"arr4[{i}] = {arr4[i]}");
            }
            Console.WriteLine();


            //*********************************************** Array Functions:

            int[] arr = new int[] { 14, 12, 11, 56, 70, 2, 97 };
            int sum = arr.Sum();    // From Linq repository
            Console.WriteLine("Sum of Array members: " + sum);
            Array.Sort(arr);
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine($"Sorted arr[{i}] : {arr[i]}");
            }
            Console.WriteLine("This Array has " + arr.Rank + " Dimension");
            Console.WriteLine($"This Array's Min value is : {arr.Min()} and Max value is : {arr.Max()}");


            //********************************************** Multi-dimensional Arrays:

            int[,] ma = new int[2, 3];
            ma[0, 0] = 10;
            ma[0, 1] = 11;
            ma[0, 2] = 12;
            ma[1, 0] = 13;
            ma[1, 1] = 14;
            ma[1, 2] = 15;

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.WriteLine(ma[i, j]);
                }
            }

            Console.WriteLine();

            int[,] mb = new int[2, 2] { { 20, 21 }, { 22, 23 } };
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.WriteLine(mb[i, j]);
                }
            }

            int[,,] mc = new int[2, 3, 2] { { { 30, 31 }, { 32, 33 }, { 34, 35 } }, { { 36, 37 }, { 38, 39 }, { 40, 41 } } };
            Console.WriteLine();
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    for (int k = 0; k < 2; k++)
                    {
                        Console.WriteLine(mc[i, j, k]);
                    }
                }
            }

            //********************************************* Jagged array

            // Jagged array is a array of arrays such that member arrays can be of different sizes.
            // In other words, the length of each array index can differ.
            int[][] jagged_array = new int[3][];
            jagged_array[0] = new int[1] { 50 };
            jagged_array[1] = new int[3] { 51, 52, 53 };
            jagged_array[2] = new int[2] { 54, 55 };

            Console.WriteLine($"The size of jagged_array is = {jagged_array.Length}");
            Console.WriteLine($"The size of jagged_array[1] is = {jagged_array[2].Length}");
            Console.WriteLine($"Get length jagged_array(0) is = {jagged_array.GetLength(0)}");

            for (int i = 0; i < jagged_array.Length; i++)
            {
                for (int j = 0; j < jagged_array[i].Length; j++)
                {
                    Console.WriteLine(jagged_array[i][j]);
                }

            }

            //*************************************** Arrays

            /*string[] names = new string[5] { "ali", "hassan", "masoud", "taghi", "arash" };

            Console.Write("Enter name to search = ");
            string name = Console.ReadLine();
            bool find = false;
            for (int i = 0; i < names.Length; i++)
            {
                if (names[i].ToLower() == name.ToLower())
                {
                    string upperCaseName = $"Name {names[i].ToUpper()} found at {i + 1} position.";
                    Console.WriteLine(upperCaseName);
                    string last_name = names[i];
                    Console.Write("Enter new Name = ");
                    names[i] = Console.ReadLine();
                    Console.WriteLine($"Name {last_name.ToUpper()} changed to {names[i].ToUpper()}");
                    
                    Console.WriteLine();
                    // Print new Names
                    for(int j=0; j < names.Length; j++)
                    {
                        Console.WriteLine(names[j]);
                    }
                    
                    find = true;
                }              
            }
            if (!find)
            {
                Console.WriteLine("Not found!");
            }
            */

            /*int[] numbers = new int[5];
            // double[] nums = new double[5] {10,11,12,13,14};
            numbers[0] = 10;
            numbers[1] = 11;
            numbers[2] = 12;
            numbers[3] = 13;
            numbers[4] = 14;

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine($"numbers{i} = {numbers[i]}");
                // اگه دلار نذاری نیازه که داخل آکولادها شماره گذاری کنی و بعد کاما بذاری و متغیرها رو ارجاع بدی
            }
            */

            /*Console.Write("Enter your Username = ");
             string user_name = Console.ReadLine();
             if (user_name == "admin")
             {
                 Console.Write("Enter Password = ");
                 string pass = Console.ReadLine();
                 if (pass == "123")
                 {
                     Console.WriteLine("Welcome to the App !");
                 }
                 else
                 {
                     Console.WriteLine("Your password is incorrect !");
                 }
             }
             else
             {
                 Console.WriteLine("User Not Found !");
             }

             //Console.Clear();
             */

        }
    }
}
