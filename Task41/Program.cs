/*
Задача 41: Пользователь вводит с клавиатуры M чисел.
Посчитайте, сколько чисел больше 0 ввёл пользователь.
Example:
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3
*/

void TimeOfDay()
{
    int time = DateTime.Now.Hour;
    if (time >= 0 && time <= 5)
    {
        Console.WriteLine("$-$-$-$-$-$-$-$-$-$-$-$-$-$-$-$-$-$-$-$-$-$-$-$-$-$-$-$-$-$");
        Console.WriteLine();
        Console.WriteLine("                       Доброй ночи!");
    }
        if (time > 5 && time <= 11)
        {
            Console.WriteLine("$-$-$-$-$-$-$-$-$-$-$-$-$-$-$-$-$-$-$-$-$-$-$-$-$-$-$-$-$-$");
            Console.WriteLine();
            Console.WriteLine("                       Доброе утро!");
        }
            if (time > 11 && time <= 17)
            {
               Console.WriteLine("$-$-$-$-$-$-$-$-$-$-$-$-$-$-$-$-$-$-$-$-$-$-$-$-$-$-$-$-$-$");
               Console.WriteLine();
               Console.WriteLine("                       Добрый день!"); 
            }
                if (time > 17 && time <= 23)
                {
                    Console.WriteLine("$-$-$-$-$-$-$-$-$-$-$-$-$-$-$-$-$-$-$-$-$-$-$-$-$-$-$-$-$-$");
                    Console.WriteLine();
                    Console.WriteLine("                       Добрый вечер!");
                }

Console.WriteLine("       Казино 'GEEK BRAINS' приветствует Вас !!!");
Console.WriteLine();
Console.WriteLine("$-$-$-$-$-$-$-$-$-$-$-$-$-$-$-$-$-$-$-$-$-$-$-$-$-$-$-$-$-$");
Console.WriteLine();
}

int[] CreateArray(int size)
{
    int[] arr = new int[size];
    for (int i = 0; i < size; i++)
    {
        Console.Write($"Введите {i+1}-е число  ");
        arr[i] = Convert.ToInt32(Console.ReadLine());
    }
    return arr;
}

int Check(int [] arr)
{
    int counter = 0;
    for(int i =0; i < arr.Length; i++)
    {
        if(arr[i] > 0) counter ++;
    }
    return counter;
}

void JackPot(int k, int l)
{
    string text = "";
    if(k == 1 || k == 21)    text = "положительное число";
    if(k > 1 && k <= 4) text = "положительных числа";
    if(k > 4 && k <= 20) text = "положительных чисел";
    
    Console.WriteLine("$-$-$-$-$-$-$-$-$-$-$-$-$-$-$-$-$-$-$-$-$-$-$-$-$-$-$-$-$-$");
    Console.WriteLine();
    Console.WriteLine("         Поздравляем, Вы сняли ДжекПот!!!");
    Console.WriteLine($"Вы ввели {k} {text} из {l} возможных!");
    Console.WriteLine();
    Console.WriteLine("$-$-$-$-$-$-$-$-$-$-$-$-$-$-$-$-$-$-$-$-$-$-$-$-$-$-$-$-$-$");
    Console.WriteLine();
}

void Upss(int k, int l)
{
    string text = "";
    if(k == 1 || k == 21)    text = "положительное число";
    if(k > 1 && k <= 4) text = "положительных числа";
    if(k > 4 && k <= 20) text = "положительных чисел";

    Console.WriteLine("$-$-$-$-$-$-$-$-$-$-$-$-$-$-$-$-$-$-$-$-$-$-$-$-$-$-$-$-$-$");
    Console.WriteLine();
    Console.WriteLine("                     Упс......");
    Console.WriteLine($"Вы ввели всего {k} {text} из {l} возможных!");
    Console.WriteLine("                 Приходите завтра.");
    Console.WriteLine();
    Console.WriteLine("$-$-$-$-$-$-$-$-$-$-$-$-$-$-$-$-$-$-$-$-$-$-$-$-$-$-$-$-$-$");
    Console.WriteLine();
}

Console.Clear();
TimeOfDay();

Console.Write("          Сколько чисел Вы будете сегодня вводить??? ");
int n = Convert.ToInt32(Console.ReadLine());

Console.Clear();
Console.WriteLine($"Ну что-ж, усаживайтесь в кресле по удобнее и расслабтесь");
Console.WriteLine();

Console.Write("          Начинаем ? ( Enter/N )  ");
string answer = Convert.ToString(Console.ReadLine());
Console.WriteLine();

if (answer == "n") 
{
    Console.WriteLine("     Ну что-ж, приходите завтра!");
    Console.WriteLine();
    System.Environment.Exit(0);
}
int[] array = CreateArray(n);
Console.WriteLine();

int count = Check(array);

Console.Clear();
if (count == n) JackPot(count, n);
    else
    Upss(count, n);



