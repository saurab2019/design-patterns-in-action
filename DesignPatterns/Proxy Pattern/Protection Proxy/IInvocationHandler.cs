using System.Reflection;

namespace DesignPatterns.Proxy_Pattern.Protection_Proxy
{
    public interface IInvocationHandler
    {
        object invoke(object proxy, MethodInfo method, object[] args);
    }
}
