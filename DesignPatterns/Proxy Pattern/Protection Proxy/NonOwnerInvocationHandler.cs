using System.Reflection;

namespace DesignPatterns.Proxy_Pattern.Protection_Proxy
{
    public class NonOwnerInvocationHandler : IInvocationHandler
    {
        Person realSubject;
        public NonOwnerInvocationHandler(Person realSubject)
        {
            this.realSubject = realSubject;
        }
        public object invoke(object proxy, MethodInfo method, object[] args)
        {
            try
            {
                if(method.Name.StartsWith("get"))
                {
                    return method.Invoke(realSubject, args);
                }
                else if(method.Name.Equals("setGeekRating"))
                {
                    return method.Invoke(realSubject, args);
                }
                else
                {
                    throw new InvalidOperationException("Non owner cannot set personal info");
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine("Exception: " + ex.Message);
            }
            return null;
        }
    }
}