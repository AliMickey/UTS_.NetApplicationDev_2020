using System;

/* Write a program to define a Matrix class which can add two square matrices using Operator Overloading. 
The Matrix class should have constructor to accept the dimension of the matrix as user input. 
The user will then be asked to populate the matrices. The class should also have a copy constructor. 
The Matrix class should have a method to display the input matrix and matrix addition result. 
There should be a special method for ‘+’ operator overloading which takes two matrices as arguments and returns an output matrix.

The Matrix objects should be created in the class containing the main() method. Please use the below class diagram:

----------------------------------------
|    Matrix                            |
----------------------------------------
| - dimension: int                     |
| - matrix: double[]                   |
----------------------------------------
| + Matrix()                           |
| + Matrix (Mat: Matrix)               |
| + Matrix(dimension)                  |
| + operator +(Mat1, Mat2): Matrix     |
| + DisplayMatrix()                    |
| + Dimension: int // Get for dimension|
----------------------------------------

The matrix object should be initialized with constructors. 
DisplayInput(): displays the input Matrix, 
DisplayResult(): displays the result after addition.
operator+(Mat1: Matrix, Mat2: Matrix): Adds two matrix and returns the result matrix.
It should also have a accessor for dimension 
*/

namespace Week5LabProgram
{
    class Matrix
    {
        // Write code to Declare the data members
        private int dimension;
        private int[,] matrix;

        // Write/Complete the code for Default constructor
        public Matrix()
        {
            Console.Write("Enter the dimension of the Square Matrix: ");
            string userInput = Console.ReadLine(); 
            dimension = Convert.ToInt32(userInput); 
            matrix = new int[dimension, dimension];

            for (int outerLoop = 0; outerLoop < dimension; outerLoop++)
            {
                for(int innerLoop = 0; innerLoop < 2; innerLoop++)
                {
                    Console.Write("\nEnter the value of ({0}, {1})", outerLoop, innerLoop);
                    userInput = Console.ReadLine(); 
                    matrix[outerLoop, innerLoop] = Convert.ToInt32(userInput); 
                }
                Console.WriteLine();
            }
        }

        // Write code for  Overloaded constructor
         public Matrix(int dim)
        {
            this.matrix = new int [dim, dim];
            this.dimension = dim; 
        }

        // Write code for Operator Overloading 
        public static Matrix operator +(Matrix mat1, Matrix mat2)
        {
            // Write code to create tempMatrix
            Matrix tempMatrix = new Matrix(mat1.dimension);
            for (int outerLoop = 0; outerLoop < mat1.dimension; outerLoop++)
            {
                for (int innerLoop = 0; innerLoop < 2; innerLoop++)
                {
                    /*Write code to add the matix and store in a temporay matrix*/
                    tempMatrix.matrix[outerLoop, innerLoop] = mat1.matrix[outerLoop, innerLoop] + mat2.matrix[outerLoop, innerLoop];
                }
            }
            return tempMatrix;
        }

        // Write code for Method to display the matrix
        public void DisplayMatrix()
        {
            Console.WriteLine("Matrix is:");
            for (int outerLoop = 0; outerLoop< this.dimension; outerLoop++)
            {
                for (int innerLoop = 0; innerLoop < this.dimension; innerLoop++)
                {
                    Console.Write(matrix[outerLoop, innerLoop] + " ");
                }
                Console.WriteLine("");
            }
            Console.WriteLine("*************");
        }
        // Write code for the Accessor for dimension
        public int Dimension
        {
            get
            {
               return dimension;
            }
        }
    }

    // Class for main()
    class MatrixAddition
    {
        static void Main(string[] args)
        {
            // Complete the code to Create the matrices
            Matrix mat1 = new Matrix();
            Matrix mat2 = new Matrix();
            Matrix result = new Matrix(mat1.Dimension);

            // Complete the code Add Matrix 1 and 2
            result = mat1 + mat2;

            // Complete the code Display the matrices and the addition result
            Console.WriteLine("Input matrices are:");
           
            //Write code to Display the matrix
            mat1.DisplayMatrix();
           
            mat2.DisplayMatrix();

            // Write code for displaying result
            Console.WriteLine("Result matrix is:");
            result.DisplayMatrix();

            // Accept a key from the user
            Console.ReadKey();
        }
    }
}


/* Test Case: 
 
 Enter the dimension of the Square Matrix: 2

Enter the value of (0, 0)1

Enter the value of (0, 1)1

Enter the value of (1, 0)1

Enter the value of (1, 1)1

Enter the dimension of the Square Matrix: 2

Enter the value of (0, 0)2

Enter the value of (0, 1)2

Enter the value of (1, 0)2

Enter the value of (1, 1)2
Input matrices are:
Matrix is:
1 1
1 1
*************
Matrix is:
2 2
2 2
*************
Result matrix is:
Matrix is:
3 3
3 3
*************

     
     
     */
