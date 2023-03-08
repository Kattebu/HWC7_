//Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.
int[,] GetMatrix(int rows, int cols, int minValue, int maxValue)
{
    int[,] matrix = new int[rows,cols];
    for(int i =0; i<matrix.GetLength(0); i++)
    {
        for (int j =0; j<matrix.GetLength(1); j++)
        {
            matrix[i,j]=new Random().Next(minValue,maxValue+1);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matr)
{
for(int i =0; i<matr.GetLength(0); i++)
    {
        for (int m =0; m<matr.GetLength(1); m++)
        {
            Console.Write(matr[i,m]+"\t");
        }
        Console.WriteLine();
    }
}


int[,] resultMatrix=GetMatrix(3,4,0,10);
PrintMatrix(resultMatrix);

double averageOfColumns=0;
for(int j =0; j<resultMatrix.GetLength(1); j++)
    {
        for (int i =0; i<resultMatrix.GetLength(0); i++)
        {
            averageOfColumns+=resultMatrix[i,j];
        }
        Console.WriteLine($"Среднее арифметическое столбца {j+1}: {averageOfColumns}");
        averageOfColumns=0;
    }