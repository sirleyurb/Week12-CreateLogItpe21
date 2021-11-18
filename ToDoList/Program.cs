using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace ToDoList
{
    class Program
    {
        static void Main(string[] args)
        {
            List < string > ToDoFromFile = new List < string > ();
            string ToDoFilePath = $@"C:\Users\opilane\samples\LogITpe21\ToDoList.txt";
            ToDoFromFile = File.ReadAllLines(ToDoFilePath).ToList();

            foreach (string task in ToDoFromFile)
            {
                Console.WriteLine(task);
            }

            bool loopActive = true;

            while (loopActive)
            {
                Console.WriteLine("Would you like to add a task? Y/N");
                char userInput = Convert.ToChar(Console.ReadLine().ToLower());

                if (userInput == 'y')
                {
                    Console.WriteLine("Enter a task:");
                    string userTask = Console.ReadLine();
                    ToDoFromFile.Add(userTask);
                    Console.WriteLine($"Task {userTask} added.");
                }
                else
                {
                    Console.WriteLine("Take care!");
                    loopActive = false;
                }
            }

            File.WriteAllLines(ToDoFilePath, ToDoFromFile.ToArray());
        }
    }
}
