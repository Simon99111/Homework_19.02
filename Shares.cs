public class Shares
{
    public static int InputNumber()
    {
        return Convert.ToInt32(Console.ReadLine());
    }

    




    public static void Array(int[] coordinates)
    {
        int length = 3;
        int index = 0;
        Console.WriteLine("Введите координаты x, y, z");
        while (index < length)
        {
            coordinates[index] = Convert.ToInt32(Console.ReadLine());
            index++;
        }
    }
    
}