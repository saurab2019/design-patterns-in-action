using DesignPatterns.DecoratorPattern.Decorators;

namespace DesignPatterns.DecoratorPattern
{
    public class DecoratorPatternTestDrive : TestDrive
    {
        public static void test()
        {
            //Double Mocha soy latte with whip
            Beverage coffee = new Whip(new Soy(new Mocha(new Mocha(new HouseBlend("Latte")))));

            Console.WriteLine(coffee.getDescription());
            Console.WriteLine($"Total cost {coffee.getDescription()}: {coffee.cost()}");
        }
    }
}