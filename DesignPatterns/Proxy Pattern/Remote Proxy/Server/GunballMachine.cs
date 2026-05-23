namespace DesignPatterns.Proxy_Pattern.Remote_Proxy.Server
{
    public class GunballMachine : IProxy
    {
        private string Name;
        private string Description;

        public GunballMachine(string name, string description)
        {
            Name = name;
            Description = description;
        }

        public string GetName()
        {
            return Name;
        }
        public string GetDescription()
        {
            return Description;
        }
    }
}
