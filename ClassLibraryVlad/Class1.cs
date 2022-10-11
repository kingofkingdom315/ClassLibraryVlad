using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryVlad
{
    public class CMatrix
    {
        private double[,] matrix;

        //конструктор размерность матрицы
        public CMatrix(int lengh)
        {
            matrix = new double[lengh, lengh];
        }

        //конструтор с одним параметром матрицa вещественных чисел
        public CMatrix(double[,] matrixValue)
        {
            int leght = Convert.ToInt32(Math.Sqrt(matrixValue.Length));
            matrix = new double[leght, leght];
            matrix = matrixValue;
        }
        //свойство определения размерности матрицы
        public int getLengthMatrix
        {
            get { return Convert.ToInt32(Math.Sqrt(matrix.Length)); }
        }
        //индексатор для доступа к элементам поля-массива
        public double this[int i, int j]
        {
            get { return matrix[i, j]; }
            set { matrix[i, j] = value; }
        }

        public double[,] GetMatrix()
        {
            return matrix;
        }

        //вычисление произведения с чётными номерами
        public double diag(double[,] matrix)
        {
            int i = 0, j = 0;
            double buf = 1;
            while (i < matrix.Length & j < matrix.Length)
            {
                buf *= matrix[i, j];
                i++;
                j++;
            }
            return buf;
        }

        public double diag(int cursor)
        {
            int i = 0, j = 0;
            double buf = 1;
            if (cursor < 0)
                i += -cursor;
            else
                j += cursor;
            while (i < matrix[0, 0] & j < matrix[0, 0])
            {
                buf *= matrix[i, j];
                i++;
                j++;
            }
            return buf;
        }
    }
}
