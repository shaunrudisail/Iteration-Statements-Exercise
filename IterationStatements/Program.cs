namespace IterationStatements
{
    public class Program
    {
        // LukeWarm Section: Implement the following methods        
        // 1. Write a method that prints all numbers from 1000 down to -1000 to the console.
        //    - Method Signature: void PrintNumbers()

        public static void PrintNumbers()
        {
            for (int i = 1000; i >= -1000; i--)
            {
                Console.WriteLine(i);
            }
        }

        // 2. Write a method that prints every third number from 3 to 999 to the console.
        //    - Method Signature: void PrintEveryThirdNumber()

        public static void PrintEveryThirdNumber()
        {
            for (int i = 3; i <= 999; i += 3)
            {
                Console.WriteLine(i);
            }
        }

        // 3. Write a method that accepts two integers as parameters and checks whether they are equal.
        //    - Method Signature: bool AreNumbersEqual(int num1, int num2)
        //    - Returns true if the numbers are equal, false otherwise.

        public static bool AreNumbersEqual(string userInput1, string userInput2)
        {
            if (userInput1 == userInput2)
            {
                return true;

            }
            else
            {
                return false;
            }

        }

        // 4. Write a method that checks if a given number is even or odd.
        //    - Method Signature: bool IsEven(int number)
        //    - Returns true if the number is even, false if odd.

        public static bool IsEven(int evenOddNumber)
        {
            if (evenOddNumber % 2 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        // 5. Write a method that checks if a given number is positive or negative.
        //    - Method Signature: bool IsPositive(int number)
        //    - Returns true if the number is positive, false if negative.

        public static bool IsPositive(int posNegNumber)
        {
            if (posNegNumber >= -1000 && posNegNumber < 0)
            {
                Console.WriteLine("This number is negative!");
                return true;
            }
            
            else if (posNegNumber <= 1000 && posNegNumber >= 0)
            {
                Console.WriteLine("This number is positive!");
                return true;
            }
            
            else
            {
                Console.WriteLine("This number is not in range!");
                return false;
            }
        }

        // 6. Write a method that reads the age of a candidate and determines if they are eligible to vote.
        //    - Method Signature: bool CanVote(int age)
        //    - Returns true if the candidate can vote, false otherwise.
        //    - Hint: Use `int.Parse()` or the safer `int.TryParse()` for extra practice in handling user input.

        public static bool CanVote(int voteAge)
        {
            if (voteAge > 17 && voteAge <= 120)
            {
                Console.WriteLine("You are old enough to vote!");
                return true;
            }
            else if (voteAge <= 17 && voteAge > 0)
            {
                Console.WriteLine("Sorry! You are not old enough to vote yet!");
                return true;
            }
            else
            {
                Console.WriteLine("Please enter a valid age!");
                return false;
            }
        }

        // Heatin' Up Section:
        // 1. Write a method that checks if an integer (provided by the user) is within the range of -10 to 10.
        //    - Method Signature: bool IsInRange(int number)
        //    - Returns true if the number is within the range, false otherwise.

        public static bool IsInRange(int rangeNum)
        {
            if (rangeNum >= -10 && rangeNum <= 10)
            {
                Console.WriteLine("This number is in the range of -10 to +10.");
                return true;
            }
            else
            {
                Console.WriteLine("This number is not in the range of -10 to +10.");
                return false;
            }
        }

        // 2. Write a method that displays the multiplication table (from 1 to 12) for a given integer.
        //    - Method Signature: void DisplayMultiplicationTable(int number)
        //    - Should print each line in the format: "1 * number = result"

        public static void DisplayMultiplicationTable(int mulNum)
        {
            Console.WriteLine($"Multiplication Table for {mulNum}:");
            for (int i = 1; i <= 12; i++)
            {
                int result = mulNum * i;
                Console.WriteLine($"{i} x {mulNum} = {result}");
            }
        }
        
        // In the Main method below, call each of your methods to test them.
            // Use various test cases to ensure they work as expected.        

            static void Main(string[] args)
            {
                PrintNumbers();

                PrintEveryThirdNumber();


                Console.WriteLine("Choose 2 numbers that are equal to each other:");
                string userInput1 = Console.ReadLine();
                string userInput2 = Console.ReadLine();

                bool isValid = AreNumbersEqual(userInput1, userInput2);
                if (isValid)
                {
                    Console.WriteLine("These numbers are equal!");
                }
                else
                {
                    Console.WriteLine("These numbers are not equal!");
                }


                Console.WriteLine("Pick a number and I will tell you if it is even or odd:");
                string evenUserInput = Console.ReadLine();
                int.TryParse(evenUserInput, out int evenOddNumber);

                bool isEven = IsEven(evenOddNumber);
                if (isEven)
                {
                    Console.WriteLine("This number is even!");
                }
                else
                {
                    Console.WriteLine("This number is odd!");
                }

                Console.WriteLine("Please enter a number between -1000 and 1000:");
                string userPosNegInput = Console.ReadLine();
                int.TryParse(userPosNegInput, out int posNegNumber);

                bool isPos = IsPositive(posNegNumber);


                Console.WriteLine("Please enter your age and I will determine whether you are old enough to vote or not!");
                string userAgeInput = Console.ReadLine();
                int.TryParse(userAgeInput, out int voteAge);

                bool isOldEnough = CanVote(voteAge);


                Console.WriteLine("Please enter a number:");
                string rangeUserInput = Console.ReadLine();
                int.TryParse(rangeUserInput, out int rangeNum);

                bool inRange = IsInRange(rangeNum);



                Console.WriteLine("Please enter a number and I will display that number's multiplication table 1 through 12!");
                string mulUserInput = Console.ReadLine();

                if (int.TryParse(mulUserInput, out int mulNum))
                {
                    DisplayMultiplicationTable(mulNum);
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid number!");
                }
            }
        }
    }
