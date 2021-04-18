using System;
using System.Numerics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixFunctions
{
    public struct matrix
    {
        public double[,] mat;
        public int r;
        public int c;
    };
    public struct ComplexMatrix
    {
        public Complex[,] mat;
        public int r;
        public int c;

    };
    public class MatrixOps
    {
        //Function to add 2 matrices
        public static matrix Add(matrix mat1, matrix mat2)
        {
            matrix mat3;
            int i, j;
            mat3.r = mat1.r;
            mat3.c = mat1.c;
            mat3.mat = new double[mat3.r, mat3.c];

            for (i = 0; i < mat1.r; i++)
            {
                for (j = 0; j < mat1.c; j++)
                {
                    mat3.mat[i, j] = mat1.mat[i, j] + mat2.mat[i, j];
                }
            }
            return (mat3);

        }

        //Complex counterpart
        public static ComplexMatrix ComplexAdd(ComplexMatrix mat1, ComplexMatrix mat2)
        {
            ComplexMatrix mat3;
            int i, j;
            mat3.r = mat1.r;
            mat3.c = mat1.c;
            mat3.mat = new Complex[mat3.r, mat3.c];

            for (i = 0; i < mat1.r; i++)
            {
                for (j = 0; j < mat1.c; j++)
                {
                    mat3.mat[i, j] = mat1.mat[i, j] + mat2.mat[i, j];
                }
            }
            return (mat3);

        }

        //Function to subtract second matrix from the first
        public static matrix Subtract(matrix mat1, matrix mat2)
        {
            int i, j;
            matrix mat3;
            int r = mat3.r = mat1.r;
            int c = mat3.c = mat1.c;

            mat3.mat = new double[r, c];
            for (i = 0; i < r; i++)
            {
                for (j = 0; j < c; j++)
                {
                    mat3.mat[i, j] = mat1.mat[i, j] - mat2.mat[i, j];
                }
            }
            return (mat3);
        }

        //Complex counterpart
        public static ComplexMatrix ComplexSubtract(ComplexMatrix mat1, ComplexMatrix mat2)
        {
            int i, j;
            ComplexMatrix mat3;
            int r = mat3.r = mat1.r;
            int c = mat3.c = mat1.c;

            mat3.mat = new Complex[r, c];
            for (i = 0; i < r; i++)
            {
                for (j = 0; j < c; j++)
                {
                    mat3.mat[i, j] = mat1.mat[i, j] - mat2.mat[i, j];
                }
            }
            return (mat3);
        }

        //Function to multiply a matrix with a real number
        public static matrix MultNum(matrix mat, double con)
        {
            int i, j;

            for (i = 0; i < mat.r; i++)
            {
                for (j = 0; j < mat.c; j++)
                {
                    mat.mat[i, j] *= con;
                }
            }
            return mat;
        }

        //Complex counterpart
        public static ComplexMatrix ComplexMultNum(ComplexMatrix mat, Complex con)
        {
            int i, j;

            for (i = 0; i < mat.r; i++)
            {
                for (j = 0; j < mat.c; j++)
                {
                    mat.mat[i, j] *= con;
                }
            }
            return mat;
        }

        //Function to perform standard multiplication of 2 matrices
        public static matrix MatMult(matrix mat1, matrix mat2)
        {
            int i, j, k;
            matrix mat3;
            mat3.r = mat1.r;
            mat3.c = mat2.c;
            mat3.mat = new double[mat3.r, mat3.c];

            for (i = 0; i < mat1.r; i++)
            {
                for (j = 0; j < mat2.c; j++)
                {
                    for (k = 0; k < mat1.c; k++)
                    {
                        mat3.mat[i, j] += mat1.mat[i, k] * mat2.mat[k, j];
                    }
                }
            }

            return mat3;
        }

        //Complex counterpart
        public static ComplexMatrix ComplexMatMult(ComplexMatrix mat1, ComplexMatrix mat2)
        {
            int i, j, k;
            ComplexMatrix mat3;
            mat3.r = mat1.r;
            mat3.c = mat2.c;
            mat3.mat = new Complex[mat3.r, mat3.c];

            for (i = 0; i < mat1.r; i++)
            {
                for (j = 0; j < mat2.c; j++)
                {
                    for (k = 0; k < mat1.c; k++)
                    {
                        mat3.mat[i, j] += mat1.mat[i, k] * mat2.mat[k, j];
                    }
                }
            }

            return mat3;
        }

        //Function to get transpose of a given matrix
        public static matrix Transpose(matrix mat1)
        {
            int i, j;
            matrix mat2;

            mat2.r = mat1.c;
            mat2.c = mat1.r;
            mat2.mat = new double[mat2.r, mat2.c];

            for (i = 0; i < mat1.r; i++)
            {
                for (j = 0; j < mat1.c; j++)
                {
                    mat2.mat[j, i] = mat1.mat[i, j];
                }
            }

            return mat2;

        }

        //Complex counterpart
        public static ComplexMatrix ComplexTranspose(ComplexMatrix mat1)
        {
            int i, j;
            ComplexMatrix mat2;

            mat2.r = mat1.c;
            mat2.c = mat1.r;
            mat2.mat = new Complex[mat2.r, mat2.c];

            for (i = 0; i < mat1.r; i++)
            {
                for (j = 0; j < mat1.c; j++)
                {
                    mat2.mat[j, i] = mat1.mat[i, j];
                }
            }

            return mat2;

        }

        //Function to find the determinant of a matrix
        public static double Determinant(matrix mat1)
        {
            matrix mat2;
            double det = 0;
            int rp; //Row position of new matrix
            int cp; //Column position of new matrix
            if (mat1.r > 2)
            {
                mat2.r = mat1.r - 1;
                mat2.c = mat1.c - 1;
                for (int i = 0; i < mat1.c; i++)
                {
                    rp = cp = 0;
                    mat2.mat = new double[mat2.r, mat2.c];
                    for (int j = 1; j < mat1.r; j++)
                    {
                        for (int k = 0; k < mat1.c; k++)
                        {
                            if (k != i)
                            {
                                mat2.mat[rp, cp] = mat1.mat[j, k];
                                if ((cp + 1) % mat2.c == 0)
                                {
                                    cp = 0;
                                    rp++;
                                    continue;
                                }
                                cp++;
                            }
                        }
                    }
                    double x = Math.Pow(-1.0, (double)i) * mat1.mat[0, i] * Determinant(mat2);     //Recursion step
                    det += x;
                }
                return det;
            }
            else
            {
                if (mat1.r == 2)
                    return (mat1.mat[0, 0] * mat1.mat[1, 1] - mat1.mat[0, 1] * mat1.mat[1, 0]);
                else if (mat1.r == 1)
                    return mat1.mat[0, 0];
                else
                {
                    //Error: Null matrix emtered.
                    return 0;
                }

            }
        }

        //Complex counterpart
        public static Complex ComplexDeterminant(ComplexMatrix mat1)
        {
            ComplexMatrix mat2;
            Complex det = 0;
            int rp; //Row position of new matrix
            int cp; //Column position of new matrix
            if (mat1.r > 2)
            {
                mat2.r = mat1.r - 1;
                mat2.c = mat1.c - 1;
                for (int i = 0; i < mat1.c; i++)
                {
                    rp = cp = 0;
                    mat2.mat = new Complex[mat2.r, mat2.c];
                    for (int j = 1; j < mat1.r; j++)
                    {
                        for (int k = 0; k < mat1.c; k++)
                        {
                            if (k != i)
                            {
                                mat2.mat[rp, cp] = mat1.mat[j, k];
                                if ((cp + 1) % mat2.c == 0)
                                {
                                    cp = 0;
                                    rp++;
                                    continue;
                                }
                                cp++;
                            }
                        }
                    }
                    Complex x = Math.Pow(-1.0, (double)i) * mat1.mat[0, i] * ComplexDeterminant(mat2);     //Recursion step
                    det += x;
                }
                return det;
            }
            else
            {
                if (mat1.r == 2)
                    return (mat1.mat[0, 0] * mat1.mat[1, 1] - mat1.mat[0, 1] * mat1.mat[1, 0]);
                else if (mat1.r == 1)
                    return mat1.mat[0, 0];
                else
                {
                    //Error: Null matrix emtered.
                    return 0;
                }

            }
        }

        //Function to find adjoint of given matrix
        public static matrix Adjoint(matrix mat1)
        {
            if (mat1.r != 1)
            {
                matrix mat2, mat3;

                mat2.r = mat2.c = mat1.r - 1;
                mat2.mat = new double[mat2.r, mat2.c];

                mat3.r = mat3.c = mat1.r;
                mat3.mat = new double[mat3.r, mat3.c];

                int i, j, k, l;
                int rp, cp;

                for (i = 0; i < mat1.r; i++)
                {
                    for (j = 0; j < mat1.c; j++)
                    {
                        rp = cp = 0;
                        for (k = 0; k < mat1.r; k++)
                        {
                            for (l = 0; l < mat1.c; l++)
                            {
                                if (k != i && l != j)
                                {
                                    mat2.mat[rp, cp] = mat1.mat[k, l];
                                    if ((cp + 1) % mat2.r == 0)
                                    {
                                        cp = 0;
                                        rp++;
                                        continue;
                                    }
                                    cp++;
                                }
                            }
                        }

                        mat3.mat[i, j] = Math.Pow(-1, (i + j)) * Determinant(mat2);

                    }
                }

                mat3 = Transpose(mat3);
                return mat3;

            }
            else
            {
                matrix mat3;
                mat3.r = 1;
                mat3.c = 1;

                mat3.mat = new double[1, 1];
                mat3.mat[0, 0] = 1;

                return mat3;
            }
        }

        //Complex counterpart
        public static ComplexMatrix ComplexAdjoint(ComplexMatrix mat1)
        {
            if (mat1.r != 1)
            {
                ComplexMatrix mat2, mat3;

                mat2.r = mat2.c = mat1.r - 1;
                mat2.mat = new Complex[mat2.r, mat2.c];

                mat3.r = mat3.c = mat1.r;
                mat3.mat = new Complex[mat3.r, mat3.c];

                int i, j, k, l;
                int rp, cp;

                for (i = 0; i < mat1.r; i++)
                {
                    for (j = 0; j < mat1.c; j++)
                    {
                        rp = cp = 0;
                        for (k = 0; k < mat1.r; k++)
                        {
                            for (l = 0; l < mat1.c; l++)
                            {
                                if (k != i && l != j)
                                {
                                    mat2.mat[rp, cp] = mat1.mat[k, l];
                                    if ((cp + 1) % mat2.r == 0)
                                    {
                                        cp = 0;
                                        rp++;
                                        continue;
                                    }
                                    cp++;
                                }
                            }
                        }

                        mat3.mat[i, j] = Math.Pow(-1, (i + j)) * ComplexDeterminant(mat2);

                    }
                }
                mat3 = ComplexTranspose(mat3);
                return mat3;

            }
            else
            {
                ComplexMatrix mat3;
                mat3.r = 1;
                mat3.c = 1;

                mat3.mat = new Complex[1, 1];
                mat3.mat[0, 0] = 1;

                return mat3;
            }
        }

        public static matrix Inverse(matrix mat1)
        {
            double det = Determinant(mat1);
            if (det != 0)
            {
                matrix mat2;
                mat2.r = mat2.c = mat1.r;
                mat2.mat = new double[mat2.r, mat2.c];

                mat2 = Adjoint(mat1);
                mat2 = MultNum(mat2, 1/det);

                return (mat2);
            }
            else
            {
                //Error: Inverse does not exist
                matrix mat2;
                mat2.r = 0;
                mat2.c = 0;
                mat2.mat = null;

                return (mat2);
            }
        }

        //Complex counterpart
        public static ComplexMatrix ComplexInverse(ComplexMatrix mat1)
        {
            Complex det = ComplexDeterminant(mat1);
            if (det != 0)
            {
                ComplexMatrix mat2;
                mat2.r = mat2.c = mat1.r;
                mat2.mat = new Complex[mat2.r, mat2.c];

                mat2 = ComplexAdjoint(mat1);
                mat2 = ComplexMultNum(mat2, 1 / det);

                return (mat2);
            }
            else
            {
                //Error: Inverse does not exist
                ComplexMatrix mat2;
                mat2.r = 0;
                mat2.c = 0;
                mat2.mat = null;

                return (mat2);
            }
        }

    }
}
