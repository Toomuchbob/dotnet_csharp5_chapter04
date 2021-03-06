using System;
using static System.Console;

namespace WritingFunctions
{
    class Program
    {
        static void TimesTable(byte number) {
            WriteLine($"This is the {number} times table:");

            for (int row = 1; row <= 12; row++) {
                WriteLine($"{row} x {number} = {row * number}");
            }
            WriteLine();
        }

        static void RunTimesTable() {
            bool isNumber;
            do {
                Write("Enter a number between 0 and 255: ");

                isNumber = byte.TryParse(ReadLine(), out byte number);

                if (isNumber) {
                    TimesTable(number);
                } else {
                    WriteLine("You did not enter a valid number!");
                }
            } while (isNumber);
        }

        static int Factorial(int number) {
            if (number < 1) {
                return 0;
            } else if (number == 1) {
                return 1;
            } else {
                checked {
                    return number * Factorial(number - 1);
                }
            }
        }

        static void RunFactorial() {
            for (int i = 1; i < 15; i++) {
                try {
                    WriteLine($"{i}! = {Factorial(i):N0}");
                } catch {
                    WriteLine($"{i}! is too big for a 32-bit integer.");
                }
            }
        }

        static void Main(string[] args) {
            //RunTimesTable();
            RunFactorial();
        }
    }
}
