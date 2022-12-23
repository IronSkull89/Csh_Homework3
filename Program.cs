int task;

int SelectionTask()
{
    Console.Write("Выберите задачу (от 1 до 3): ");
    if (!int.TryParse(Console.ReadLine(), out int task) || task > 3 || task < 1)
    {
        task = SelectionTask();
    }
    return task;
}

//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

int SetFiveDigitNumber()
{
    Console.Write("Введите пятизначное число: ");
    if (!int.TryParse(Console.ReadLine(), out int number) || number < 10000 || number > 99999)
    {
        number = SetFiveDigitNumber();
    }
    return number;
}

bool IsPalindrome(int number)
{
    bool isPalindrome = true;
    string str_number = Convert.ToString(number);
    int length = str_number.Length;
    for (int i = 0; i < length / 2; i++)
    {
        if (str_number[i] != str_number[length - i - 1])
        {
            isPalindrome = false;
            return isPalindrome;
        }
    }
    return isPalindrome;
}

//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

int InputCoordinate(string D)
{
    Console.Write($"    Введите целочисленную координату {D}: ");
    if (!int.TryParse(Console.ReadLine(), out int coordinate))
    {
        coordinate = InputCoordinate(D);
    }
    return coordinate;
}

int[] InputPoint3D()
{
    return new int[3] { InputCoordinate("X"), InputCoordinate("Y"), InputCoordinate("Z") };
}

double GetDistance(int[] FirstPoint, int[] SecondPoint)
{
    double distance = 0;
    for (int i = 0; i < Math.Min(FirstPoint.Length, SecondPoint.Length); i++)
    {
        distance += Math.Pow(FirstPoint[i] - SecondPoint[i], 2);
    }
    distance = Math.Sqrt(distance);
    return distance;
}

double GetDistance3D()
{
    System.Console.WriteLine("Введите координаты первой точки: ");
    int[] FirstPoint = InputPoint3D();
    System.Console.WriteLine("Введите координаты второй точки: ");
    int[] SecondPoint = InputPoint3D();
    return GetDistance(FirstPoint, SecondPoint);
}

//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

int InputNumber()
{
    Console.Write("Введите число: ");
    if (!int.TryParse(Console.ReadLine(), out int number))
    {
        number = InputNumber();
    }
    return number;
}

void WriteTableCubes(int number)
{
    for (int i = 1; i < number; i++)
    {
        Console.Write(Math.Pow(i, 3) + ", ");
    }
    Console.Write(Math.Pow(number, 3));
}



//----------------------------------------------------------------------------------------------------------------------------------------------------------------------

task = SelectionTask();
if (task == 1)
{
    if (IsPalindrome(SetFiveDigitNumber())) Console.WriteLine("Это число полиндром.");
    else Console.WriteLine("Это число не полиндром.");
}
else if (task == 2)
{
    Console.WriteLine("Расстояние между точками = " + GetDistance3D());
}
else if (task == 3)
{
    WriteTableCubes(InputNumber());
}