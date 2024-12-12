/*
Дан двумерный массив.
Вычислить сумму второй строки и произведение первого столбца. Вывести исходную матрицу и результаты вычислений. 
 */
using System;
using System.Text;

namespace CSharplight
{
    internal class Programm
    {
        static void Main(string[] args)
        {
            int rows = 3;  
            int columns = 4; 
            int secondRow = 1;  
            int firstColumn = 0;
            int sumSecondRow = 0;
            int productFirstColumn = 1; 
            int minValue = 0;
            int maxValue = 31;
            int[,] array = new int[rows, columns];

            Random random = new Random(); 

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = random.Next(minValue, maxValue); 
                    Console.Write(array[i, j] + " "); 
                }
                Console.WriteLine(); 
            }

            for (int j = 0; j < array.GetLength(1); j++)
            {
                sumSecondRow += array[secondRow, j]; 
            }
            
            for (int i = 0; i < array.GetLength(0); i++)
            {
                productFirstColumn *= array[i, firstColumn]; 
            }
            Console.WriteLine($"Сумма второй строки: {sumSecondRow}\nПроизведение первого столбца: {productFirstColumn}");
        }
    }
} 