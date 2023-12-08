// Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
// длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
// лучше обойтись исключительно массивами.

string[] A1 = new string[6] {"жил", "был", "разработчик", "нет", "его", "357535"};
string[] A2 = new string[A1.Length];

void SecondArrayWithIF(string[] A1, string[] A2)
{
    int count = 0;
    for (int i = 0; i < A1.Length; i++)
    {
    if(A1[i].Length <= 3)
        {
        A2[count] = A1[i];
        count++;
        }
    }
}
void PrintArray(string[] A)
{
    for (int i = 0; i < A.Length; i++)
    {
        Console.Write($"{A[i]} ");
    }
    Console.WriteLine();
}
SecondArrayWithIF(A1, A2);
PrintArray(A2);
