void v1()
{
    Console.WriteLine("Input first number");
    string? A = Console.ReadLine();
    Console.WriteLine("Input second number");
    string? B = Console.ReadLine();
    int a = Int32.Parse(A);
    int b = Int32.Parse(B);

    Console.WriteLine((a % b == 0) ? ("Kratno") : ("Ne kratno") + (" ") + (a % b));
}

void v2()
{
    Console.WriteLine("Input first number");
    string? A = Console.ReadLine();
    Console.WriteLine("Input second number");
    string? B = Console.ReadLine();

    if (A != null && B != null)
    {
        int a = Int32.Parse(A);
        int b = Int32.Parse(B);
        Console.WriteLine((a % b == 0) ? ("Kratno") : ("Ne kratno") + (" ") + (a % b));
    }
}
//recieve 2 numbers from user
int a = 0;
int b = 0;
bool result = false;
void readData()
{
    Console.WriteLine("Input first number");
    string? A = Console.ReadLine();
    Console.WriteLine("Input second number");
    string? B = Console.ReadLine();

    if (A != null && B != null)
    {
        int a = Int32.Parse(A);
        int b = Int32.Parse(B);
    }
}

void calculateData()
{
result = (a % b == 0); 
}

void outputData()
{
if (result)
{
    Console.WriteLine("Kratno");
}
else 
{
     Console.WriteLine(("Ne kratno") + (" ") + (a % b));
}
}