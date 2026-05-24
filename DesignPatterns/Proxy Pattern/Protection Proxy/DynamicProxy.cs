using System.Reflection;

namespace DesignPatterns.Proxy_Pattern.Protection_Proxy
{
    public class DynamicProxy<T> : DispatchProxy
    {
        public T Target{get;set;}
        public IInvocationHandler Handler{get;set;}

        protected override object? Invoke(MethodInfo? targetMethod, object?[]? args)
        {
            return Handler.invoke(Target, targetMethod, args);
        }
    }
}