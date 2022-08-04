using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            program.ExerciseOne();

            Console.WriteLine("Enter numbers you would like to add seperated by space");
            
            string input = Console.ReadLine();
            string[] arr = input.Split(" ");
            int[] numArr = new int[arr.Length];
            
            for (int i = 0; i < arr.Length; i++)
            {
                numArr[i] = int.Parse(arr[i]);
            }
            
            Console.WriteLine(program.ExerciseTwo(numArr));

        }

        public void ExerciseOne() 
        {
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();
            Console.WriteLine("Waht is your favorit color?");
            string color = Console.ReadLine();
            Console.WriteLine("Waht is your favorit animal?");
            string animal = Console.ReadLine();
            Console.WriteLine("Waht is your favorit Band?");
            string band = Console.ReadLine();

            Console.WriteLine($"{name} likes listening to his favorite band({band}) with his {color} {animal}");

        }

        public int ExerciseTwo(params int[] list)
        {
            int sum = 0;
            for (int i = 0; i < list.Length; i++)
            {

                sum += list[i];
            }
            return sum;
        }
    }
}