using DesignPatterns.StatePattern.Context;

namespace DesignPatterns.StatePattern
{
    public class StatePatternTestDrive : TestDrive
    {
        public static void test()
        {
            GunBallMachine gunBallMachine = new GunBallMachine(2);
            gunBallMachine.ejectQuarter();
      
            Console.WriteLine();
            gunBallMachine.insertQuarter();
            gunBallMachine.turnCrank();
            Console.WriteLine();
            gunBallMachine.insertQuarter();
            gunBallMachine.ejectQuarter();
            Console.WriteLine();
            gunBallMachine.insertQuarter();
            gunBallMachine.turnCrank();
            Console.WriteLine();
            gunBallMachine.insertQuarter();
            gunBallMachine.turnCrank();
        }
    }
}