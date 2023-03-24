// Задайте значения M и N. Напишите программу,
//  которая найдёт сумму натуральных элементов в промежутке от M до N.

//  M = 1; N = 15 -> 120
//  M = 4; N = 8. -> 30

//===============БЛОК ОПИСАНИЙ======================
int InputNumberUser(string inputMessage, string errorMessage)
{
    while (true)
    {
        try
        {
            Console.Write(inputMessage);
            int number = int.Parse(Console.ReadLine() ?? "");
            if (number > 0) return number;
            else Console.WriteLine(errorMessage);
        }
        catch
        {
            Console.WriteLine(errorMessage);
        }
    }
}

int SummaNaturalNumbers(int start, int end)
{
    int max;
    int min;
    if (start > end)
    {
        max = start;
        min = end;
    }
    else
    {
        max = end;
        min = start;
    }
    if (max == min) return min;
    else return max + SummaNaturalNumbers(max - 1, min);
}

void PrintResult(int start, int end, int result)
{
    Console.WriteLine($"Сумма натуральных элементов в промежутке от M = {start} до N = {end} -> {result}");
}
//===================================================
Console.Clear();
int m = InputNumberUser("Введите неотрицательное число M - ", "Ошибка ввода!");
int n = InputNumberUser("Введите неотрицательное число N - ", "Ошибка ввода!");
int result = SummaNaturalNumbers(m, n);
PrintResult(m, n, result);
