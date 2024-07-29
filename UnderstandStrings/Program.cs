

internal class Program
{
    private static void Main(string[] args)
    {
        StrFormat();
        JoinAndSplit();
    }

    static void StrFormat(){
        string str = "Hello {0} my name is {1}----{0}";
        Console.WriteLine(str);
        str = string.Format(str, "mohamed", "ahmed");
        Console.WriteLine(str);

        // save 15 char spaces for first name {0, 15}
        string name = "My name is {0, 15}{1}";
        name = string.Format(name, "ahmed", "alfrash");
        Console.WriteLine(name);

        double salary = 10000;
        string yourSalary = "your salary is {0:C2}";
        yourSalary = string.Format(yourSalary, salary);
        Console.WriteLine(yourSalary);

        double num = 156;
        string yourNumber = "your number is {0:N2}";
        yourNumber = string.Format(yourNumber, num);
        Console.WriteLine(yourNumber);
    }

    static void JoinAndSplit() {
        // Split with ,
        Console.Write("enter numbers split with , :");
        string input = Console.ReadLine()!;
        string[] numbers = input.Split(",");
        float sum = 0;
        foreach (var num in numbers)
        {
            sum += float.Parse(num);
        }
        Console.WriteLine($"Average = {sum / numbers.Length}");

        // Join
        string[] myName = ["ahmed", "mohamed", "alfrash",];
        string name = string.Join(" ", myName);
        Console.WriteLine(name);
    }
}