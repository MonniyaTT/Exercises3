using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises3
{
    class Program
    {
        static void Main(string[] args)
        {
            //NameLikes();
            //NameReversed();
            //SortNum();
            //Number();
            NumberF();
        }

        static void NameLikes()
        {
            Console.Write("Enter a series of names :");
            var name = Console.ReadLine();
            var nameL = name.Split(',');
            var countName = (string.IsNullOrEmpty(nameL[0])) ? 0 : nameL.Length ;
            
            switch (countName)
            {
                case 0: Console.WriteLine("Anything");
                    break;
                case 1 : Console.WriteLine(nameL[0] + " like your post.");
                    break;
                case 2:
                    Console.WriteLine(nameL[0] + " and " + nameL[1] + " like your post.");
                    break;
                    
                default:
                    Console.WriteLine(nameL[0] + "," + nameL[1] + " and " + (countName-2) + " others like your post.");
                    break;
            }
            
        }

        static void NameReversed()
        {
            Console.Write("Your names ? : ");
            var name = Console.ReadLine();
            var nameL = name.ToArray<char>();
            Array.Reverse(nameL);
            foreach (var item in nameL)
            {
                Console.Write(item);
            }
            Console.WriteLine();
        }

        static void SortNum()
        {
            Console.Write("Your number ? : ");
            var num = Console.ReadLine();
            var numA = num.Split(' ');
            int[] numAIn = Array.ConvertAll(numA, int.Parse);
            Array.Sort(numAIn);
            foreach (var item in numAIn)
            {
                Console.Write(item+" ");
            }
            Console.WriteLine();

        }

        static void Number()
        {
            //int i = 0;
            var number = "";
            var numA = new int[] { };
            List<int> numAr = new List<int>();
            while (number != "Quit")
            {
                Console.Write("Your number ? : ");
                var num = Console.ReadLine();
                //numA[i] = Convert.ToInt32(num);
                //i++;
                numAr.Add(Int32.Parse(num));
            }
            //Distinct
            foreach (var item in numAr)
            {
                Console.Write(item + " ");
            }
            
        }

        static void NumberF()
        {
            var numA = new string[] { };
            while (numA.Length != 5)
            {
                Console.Write("Enter a series of names :");
                var name = Console.ReadLine();
                numA = name.Split(',');
                if (numA.Length != 5)
                {
                    Console.WriteLine("Invalid List");
                }
            }
            int[] numAIn = Array.ConvertAll(numA, int.Parse);
            Array.Sort(numAIn);
            foreach (var item in numAIn)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();

        }

    }
}
