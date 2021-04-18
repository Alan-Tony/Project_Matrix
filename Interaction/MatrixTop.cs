
using System;
using System.Numerics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MatrixFunctions;

namespace ProgramTop
{
    class MatrixTop
    {
        static void DisplayMat(double[,] mat, int r, int c)
        {
            int i, j;
            for(i=0; i<r; i++)
            {
                Console.Write("\n");
                for (j = 0; j < c; j++)
                    Console.Write(mat[i, j] + " ");
            }
        }

        static void ComplexDisplayMat(Complex[,] mat, int r, int c)
        {
            int i, j;
            for (i = 0; i < r; i++)
            {
                Console.Write("\n");
                for (j = 0; j < c; j++)
                    Console.Write(mat[i, j] + "  ");
            }
        }
        static void InpMat(ref double[,] mat, int r, int c)
        {
            int i, j;

            for(i=0; i<r; i++)
            {
                Console.WriteLine("\nRow no. {0}", (i + 1));
                for(j=0; j<c; j++)
                {
                    double.TryParse(Console.ReadLine(), out mat[i,j]);
                }
            }
            
        }

        static void ComplexInpMat(ref Complex[,] mat, int r, int c)
        {
            int i, j;
            double x, y;

            for(i=0; i<r; i++)
            {
                Console.WriteLine("\nRow no. {0}", (i + 1));
                for(j=0; j<c; j++)
                {
                    Console.Write("\nReal Part:");
                    double.TryParse(Console.ReadLine(), out x);
                    Console.Write("Imaginary Part:");
                    double.TryParse(Console.ReadLine(), out y);
                    mat[i, j] = new Complex(x, y);
                }
            }

        }
        static void AddMat()
        {
            matrix mat1, mat2, mat3;
            int r,c;
            Console.WriteLine("Enter number of rows of matrices:");
            int.TryParse(Console.ReadLine(), out r);
            mat2.r = mat3.r = mat1.r=r;

            Console.WriteLine("Enter number of columns of matrices:");
            int.TryParse(Console.ReadLine(), out c);
            mat2.c = mat3.c = mat1.c = c;

            mat1.mat = new double[r, c];
            mat2.mat = new double[r, c];
            mat3.mat = new double[r, c];
            Console.WriteLine("Enter elements of the first matrix:");
            InpMat(ref mat1.mat, r, c);

            Console.WriteLine("Enter elements of the second matrix:");
            InpMat(ref mat2.mat, r, c);

            Console.WriteLine("\nEntered Matrices:");

            Console.WriteLine("Matrix 1:");
            DisplayMat(mat1.mat, r, c);

            Console.WriteLine("\nMatrix 2:");
            DisplayMat(mat2.mat, r, c);

            mat3 = MatrixOps.Add(mat1, mat2);
            Console.WriteLine("\nSum Matrix:");

            DisplayMat(mat3.mat, r, c);

        }

        static void ComplexAddMat()
        {
            ComplexMatrix mat1, mat2, mat3;
            int r, c;
            Console.WriteLine("Enter number of rows of matrices:");
            int.TryParse(Console.ReadLine(), out r);
            mat2.r = mat3.r = mat1.r = r;

            Console.WriteLine("Enter number of columns of matrices:");
            int.TryParse(Console.ReadLine(), out c);
            mat2.c = mat3.c = mat1.c = c;

            mat1.mat = new Complex[r, c];
            mat2.mat = new Complex[r, c];
            mat3.mat = new Complex[r, c];
            Console.WriteLine("Enter elements of the first matrix:");
            ComplexInpMat(ref mat1.mat, r, c);

            Console.WriteLine("Enter elements of the second matrix:");
            ComplexInpMat(ref mat2.mat, r, c);

            Console.WriteLine("\nEntered Matrices:");

            Console.WriteLine("Matrix 1:");
            ComplexDisplayMat(mat1.mat, r, c);

            Console.WriteLine("\nMatrix 2:");
            ComplexDisplayMat(mat2.mat, r, c);

            mat3 = MatrixOps.ComplexAdd(mat1, mat2);
            Console.WriteLine("\nSum Matrix:");

            ComplexDisplayMat(mat3.mat, r, c);
        }

        static void SubMat()
        {
            matrix mat1, mat2, mat3;
            int r, c;
            Console.WriteLine("Enter number of rows of matrices:");
            int.TryParse(Console.ReadLine(), out r);
            mat1.r = mat2.r = mat3.r = r;

            Console.WriteLine("Enter number of columns of matrices:");
            int.TryParse(Console.ReadLine(), out c);
            mat1.c = mat2.c = mat3.c = c;

            mat1.mat = new double[r, c];
            mat2.mat = new double[r, c];
            mat3.mat = new double[r, c];

            Console.WriteLine("Enter elements of the first matrix:");
            InpMat(ref mat1.mat, r, c);

            Console.WriteLine("Enter elements of the second matrix:");
            InpMat(ref mat2.mat, r, c);

            Console.WriteLine("\nEntered Matrices:");

            Console.WriteLine("Matrix 1:");
            DisplayMat(mat1.mat, r, c);

            Console.WriteLine("\nMatrix 2:");
            DisplayMat(mat2.mat, r, c);

            mat3 = MatrixOps.Subtract(mat1, mat2);
            Console.WriteLine("\nMatrix1 - Matrix2:");
            DisplayMat(mat3.mat, r, c);

        }

        static void ComplexSubMat()
        {
            ComplexMatrix mat1, mat2, mat3;
            int r, c;
            Console.WriteLine("Enter number of rows of matrices:");
            int.TryParse(Console.ReadLine(), out r);
            mat2.r = mat3.r = mat1.r = r;

            Console.WriteLine("Enter number of columns of matrices:");
            int.TryParse(Console.ReadLine(), out c);
            mat2.c = mat3.c = mat1.c = c;

            mat1.mat = new Complex[r, c];
            mat2.mat = new Complex[r, c];
            mat3.mat = new Complex[r, c];
            Console.WriteLine("Enter elements of the first matrix:");
            ComplexInpMat(ref mat1.mat, r, c);

            Console.WriteLine("Enter elements of the second matrix:");
            ComplexInpMat(ref mat2.mat, r, c);

            Console.WriteLine("\nEntered Matrices:");

            Console.WriteLine("Matrix 1:");
            ComplexDisplayMat(mat1.mat, r, c);

            Console.WriteLine("\nMatrix 2:");
            ComplexDisplayMat(mat2.mat, r, c);

            mat3 = MatrixOps.ComplexSubtract(mat1, mat2);
            Console.WriteLine("\nMatrix 1 - Matrix 2:");

            ComplexDisplayMat(mat3.mat, r, c);
        }

        static void MultiplyNumber()
        {
            int r, c;
            double con;
            matrix mat1, mat2;

            Console.Write("Enter the number of rows of matrix:");
            int.TryParse(Console.ReadLine(), out r);
            mat1.r = mat2.r= r;

            Console.Write("Enter the number of columns of matrix:");
            int.TryParse(Console.ReadLine(), out c);
            mat1.c = mat2.c = c;

            mat1.mat = new double[r, c];
            mat2.mat = new double[r, c];


            Console.WriteLine("Enter the elements of the matrix:");
            InpMat(ref mat1.mat, r, c);

            Console.Write("\nEntered matrix:");
            DisplayMat(mat1.mat, r, c);

            Console.Write("\nEnter constant to be multiplied:");
            double.TryParse(Console.ReadLine(), out con);

            mat2 = MatrixOps.MultNum(mat1, con);

            Console.Write("Resultant Matrix:");
            DisplayMat(mat2.mat, r, c);

        }

        static void ComplexMultiplyNumber()
        {
            int r, c;
            double x, y;
            Complex con;
            ComplexMatrix mat1, mat2;

            Console.Write("Enter the number of rows of matrix:");
            int.TryParse(Console.ReadLine(), out r);
            mat1.r = mat2.r = r;

            Console.Write("Enter the number of columns of matrix:");
            int.TryParse(Console.ReadLine(), out c);
            mat1.c = mat2.c = c;

            mat1.mat = new Complex[r, c];
            mat2.mat = new Complex[r, c];


            Console.WriteLine("Enter the elements of the matrix:");
            ComplexInpMat(ref mat1.mat, r, c);

            Console.Write("\nEntered matrix:");
            ComplexDisplayMat(mat1.mat, r, c);

            Console.Write("\nEnter a complex number to be multiplied:");
            Console.Write("\nReal Part:");
            double.TryParse(Console.ReadLine(), out x);
            Console.Write("\nImaginary Part:");
            double.TryParse(Console.ReadLine(), out y);
            con = new Complex(x, y);

            mat2 = MatrixOps.ComplexMultNum(mat1, con);

            Console.Write("Resultant Matrix:");
            ComplexDisplayMat(mat2.mat, r, c);
        }

        static void MultiplyMatrix()
        {
            matrix mat1, mat2, mat3;

            Console.Write("\nEnter the number of rows of matrix 1:");
            int.TryParse(Console.ReadLine(), out mat1.r);
            Console.Write("\nEnter the number of columns of matrix 1:");
            int.TryParse(Console.ReadLine(), out mat1.c);
            mat1.mat = new double[mat1.r, mat1.c];

            Console.Write("\nEnter the number of rows of matrix 2:");
            int.TryParse(Console.ReadLine(), out mat2.r);
            Console.Write("\nEnter the number of columns of matrix 2:");
            int.TryParse(Console.ReadLine(), out mat2.c);
            mat2.mat = new double[mat2.r, mat2.c];

            Console.Write("\nEnter the elements of matrix 1:");
            InpMat(ref mat1.mat, mat1.r, mat1.c);

            Console.Write("\nEnter the elements of matrix 2:");
            InpMat(ref mat2.mat, mat2.r, mat2.c);

            Console.Write("\nThe entered matrices:");

            Console.Write("\nMatrix 1:");
            DisplayMat(mat1.mat, mat1.r, mat1.c);

            Console.Write("\nMatrix 2:");
            DisplayMat(mat2.mat, mat2.r, mat2.c);

            if (mat1.c == mat2.r)
            {
                mat3 = MatrixOps.MatMult(mat1, mat2);

                Console.Write("\nProduct of matrices:");
                DisplayMat(mat3.mat, mat3.r, mat3.c);
            }
            else
                Console.Write("\nEntered matrices not compatible for multiplication");

        }

        static void ComplexMultiplyMatrix()
        {
            ComplexMatrix mat1, mat2, mat3;

            Console.Write("\nEnter the number of rows of matrix 1:");
            int.TryParse(Console.ReadLine(), out mat1.r);
            Console.Write("\nEnter the number of columns of matrix 1:");
            int.TryParse(Console.ReadLine(), out mat1.c);
            mat1.mat = new Complex[mat1.r, mat1.c];

            Console.Write("\nEnter the number of rows of matrix 2:");
            int.TryParse(Console.ReadLine(), out mat2.r);
            Console.Write("\nEnter the number of columns of matrix 2:");
            int.TryParse(Console.ReadLine(), out mat2.c);
            mat2.mat = new Complex[mat2.r, mat2.c];

            Console.Write("\nEnter the elements of matrix 1:");
            ComplexInpMat(ref mat1.mat, mat1.r, mat1.c);

            Console.Write("\nEnter the elements of matrix 2:");
            ComplexInpMat(ref mat2.mat, mat2.r, mat2.c);

            Console.Write("\nThe entered matrices:");

            Console.Write("\nMatrix 1:");
            ComplexDisplayMat(mat1.mat, mat1.r, mat1.c);

            Console.Write("\nMatrix 2:");
            ComplexDisplayMat(mat2.mat, mat2.r, mat2.c);

            if (mat1.c == mat2.r)
            {
                mat3 = MatrixOps.ComplexMatMult(mat1, mat2);

                Console.Write("\nProduct of matrices:");
                ComplexDisplayMat(mat3.mat, mat3.r, mat3.c);
            }
            else
                Console.Write("\nEntered matrices not compatible for multiplication");

        }

        static void MatrixTranspose()
        {
            matrix mat1, mat2;
            Console.Write("\nEnter the number of rows of matrix:");
            int.TryParse(Console.ReadLine(), out mat1.r);

            Console.Write("\nEnter the number of colummns of matrix:");
            int.TryParse(Console.ReadLine(), out mat1.c);

            mat1.mat = new double[mat1.r, mat1.c];

            Console.Write("\nEnter elements of matrix:");
            InpMat(ref mat1.mat, mat1.r, mat1.c);

            Console.Write("\nEntered matrix:");
            DisplayMat(mat1.mat, mat1.r, mat1.c);

            mat2 = MatrixOps.Transpose(mat1);

            Console.Write("\nTranspose of matrix:");
            DisplayMat(mat2.mat, mat2.r, mat2.c);

        }

        static void ComplexMatrixTranspose()
        {
            ComplexMatrix mat1, mat2;
            Console.Write("\nEnter the number of rows of matrix:");
            int.TryParse(Console.ReadLine(), out mat1.r);

            Console.Write("\nEnter the number of colummns of matrix:");
            int.TryParse(Console.ReadLine(), out mat1.c);

            mat1.mat = new Complex[mat1.r, mat1.c];

            Console.Write("\nEnter elements of matrix:");
            ComplexInpMat(ref mat1.mat, mat1.r, mat1.c);

            Console.Write("\nEntered matrix:");
            ComplexDisplayMat(mat1.mat, mat1.r, mat1.c);

            mat2 = MatrixOps.ComplexTranspose(mat1);

            Console.Write("\nTranspose of matrix:");
            ComplexDisplayMat(mat2.mat, mat2.r, mat2.c);

        }

        static void MatrixDeterminant()
        {
            matrix mat1;
            double det;

            Console.Write("\nEnter the number of size(no. of rows/columns) of a square matrix:");
            int.TryParse(Console.ReadLine(), out mat1.r);
            mat1.c = mat1.r;

            mat1.mat = new double[mat1.r, mat1.c];

            Console.Write("\nEnter elements of matrix:");
            InpMat(ref mat1.mat, mat1.r, mat1.c);

            Console.Write("\nEntered matrix:");
            DisplayMat(mat1.mat, mat1.r, mat1.c);

            det = MatrixOps.Determinant(mat1);
            Console.Write("\nDeterminant of the entered matrix = {0}", det);

        }

        static void ComplexMatrixDeterminant()
        {
            ComplexMatrix mat1;
            Complex det;

            Console.Write("\nEnter the number of size(no. of rows/columns) of a square matrix:");
            int.TryParse(Console.ReadLine(), out mat1.r);
            mat1.c = mat1.r;

            mat1.mat = new Complex[mat1.r, mat1.c];

            Console.Write("\nEnter elements of matrix:");
            ComplexInpMat(ref mat1.mat, mat1.r, mat1.c);

            Console.Write("\nEntered matrix:");
            ComplexDisplayMat(mat1.mat, mat1.r, mat1.c);

            det = MatrixOps.ComplexDeterminant(mat1);
            Console.Write("\nDeterminant of the entered matrix = {0}", det);

        }

        static void AdjointMatrix()
        {
            matrix mat1, mat2;

            Console.Write("\nEnter the number of size(no. of rows/columns) of a square matrix:");
            int.TryParse(Console.ReadLine(), out mat1.r);
            mat1.c = mat2.r = mat2.c = mat1.r;

            mat1.mat = new double[mat1.r, mat1.c];
            mat2.mat = new double[mat2.r, mat2.c];

            Console.Write("\nEnter elements of matrix:");
            InpMat(ref mat1.mat, mat1.r, mat1.c);

            Console.Write("\nEntered matrix:");
            DisplayMat(mat1.mat, mat1.r, mat1.c);

            mat2 = MatrixOps.Adjoint(mat1);

            Console.Write("\nAdjoint of entered matrix:");
            DisplayMat(mat2.mat, mat2.r, mat2.c);

        }

        static void ComplexAdjointMatrix()
        {
            ComplexMatrix mat1, mat2;

            Console.Write("\nEnter the number of size(no. of rows/columns) of a square matrix:");
            int.TryParse(Console.ReadLine(), out mat1.r);
            mat1.c = mat2.r = mat2.c = mat1.r;

            mat1.mat = new Complex[mat1.r, mat1.c];
            mat2.mat = new Complex[mat2.r, mat2.c];

            Console.Write("\nEnter elements of matrix:");
            ComplexInpMat(ref mat1.mat, mat1.r, mat1.c);

            Console.Write("\nEntered matrix:");
            ComplexDisplayMat(mat1.mat, mat1.r, mat1.c);

            mat2 = MatrixOps.ComplexAdjoint(mat1);

            Console.Write("\nAdjoint of entered matrix:");
            ComplexDisplayMat(mat2.mat, mat2.r, mat2.c);

        }

        static void InverseMatrix()
        {
            matrix mat1, mat2;

            Console.Write("\nEnter the number of size(no. of rows/columns) of a square matrix:");
            int.TryParse(Console.ReadLine(), out mat1.r);
            mat1.c = mat2.r = mat2.c = mat1.r;

            mat1.mat = new double[mat1.r, mat1.c];
            mat2.mat = new double[mat2.r, mat2.c];

            Console.Write("\nEnter elements of matrix:");
            InpMat(ref mat1.mat, mat1.r, mat1.c);

            Console.Write("\nEntered matrix:");
            DisplayMat(mat1.mat, mat1.r, mat1.c);

            mat2 = MatrixOps.Inverse(mat1);

            Console.Write("\nInverse of entered matrix:");
            DisplayMat(mat2.mat, mat2.r, mat2.c);
        }

        static void ComplexInverseMatrix()
        {
            ComplexMatrix mat1, mat2;

            Console.Write("\nEnter the number of size(no. of rows/columns) of a square matrix:");
            int.TryParse(Console.ReadLine(), out mat1.r);
            mat1.c = mat2.r = mat2.c = mat1.r;

            mat1.mat = new Complex[mat1.r, mat1.c];
            mat2.mat = new Complex[mat2.r, mat2.c];

            Console.Write("\nEnter elements of matrix:");
            ComplexInpMat(ref mat1.mat, mat1.r, mat1.c);

            Console.Write("\nEntered matrix:");
            ComplexDisplayMat(mat1.mat, mat1.r, mat1.c);

            mat2 = MatrixOps.ComplexInverse(mat1);

            Console.Write("\nInverse of entered matrix:");
            ComplexDisplayMat(mat2.mat, mat2.r, mat2.c);
        }

        static void Main(String[] args)
        {
            char ch;
            int choice;
            do
            {
                Console.WriteLine("Options:\n1.Add" +
                    "\n2.Subtract" +
                    "\n3.Multiply with constant" +
                    "\n4.Multiply with matrix" +
                    "\n5.Transpose" +
                    "\n6.Determinant" +
                    "\n7.Adjoint" +
                    "\n8.Inverse" +
                    "\n9.(Complex) Addition" +
                    "\n10.(Complex) Subtraction" +
                    "\n11.(Complex) Multiplication with constant" +
                    "\n12.(Complex) Matrix Multiplication" +
                    "\n13.(Complex) Transpose" +
                    "\n14.(Complex) Determinant" +
                    "\n15.(Complex) Adjoint" +
                    "\n16.(Complex) Inverse" +
                    "\nEnter Choice:");
                int.TryParse(Console.ReadLine(), out choice);
                switch (choice)
                {
                    case 1:
                        AddMat();
                        break;
                    case 2:
                        SubMat();
                        break;
                    case 3:
                        MultiplyNumber();
                        break;
                    case 4:
                        MultiplyMatrix();
                        break;
                    case 5:
                        MatrixTranspose();
                        break;
                    case 6:
                        MatrixDeterminant();
                        break;
                    case 7:
                        AdjointMatrix();
                        break;
                    case 8:
                        InverseMatrix();
                        break;
                    case 9:
                        ComplexAddMat();
                        break;
                    case 10:
                        ComplexSubMat();
                        break;
                    case 11:
                        ComplexMultiplyNumber();
                        break;
                    case 12:
                        ComplexMultiplyMatrix();
                        break;
                    case 13:
                        ComplexMatrixTranspose();
                        break;
                    case 14:
                        ComplexMatrixDeterminant();
                        break;
                    case 15:
                        ComplexAdjointMatrix();
                        break;
                    case 16:
                        ComplexInverseMatrix();
                        break;
                }
                Console.WriteLine("\nEnter ' ' to continue:");
                char.TryParse(Console.ReadLine(), out ch);
            } while (ch == ' ');
        }
    }
}
