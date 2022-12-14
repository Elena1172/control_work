// Задача: Написать программу, которая из имеющегося массива строк формируе
//  массив из строк, длина которых меньше либо равна 3 символа. 
//  Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.
string[] FillAr(int n)
{
    string[] text = new string[n];
    for (int i = 0; i < text.Length; i++)
    {
        string tx = Console.ReadLine();
        text[i] = tx;
    }
    return text;
}
void PrintArray(string[] textarray)
{
    Console.Write("[ ");
    foreach (string item in textarray)
    {
        Console.Write($"\"{item}\" ");
    }
    Console.Write("]");
}
void ShuffleEl(string[] array)
{
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        int j = rnd.Next(i + 1);
        string temp = array[i];
        array[i] = array[j];
        array[j] = temp;
    }
}
string[] FillAr2(string[] array)
{
    int n = new Random().Next(4);
    string[] newtext = new string[n];
    for (int i = 0; i < newtext.Length; i++)
    {
        newtext[i] = array[i];
    }
    return newtext;
}
Console.WriteLine("Введите количество элементов массива натуральным числом больше 3 ");
int n = Convert.ToInt32(Console.ReadLine());
if (n < 4) Console.Write("Неправильный ввод данных");
else
{
    Console.WriteLine("Введите с клавиатуры элементы массива, разделяя их клавишей enter");
    string[] txt = FillAr(n);
    PrintArray(txt);
    ShuffleEl(txt);
    string[] newtxt = FillAr2(txt);
    Console.Write(" -> ");
    PrintArray(newtxt);
}
