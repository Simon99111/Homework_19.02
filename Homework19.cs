using static Shares;
public class Homework19
{
    public static void Palindrom()
    {
        int c = InputNumber();
        if ((c / 10000 == c % 10) && (c / 1000 % 10 == c / 10 % 10))
            Console.WriteLine("Yes");
        else
            Console.WriteLine("No");
    }
}