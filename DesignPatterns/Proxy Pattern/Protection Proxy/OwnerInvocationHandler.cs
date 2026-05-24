using System.Reflection;

namespace DesignPatterns.Proxy_Pattern.Protection_Proxy
{
    public class OwnerInvocationHandler : IInvocationHandler
    {
        Person realSubject;
        public OwnerInvocationHandler(Person realSubject)
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
                    throw new InvalidOperationException("Owner cannot set geek rating");
                }
                else if(method.Name.StartsWith("set"))
                {
                    return method.Invoke(realSubject, args);
                }
                else
                {
                    throw new InvalidOperationException("Invalid method call");
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