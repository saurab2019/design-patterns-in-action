using DesignPatterns.FactoryMethodPattern.PizzaStore;

namespace DesignPatterns.FactoryMethodPattern
{
    public class FactoryMethodPatternTestDrive : TestDrive
    {
        public static void test()
        {
            IPizzaStore store = new NYPizzaStore();
            store.orderPizza("cheese");
            Console.WriteLine();
            store.orderPizza("greek");
            Console.WriteLine();
            store = new ChicgoPizzaStore();
            store.orderPizza("cheese");
            Console.WriteLine();
            store.orderPizza("greek");
            Console.WriteLine();
        }
    }
}