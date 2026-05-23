namespace DesignPatterns.Proxy_Pattern.Remote_Proxy.Client
{
    public class GunballMonitor 
    {
        IProxy GunballMachine;

        public GunballMonitor(IProxy gunballMachine)
        {
            GunballMachine = gunballMachine;
        }

        public void display()
        {
            Console.WriteLine("Gunball Machine: " + GunballMachine.GetName());
            Console.WriteLine("Description: " + GunballMachine.GetDescription());
            Console.WriteLine("-----------------------------");
        }
    }
}