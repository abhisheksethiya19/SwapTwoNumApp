using System;
class First
{
    static void Main()
    {
        string a, b;
        int temp, c, d;
        Console.Write("Enter value for a :");
        a = Console.ReadLine();
        c = Convert.ToInt32(a);
        Console.WriteLine("A's value is {0}", c);
        Console.Write("Enter value for b : ");
        b = Console.ReadLine();
        d = Convert.ToInt32(b);
        Console.WriteLine("B's value is {0}", d);
        temp = c;
        c = d;
        d = temp;
        Console.WriteLine("Values after swapping are:");
        Console.WriteLine("a is : " + c);
        Console.WriteLine("b is : " + d);
    }
}
