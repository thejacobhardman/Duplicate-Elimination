using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Duplicate_Elimination
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isRunning = true;
            int num;
            while (isRunning)
            {
                int[] numArr = new int[5] { 0, 0, 0, 0, 0 };
                for (int i = 0; i < 5; i++)
                {
                    bool validNum = false;
                    while (validNum == false)
                    {
                        Console.Write("Enter a number: ");
                        num = Convert.ToInt32(Console.ReadLine());

                        if (num >= 10 && num <= 100)
                        {
                            if (numArr.Contains(num))
                            {
                                Console.WriteLine(num + " has already been entered.");
                            }
                            else
                            {
                                numArr[i] = num;
                                validNum = true;
                            }
                        }
                        else
                        {
                            Console.WriteLine("Number must be between 10 and 100.");
                        }
                    }

                    for (int j = 0; j < 5; j++)
                    {
                        if (numArr[j] != 0)
                        {
                            Console.Write(numArr[j] + " ");
                        }
                    }
                    Console.WriteLine();
                }

                isRunning = RunProgramAgain(isRunning);

            }

            Console.WriteLine("Press any key to close the program.");
            Console.ReadKey();
        }

        static bool RunProgramAgain(bool isRunning)
        {
            bool userConfirm = false;

            string userInput;
            while (userConfirm == false)
            {
                Console.Write("Would you like to run the program again? (Y/N): ");
                userInput = Console.ReadLine();

                if (userInput == "Y" || userInput == "y")
                {
                    userConfirm = true;
                }
                else if (userInput == "N" || userInput == "n")
                {
                    userConfirm = true;
                    isRunning = false;
                }
                else
                {
                    Console.WriteLine("Please enter a valid selection.");
                }
            }

            return isRunning;
        }
    }
}
