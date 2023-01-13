using static System.Console;

//создаём массив из 8 элементов
int[] arr = new int[8];
//в переменную кладу вызов метода с заполненным массивом
int[] result = GetArr(arr);

Write("Вот массив: ");
//вызов на печать массива
PrintArray(result);

//метод создаёт элементы массива
int[] GetArr(int[] array)
{
    
    for(int i = 0; i < array.Length; i++)
    {
        //ограничил Random 2значными цифрами иначе выдаёт огромные цифры
        array[i] =  new Random().Next(0, 100);
    }

    return array;
}

//метод выдаёт на экран массив
void PrintArray(int[] a)
{
    for(int i = 0; i < a.Length; i++)
    {
        if(i < a.Length-1)
        Write($"{a[i]},");
        //отделил последний элемент чтобы он был без запятой
        else
        {
           Write($"{a[i]}"); 
        }
    }
}