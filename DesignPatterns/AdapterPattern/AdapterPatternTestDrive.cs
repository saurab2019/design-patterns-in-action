using DesignPatterns.AdapterPattern.Interfaces;

namespace DesignPatterns.AdapterPattern
{
    public class AdapterPatternTestDrive : TestDrive
    {
        public static void test()
        {
            ListClass listObj = new ListClass();
            listObj.add(1);
            listObj.add(4);
            listObj.add(5);
            listObj.add(2);
            listObj.add(1);

            Enumeration<int> enumeration = new IteratorAdapter(listObj);

            while (enumeration.hasMoreElements())
            {
               Console.WriteLine($"Elements: {enumeration.nextElement()} ");
            }
        }
    }
}