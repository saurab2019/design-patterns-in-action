using DesignPatterns.Proxy_Pattern.Remote_Proxy.Client;
using DesignPatterns.Proxy_Pattern.Remote_Proxy.Server;

namespace DesignPatterns.Proxy_Pattern.Remote_Proxy
{
    public class RemoteProxyTestDrive : TestDrive
    {
        public static void test()
        {
            GunballMachine realSubject = new GunballMachine("Gunball Machine 1", "This is a gunball machine");
            GunballMachineProxy proxy = new GunballMachineProxy(realSubject);

            GunballMonitor monitor = new GunballMonitor(proxy);
            monitor.display();

            //Switch the real subject to another gunball machine
            GunballMachine realSubject2 = new GunballMachine("Gunball Machine 2", "This is another gunball machine");
            proxy.setRealSubject(realSubject2);
            monitor.display();
        }
    }
}