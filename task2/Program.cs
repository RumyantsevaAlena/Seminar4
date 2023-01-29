// Задача 27: Напишите программу, которая принимает на вход число 
//и выдаёт сумму цифр в числе.

//452 -> 11
//82 -> 10
//9012 -> 12
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

int numberN = InputNumber("Введите число N: ");

int SumNumber(int numberN)
{
    int counter = Convert.ToString(numberN).Length;
    int advance = 0;
    int result = 0;

    for (int i = 0; i < counter; i++)
    {
        advance = numberN - numberN % 10;
        result = result + (numberN - advance);
        numberN = numberN / 10;
    }
    return result;
}
int sumNumber = SumNumber(numberN);
Console.WriteLine(sumNumber);