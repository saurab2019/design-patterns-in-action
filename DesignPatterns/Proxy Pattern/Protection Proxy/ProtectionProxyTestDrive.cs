namespace DesignPatterns.Proxy_Pattern.Protection_Proxy
{
    public class ProtectionProxyTestDrive : TestDrive
    {
        public static void test()
        {
            PersonImpl person = new PersonImpl();
            IInvocationHandler ownerInvocationHandler = new OwnerInvocationHandler(person);
            IInvocationHandler nonOwnerInvocationHandler = new NonOwnerInvocationHandler(person);
            Person ownerProxy = ProxyFactory<Person>.CreateProxy(person, ownerInvocationHandler);
            Person nonOwnerProxy = ProxyFactory<Person>.CreateProxy(person, nonOwnerInvocationHandler);

            ownerProxy.setName("Alex");
            ownerProxy.setGender("Male");
            ownerProxy.setInterests("Programming");
            ownerProxy.setGeekRating(10);
            Console.WriteLine("Owner Proxy:");
            Console.WriteLine("Name: " + ownerProxy.getName());
            Console.WriteLine("Gender: " + ownerProxy.getGender());
            Console.WriteLine("Interests: " + ownerProxy.getInterests());

            nonOwnerProxy.setGeekRating(9);
            nonOwnerProxy.setInterests("Programming, Music");   
            nonOwnerProxy.setName("Alex Stark");
            Console.WriteLine("\nNon Owner Proxy:");
            Console.WriteLine("Name: " + nonOwnerProxy.getName());
            Console.WriteLine("Gender: " + nonOwnerProxy.getGender());
            Console.WriteLine("Interests: " + nonOwnerProxy.getInterests());  

            Console.WriteLine("Geek Rating: " + ownerProxy.getGeekRating());
            nonOwnerProxy.setGeekRating(8); 
            Console.WriteLine("Geek Rating: " + ownerProxy.getGeekRating());
            nonOwnerProxy.setGeekRating(4); 
            Console.WriteLine("Geek Rating: " + ownerProxy.getGeekRating());
            nonOwnerProxy.setGeekRating(9); 
            Console.WriteLine("Geek Rating: " + ownerProxy.getGeekRating());
            nonOwnerProxy.setGeekRating(10); 
            Console.WriteLine("Geek Rating: " + ownerProxy.getGeekRating());
            nonOwnerProxy.setGeekRating(10); 
            Console.WriteLine("Geek Rating: " + ownerProxy.getGeekRating());
            nonOwnerProxy.setGeekRating(10); 
            Console.WriteLine("Geek Rating: " + ownerProxy.getGeekRating());
            nonOwnerProxy.setGeekRating(10); 
            Console.WriteLine("Geek Rating: " + ownerProxy.getGeekRating());

            nonOwnerProxy.setGeekRating(10); 
            Console.WriteLine("Geek Rating: " + ownerProxy.getGeekRating());


        }
    }
}