void v1()
{
    Console.WriteLine("input number");
    string? numb = Console.ReadLine();
    if (numb != null)
    {
        int per = Int32.Parse(numb);
        Console.WriteLine((per % 7 == 0 && per % 23 == 0) ? ("kratno 7&23") : ("ne kratno"));
    }
}


void v2()
{
    int num, resultA, resultB;
    int RequestNumber(string text = "Input number", string exitCmd = "q")
    {
        while (true)
        {
            Console.Write(text + ":");
            string? inputLine = Console.ReadLine();

            if (inputLine == null)
            {
                continue;
            }
            if (inputLine.ToLower() == exitCmd)
            {
                Environment.Exit(0);
            }
            if (int.TryParse(inputLine, out int number))
            {
                return number;
            }
        }
    }
    void readData()
    {
        num = RequestNumber();
    }
    void calc()
    {
        resultA = num % 7;
        resultB = num % 23;
    }
    void printData()
    {
        if (resultA == 0 && resultB == 0)
        {
            Console.WriteLine("kratno 7 & 23");
        }
        else
        {
            Console.WriteLine("ne kratno 7 & 23");
        }
    }

}
    

void v3()
{
    string? num = Console.ReadLine();
    if(num != null)
    Console.WriteLine(((Int32.Parse(num))%7 ==0) && ((Int32.Parse(num))%23 ==0)?("Kratno"):("Ne kratno") );
}

v3();