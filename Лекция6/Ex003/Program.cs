// В случайных точках экрана вывести случайные числа
//частичное решение

Random arr = new Random();

Console.CoursorVisible = false;
while (true)
{
    Console.SetCoursorPosition(
        left: r.Next(Console.WindowWidth),
        top: r.Next(Console.WindowHeight)
    );
    Console.Write(r.Next(10));
    Thread.Sleep(1000);
}