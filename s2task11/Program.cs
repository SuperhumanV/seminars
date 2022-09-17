//or System.Random numberGenerator = new System.Random();
//int number = numberGenerator.Next(100,1000); 
//v1 
void v1()
{
    int number = new Random().Next(100, 1000);
    Console.WriteLine(number);
    int firstNumber = number / 100;
    int secondNumber = number % 10;
    Console.WriteLine(firstNumber);
    Console.WriteLine(secondNumber);
    Console.WriteLine(firstNumber * 10 + secondNumber);
}

void v2()
{
    int number = new Random().Next(100, 1000);
    Console.WriteLine(number);

    char[] massiv = number.ToString().ToCharArray();
    Console.Write(massiv[0]);
    Console.WriteLine(massiv[2]);
}
v2();