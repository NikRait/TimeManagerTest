using System;
using System.Collections.Generic;
using System.IO;

namespace TimeManagerTest
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.Clear();
            var user = new User("/");
            var watch = new Timer();
            var listOfActs = new List<string>();
            bool isFIleNotFound = true;
            while (isFIleNotFound != false)
            {
                user.BeforeActivities(ref isFIleNotFound, listOfActs, user);
            }

            var isItNotEndOfRun = true;
            string currentActivity;
            var currentListOfActs = new List<string>();
            while (isItNotEndOfRun)
            {
                var isItNotRightAvtivity = true;
                Console.WriteLine("Which activity do you wanna do now?");
                while (isItNotRightAvtivity)
                {
                    int resultMainDecision = 0;
                    resultMainDecision = resultMainDecision.MyTryParse(Console.ReadLine());
                    {
                        try
                        {
                            currentActivity = listOfActs[--resultMainDecision];
                            currentListOfActs.Add(currentActivity);
                            watch.Activity(user, currentActivity);
                            isItNotRightAvtivity = false;
                        }
                        catch (ArgumentOutOfRangeException)
                        {
                            Console.WriteLine("You don't have this count of activities");
                        }
                    }
                }
                Console.WriteLine("Another activity - 1, Sum up - 0");
                int result = 10;
                while (result != 1)
                {
                    result = result.MyTryParse(Console.ReadLine(), 0, 1);
                    if (result == 1)
                    {
                    }
                    else
                    {
                        SumUp(currentListOfActs);
                        Console.ReadLine();
                        isItNotEndOfRun = false;
                        break;
                    }
                }
            }
        }
        private static void SumUp(List<string> currentListOfActs)
        {
            var repeatList = new List<string>();
            int index = 0;
            for (int i = 0; i < currentListOfActs.Count; i++)
            {
                var repeat = false;
                foreach (var item in repeatList)
                {
                    if (item == currentListOfActs[i])
                    {
                        repeat = true;
                    }
                    else if (repeat == true)
                    {

                    }
                    else
                        repeat = false;
                }
                repeatList.Add(currentListOfActs[i]);
                if (repeat == false)
                {
                    Console.WriteLine($"By {currentListOfActs[i]} you have spent {Timer.listOfWatches[index].Elapsed:hh\\:mm\\:ss\\:ff}");
                    index++;
                }
                else
                {
                    continue;
                }
            }
        }
    }
}