class Program1
{
    private static void Main(string[] args)
    {
        Thread cherepaha = new(MyThreadCherepaha);
        cherepaha.Start();

        for (int i = 0; i < 100; i++)
        {
            Console.WriteLine("Кролик пробежал: " + i);
        }
    }
    static void MyThreadCherepaha()
    {
        for (int i = 0; i < 100; i++)
        {
            Console.WriteLine("Черепаха пробежала: " + i);
        }
    }
}