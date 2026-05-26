namespace DesignPatterns.SingletonPattern
{
    public class SingletonPatternTestDrive : TestDrive
    {
        public static void test()
        {
            Singleton databaseConnection = Singleton.Instance;
            databaseConnection.connectionPoolSize = 11;
            Console.WriteLine($"Pool Size: {databaseConnection.connectionPoolSize}");
            Singleton appConnection = Singleton.Instance;
            Console.WriteLine($"Pool Size: {appConnection.connectionPoolSize}");
        }
    }
}