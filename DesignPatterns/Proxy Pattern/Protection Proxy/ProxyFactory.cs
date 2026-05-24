using System.Reflection;

namespace DesignPatterns.Proxy_Pattern.Protection_Proxy
{
    public static class ProxyFactory<T>
    {
        public static T CreateProxy(T realSubject, IInvocationHandler invocationHandler)
        {
            T proxy = DispatchProxy.Create<T, DynamicProxy<T>>();

            // Cast to actual proxy implementation
            DynamicProxy<T> dynamicProxy =
                (DynamicProxy<T>)(object)proxy;

            dynamicProxy.Target = realSubject;
            dynamicProxy.Handler = invocationHandler;
            return proxy;
        }
    }
}