using DesignPatterns.Proxy_Pattern.Remote_Proxy.Server;
namespace DesignPatterns.Proxy_Pattern.Remote_Proxy.Client
{
    public class GunballMachineProxy : IProxy
    {
        public GunballMachine realSubject;

        public GunballMachineProxy(GunballMachine realSubject)
        {
            this.realSubject = realSubject;
        }

        public void setRealSubject(GunballMachine realSubject)
        {
            this.realSubject = realSubject;
        }

        public string GetName()
        {
            //Remote call to get the name of the gunball machine
            return realSubject.GetName();
        }

        public string GetDescription()
        {
            //Remote call to get the description of the gunball machine
            return realSubject.GetDescription();
        }
    }
    
}