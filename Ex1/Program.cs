//Задача 47: Задать двумерный массив размером m*n случайными вещественными числами
double[,] GetMatrix(int m, int n)
{
    double[,] matrix = new double[m,n];//[строчка, столбец]
    for(int i =0; i<matrix.GetLength(0); i++)//строчки rows=matrix.GetLength(0)
    {
        for (int j =0; j<matrix.GetLength(1); j++)
        {
            matrix[i,j]=new Random().NextDouble();
        }
    }
    return matrix;//вернули заполненную таблицу
}
//метод для печати матрицы (двумерного массива)
void PrintMatrix(double[,] matr)
{
for(int i =0; i<matr.GetLength(0); i++)//проход по строчкам
    {
        for (int j =0; j<matr.GetLength(1); j++)//проход по столбцам
        {
            Console.Write(matr[i,j]+"\t");
        }
        Console.WriteLine();
    }
}
double[,] resultMatrix=GetMatrix(5,4);
PrintMatrix(resultMatrix);
