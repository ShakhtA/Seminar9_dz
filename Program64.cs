//  Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1.
//  Выполнить с помощью рекурсии.

//  N = 5 -> "5, 4, 3, 2, 1"
//  N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

//===================БЛОК ОПИСАНИЙ=======================
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

string OutputNumbers(int num)
{   
    if (num == 1) 
        return num.ToString();
    else
    {   
       
        return num + ", " + OutputNumbers(num - 1);
    }
}


//========================================================
Console.Clear();
int number = InputNumberUser("Введите целое положительное число N - ", "Ошибка ввода!");
Console.Write($"N = {number} -> \"{OutputNumbers(number)}\"");
