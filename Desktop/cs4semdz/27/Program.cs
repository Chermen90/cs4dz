using static System.Console;
Write("Input number: ");
int number = int.Parse(ReadLine()!);
int result = GetSum(number);
WriteLine($"Сумма цифр в числе {number} равна {result}");

int GetSum(int A)
{
    int sum = 0;
    int temp = 0;

    while(A > 0)
{
    temp = (A % 10);
    A = A / 10;
    sum += temp;
}
    return sum;
}


