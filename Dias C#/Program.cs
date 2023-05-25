Console.WriteLine("Выберите +,-,*,/");
String a = Console.ReadLine();

Console.WriteLine("Введите 1 число");
int A;
A = int.Parse(Console.ReadLine());

Console.WriteLine("Введите 2 число ");
int B; 
B = int.Parse(Console.ReadLine());
switch (a)
{
    case "+":
        Console.WriteLine("Ок,Result:" + (A + B));
        break;

    case "-":
        Console.WriteLine("Ok,Result:  " + (A - B));
        break;

    case "*":
        Console.WriteLine("OK,Result:" + (A * B));

        break;

    case "/":
        Console.WriteLine("OK,Result:" + (A / B));
        break;
}