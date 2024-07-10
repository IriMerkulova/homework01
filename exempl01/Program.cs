//Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. 
//Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. Использовать исключительно массивы.

Console.WriteLine ("Введите строки массива через пробел!");

String M = Console.ReadLine();

String[] mases = M.Split(' ');
var massiv = new String[mases.Length];
var i=0;

foreach (var mas in mases)
{
     if (mas.Length <= 3)
    {
        massiv[i] = mas;
        i++;
    }
}
Console.WriteLine ("{0}", String.Join(" ", massiv));