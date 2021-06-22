// using directive. keeps us from having to say System.Console.WriteLine
// and put the namespace in front of all the classes we take from it
//using System;

//string name;
//name = "User";
//Console.WriteLine("Hi " + name);

//Console.WriteLine("Bread is ready.");
//Console.WriteLine("Who is the bread for?");
//string breadRecipient;
//breadRecipient = Console.ReadLine();
//Console.WriteLine("Noted: " + breadRecipient + " got bread.");

//char hexB = '\u0042';
//char hexA = '\u0041';
//char hexR = '\u0052';
//char hexE = '\u0045';
//char hexN = '\u004E';
//char hexT = '\u0054';
//Console.WriteLine(hexB);
//Console.WriteLine(hexA);
//Console.WriteLine(hexR);
//Console.WriteLine(hexE);
//Console.WriteLine(hexN);
//Console.WriteLine(hexT);

//double number1 = 3.5621;
//float number2 = 3.5621f;
//decimal number3 = 3.5623m;

//Console.WriteLine(number3);
//Console.WriteLine(number1);
//Console.WriteLine(number2);


/* Variable Shoppe */

// Integral Types
//byte byteNum = 23; // bytes can only be positive
//sbyte sByteNum = -23; // sbyte for negative

//short shortNum = -19000; // allow negatives
//ushort ushortNum = 65000; // no negatives

//int negativeInt = -2147000000; // ints can be negative
//uint fourBillion = 4000000000;
//int binaryLiteral = 0b00001101;
//int hexLiteral = 0xFF00FF;

//long negativeNineQuadrillion = -9000000000000000;
//ulong eighteenQuintrillion = 18000000000000000000; // no negatives

//char sigma = '\u03FE';
//string firstName = "Kimbler";

//double myDouble = 1.0001; 
//float myFloat = 1.0001f;
//decimal myDec = 1.0001m;

//bool allTypes = true;

//Console.WriteLine(byteNum);
//Console.WriteLine(sByteNum);
//Console.WriteLine(shortNum);
//Console.WriteLine(ushortNum);

//Console.WriteLine(negativeInt);
//Console.WriteLine(fourBillion);
//Console.WriteLine(binaryLiteral);
//Console.WriteLine(hexLiteral);

//Console.WriteLine(negativeNineQuadrillion);
//Console.WriteLine(eighteenQuintrillion);

//Console.WriteLine(sigma);
//Console.WriteLine(firstName);
//Console.WriteLine(myDouble);
//Console.WriteLine(myFloat);
//Console.WriteLine(myDec);
////Console.WriteLine(allTypes);

//var message = "Hello this is type inference!";
//Console.WriteLine(message);

//Console.Write("What be yer favorite numbor?\n");
//string favoriteNumberText = Console.ReadLine();
//int favoriteNumber = Convert.ToInt32(favoriteNumberText);

//Console.WriteLine(favoriteNumber + " is a great number!\n");
//Console.WriteLine((favoriteNumber + 10) + " is " + favoriteNumber + " plus 10 :o");

//int anInt = 258;
//byte aByte = (byte)anInt;
//Console.WriteLine(aByte);

//Console.ForegroundColor = ConsoleColor.Green;

//Console.WriteLine("Press any key to begin");
//Console.ReadKey(true);
//Console.WriteLine("Process run!");

//string interpolation = "interpolation";

//Console.WriteLine($"This is string {interpolation} in C#");

//int menuChoice = 3;

//switch (menuChoice)
//{
//    case 1:
//        Console.WriteLine("You chose 1");
//        break;
//    case 2:
//        Console.WriteLine("You chose 2");
//        break;
//    case 3:
//        Console.WriteLine("I can't believe you chose 3");
//        break;
//}


// Fizzbuzz
//for (int i = 0; i < 100; ++i)
//{
//    if (i % 3 == 0 && i % 5 == 0) Console.WriteLine("FizzBuzz");
//    else if (i % 3 == 0) Console.WriteLine("Fizz");
//    else if (i % 5 == 0) Console.WriteLine("Buzz");
//    else Console.WriteLine(i);
//}

//for (int i = 0; i < 10; i++)
//{
//    for (int j = 0; j < i; j++)
//    {
//        Console.Write("*");
//    }
//    Console.WriteLine();
//}


// Arrays
//int[] numArray;
//numArray = new int[10];

// OR

//int[] scores = new int[] { 1, 2, 3, 4, 5 };
//int firstScore = scores[0];

//int arrayIndeces = scores.Length;
//Console.WriteLine($"Number of items in array => {arrayIndeces}");
//foreach (int score in scores) Console.WriteLine(score);

// Find min value in an array
//int[] minValArray = new int[] { 4, 51, -7, 13, -99, 15, -8, 45, 90, -100 };

//int currentMinimum = Int32.MaxValue;

//for (int index = 0; index < minValArray.Length; index++)
//{
//    if (minValArray[index] < currentMinimum)
//        currentMinimum = minValArray[index];
//}
//Console.WriteLine($"Current Minimum => {currentMinimum}");

//int[] averageValArray = new int[] { 4, 51, -7, 13, -99, 15, -8, 45, 90, -100 };
//int total = 0;

//for (int idx = 0; idx < averageValArray.Length; idx++)
//{
//    total += averageValArray[idx];
//}
//float average = (float)total / averageValArray.Length;
//Console.WriteLine(average);

//int[] arrayToCopy = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };
//int[] secondArray = new int[arrayToCopy.Length];

//for (int i = 0; i < arrayToCopy.Length; i++)
//{
//    secondArray[i] = arrayToCopy[i];
//}
//Console.WriteLine("Initial Array => ");
//foreach (int item in arrayToCopy) Console.Write(item);
//Console.WriteLine("\nCopied Array =>");
//foreach (int item in secondArray) Console.Write(item);

//int[] minValArray = new int[] { 4, 51, -7, 13, -99, 15, -8, 45, 90, -100 };
//int currentMinNum = Int32.MaxValue;
//foreach(int value in minValArray)
//{
//    if (value < currentMinNum)
//        currentMinNum = value;
//}
//Console.WriteLine($"Min Value in Array {currentMinNum}");

//int[] averageValArray = new int[] { 4, 51, -7, 13, -99, 15, -8, 45, 90 };
//int averageValTotal = 0;

//foreach(int val in averageValArray)
//{
//    averageValTotal += val;
//}

//float average = (float)averageValTotal / averageValArray.Length;
//Console.WriteLine($"Average Value => {average}");


//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Enumerations
//{
//    enum DaysOfWeek { Sunday, Monday, Tuesday, Wednesday, Thursday, Friday, Saturday };

//    public class Program
//    {
//        static void Main(string[] args)
//        {
//            DaysOfWeek today;
//            today = DaysOfWeek.Saturday;
//            Console.WriteLine(today);
//        }
//    }
//}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    public class Program
    {
        static void Main(string[] args)
        {
            //int[] numbers = GenerateNumbers(10);
            //int[] reversedArray = ArrayReverse(numbers);
            //PrintNumbers(reversedArray);
            Console.WriteLine(Multiply(2, 4));
            Console.WriteLine(Multiply(2, 4, 2));
            Console.WriteLine(Fibonacci(8));

            //for (int i = 0; i < 11; i++)
            //{
            //    Console.WriteLine(Fibonacci(i));
            //}
        }

        static int[] GenerateNumbers(int arrayLength)
        {
            int[] numbersArray = Enumerable.Range(1, arrayLength).ToArray();
            return numbersArray;
        }

        static int[] ArrayReverse(int[] arrayToReverse)
        {
            int[] reversedArray;
            reversedArray = new int[arrayToReverse.Length];

            for (int i = 0; i <= arrayToReverse.Length; i++)
            {
                int reverseIndex = arrayToReverse.Length - i - 1;
                reversedArray[i] = arrayToReverse[reverseIndex];
            }
            return reversedArray;
        }
        static void PrintNumbers(int[] numbers)
        {
            foreach (int num in numbers) Console.WriteLine(num);
        }


        /// <summary>
        /// Takes two numbers, multiplies them together, and returns the result
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        /// <returns></returns>
        static int Multiply(int num1, int num2)
        {
            return num1 * num2;
        }
        static int Multiply(int num1, int num2, int num3)
        {
            return num1 * num2 * num3;
        }

        static int Fibonacci(int number)
        {
            if (number == 1 || number == 2)
            {
                return number;
            }
            else
            {
                // we need to add the current number with the previous
                return Fibonacci(number - 1) + Fibonacci(number - 2);

            }

        }
    }
}
