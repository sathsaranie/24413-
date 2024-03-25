internal class Program
{
    private static void Main(string[] args)
    {
        int[] numbers = { 10, 20, 30, 40, 50, 60, 70, 80, 90, 100 };
        double total = 0;
        double average= 0;

        foreach (int i in numbers)
        {
            total += i;
        }
        average = total / numbers.Length;
        Console.WriteLine("total =" + total +" , average="+average); 
       

    }
}