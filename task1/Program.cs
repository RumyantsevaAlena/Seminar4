// Напишите цикл, который принимает на вход два числа (A и B) 
//и возводит число A в натуральную степень B.

//3, 5 -> 243 (3⁵)
//2, 4 -> 16

int Degree(int numberA, int numberB)
{
    int result = 1;
    for (int i = 1; i <= numberB; i++)
    {
        result = result * numberA;
    }
    return result;
}
int InputNumber(string str)
{
    int number;
    string text;
    while (true)
    {
        System.Console.WriteLine(str);
        text = Console.ReadLine();
        if (int.TryParse(text, out number))
        {
            break;
        }
        System.Console.WriteLine("Введено некорректное число");
    }
    return number;
}
int numberA = InputNumber("Введите число A: ");
int numberB = InputNumber("Введите число B: ");
int degree = Degree(numberA, numberB);
Console.WriteLine(degree);