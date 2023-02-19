using static Shares;
public class Homework21
{
public static void Distance()
    {
        int[] dot1 = new int[3];
        int[] dot2 = new int[3];
        Array(dot1);
        Array(dot2);
        double result = Math.Sqrt(Math.Pow((dot2[0] - dot1[0]), 2) + Math.Pow((dot2[1] - dot1[1]), 2) + Math.Pow((dot2[2] - dot1[2]), 2));
        Console.WriteLine("Расстояние между точками = " + result);
    }

}