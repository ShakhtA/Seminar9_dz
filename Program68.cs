// Напишите программу вычисления функции Аккермана с помощью рекурсии.
// Даны два неотрицательных числа m и n. 
// m = 2, n = 3 -> A(m,n) = 29

//====================БЛОК ОПИСАНИЙ======================================
int InputNumberUser(string inputMessage, string errorMessage)
{
    while (true)
    {
        try
        {
            Console.Write(inputMessage);
            int number = int.Parse(Console.ReadLine() ?? "");
            if (number > -1) return number;
            else Console.WriteLine(errorMessage);
        }
        catch
        {
            Console.WriteLine(errorMessage);
        }
    }
    
}

bool CheckingNumber(int num1, int num2)
/* Функция проверяет полученные от пользователя числа,
   предупреждает пользователя о возможном переполнении стека и
   предлагает пользователю на выбор ввести новые значения или продолжить со старыми */

{
    bool f = false;
    if ((num1 > 4 && num2 == 0) || (num1 > 3 && num2 > 0))
    {
        Console.WriteLine($"{num1} - слишком большое число. \nПроизойдет переполнение стека.\n" + 
                                    "Нажмите Enter, чтобы ввести новое число или любую клавишу для продолжения.");
        
        return (Console.ReadKey().Key == ConsoleKey.Enter);
    }
    else return f;
}

int FunctionAckermann(int num1, int num2)
{
    int result = 0;
    if (num1 == 0) return result + (num2+1);
    else if (num2 == 0) return result + FunctionAckermann(num1 - 1, 1);
         else return result + FunctionAckermann(num1 - 1, FunctionAckermann(num1, num2 - 1));
}

void PrintResult(int num1, int num2, int result)
{
    Console.WriteLine($"m = {num1}, n = {num2} -> A(m,n) = {result}");
    Console.WriteLine();
}

//=======================================================================

Console.Clear();
int m;
int n = InputNumberUser("Введите неотрицательное число n - ", "Ошибка ввода!");
do
m = InputNumberUser("Введите неотрицательное число m - ", "Ошибка ввода!");
while(CheckingNumber(m,n));

int result = FunctionAckermann(m,n);
PrintResult(m, n, result);
