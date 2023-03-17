using System;

namespace ConsoleApplication1
{

    class Program
    {
        static void Main(string[] args)
        {

            //Declare 2d massive 3x3 with randow number inserting
            int[,] myArr = new int[3, 3];

            Random ran = new Random();

            //Get size of matrix
            int rows = myArr.GetLength(0);
            int cols = myArr.GetLength(1);

            //Initialize massive 
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    myArr[i, j] = ran.Next(1, 6);


                }

            }

            //Print the original table
            Console.WriteLine("Original table:");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write("{0}\t", myArr[i, j]);
                }
                Console.WriteLine();
            }

            // Create new matrix
            int[,] newMatrix = new int[rows, cols];

            // Set elements based on original matrix
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (j < i) // below diagonal
                    {
                        newMatrix[i, j] = 0;
                    }
                    else if (j == i) // on diagonal
                    {
                        newMatrix[i, j] = myArr[i, j];
                    }
                    else // above diagonal
                    {
                        newMatrix[i, j] = 1;
                    }
                }
            }



            // Print new matrix
            Console.WriteLine("New matrix:");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write("{0}\t", newMatrix[i, j]);
                }
                Console.WriteLine();
            }

            Console.ReadLine();
        }

    }


}
