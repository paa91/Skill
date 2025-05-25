
class MyClass 
{
    public static void Main (string[] args) 
    {
        Console.WriteLine(PowerUp(8, 6));
    }
    private static int PowerUp(int N, byte pow)
    {
        if (pow == 0)
        {
            return 1;
        }
        else 
        {
            if (pow == 1)
                return N;
            else 
            {
                return N * PowerUp(N, --pow);
            }
        }
    }
}