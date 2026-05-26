namespace DesignPatterns.TemplateMethodPattern
{
    public class TemplateMethodPatternTestDrive : TestDrive
    {
        public static void test()
        {
            CafeBeverage beverage = new Tea();
            beverage.prepare();
            Console.WriteLine();
            beverage = new Coffee();
            beverage.prepare();
        }
    }
}