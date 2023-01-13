using static System.Console;
Write("Введите число А ");
int firstnumber = int.Parse(ReadLine()!);

Write("Введите число Б ");
int secondnumber = int.Parse(ReadLine()!);

int result = GetPower(firstnumber, secondnumber);
WriteLine($"Число А в степени Б равно = {result}");


int GetPower(int A, int B)
{
    int res = 1;
    int count = 0;
    while(count < B)
    {
        res *= A;
        count++;
    }

    return res;
}

