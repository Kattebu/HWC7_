// ДЗ задача 50 Напиать программу, которая на вход принимает позиции элемента в двумерном массиве, 
//и возвращает значение этого элемента или же указание, что такого элемента нет.

int[,] existingMatrix= new int[3,4]{{0,1,2,3},{44,15,2,0},{4,5,6,7}};
Console.WriteLine("Введите номер строчки элемента массива: ");
int numberOfRow=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите номер столбца элемента массива: ");
int numberOfColumn=Convert.ToInt32(Console.ReadLine());
int i=numberOfRow-1;
int j=numberOfColumn-1;
if(i<existingMatrix.Length && j<existingMatrix.Length)
{
    Console.WriteLine($"Значение элемента: {existingMatrix[i,j]}");
}
else
{
    Console.WriteLine("Такого элемента в массиве нет");  
}