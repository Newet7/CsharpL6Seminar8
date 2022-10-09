// DrowText что может тут не понравится, опишите

// void DrawText (string text, int left, int top)
// {
//     Console.SetCoursorPosition(left, top);
//     Console.WriteLine(text);
// }

// DrawText("Intensive C# Demo text", 629, 360);

//Как улучшить

// string caption = "Intensive C# Demo text";
// int screenWidthPosition = (Console.WindowWidth - caption.Length) / 2;
// int screenHeightPosition = Console.WindowHeight / 2;

// DrawText(caption, screenWidthPosition, screenHeightPosition);

// DrawText(
//     text: caption,
//     left: screenWidthPosition,
//     top: screenHeightPosition
// );

// string lable = "";                  //111
// string address = String.Empty;       //222

// DrawText("Intensive C# Demo text", 629, 360);


// Следующий премер

//Пример1
double a = 1, b = -26, c = 120;
var d = b*b-4*a*c;
double x1 = (-b + Math.Sqrt(d)) / (2*a);
double x2 = (-b - Math.Sqrt(d)) / (2*a);

System.Console.WriteLine($"x1 = {x1} x2 = {x2}");

//Пример2
a = 2, b = 1, c = -3;
d = b*b-4*a*c;
x1 = (-b + Math.Sqrt(d)) / (2*a);
x2 = (-b - Math.Sqrt(d)) / (2*a);

System.Console.WriteLine($"x1 = {x1} x2 = {x2}");

//Пример3
a = 1, b = 1, c = -6;
d = b*b-4*a*c;
x1 = (-b + Math.Sqrt(d)) / (2*a);
x2 = (-b - Math.Sqrt(d)) / (2*a);

System.Console.WriteLine($"x1 = {x1} x2 = {x2}");

// как улучшить эти 3 примера, обернуть в метод

public Roots Solve(double a, double b, double c)
{
    var d = b*b-4*a*c;
    double x1 = (-b + Math.Sqrt(d)) / (2*a);
    double x2 = (-b - Math.Sqrt(d)) / (2*a);
    return new Roots {X1 = x1; X2 = x2};
}
