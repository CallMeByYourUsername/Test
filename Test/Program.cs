/*Написать  программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа.
 Первоначальный массив можно ввести с клавиатуры, либо задать на старте алгоритма*/


string[] array = new string[] {"Hello", "my", "age", "is", "12345"};
string[] resultArray = new string[array.Length];


void SortArray(string[] firstArray, string[] sortedArray)
{
    int j = 0;
    for (int i = 0; i < firstArray.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            sortedArray[j] = array[i];
            j++;
         }

    }

}

void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}

SortArray(array, resultArray);
PrintArray(resultArray);