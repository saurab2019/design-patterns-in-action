using DesignPatterns.Proxy_Pattern.Virtual_Proxy;

namespace DesignPatterns.Proxy_Pattern.Virtual_Proxy
{
    public class VirtualProxyTestDrive : TestDrive
    {
        public static void test()
        {
            IProxy realSubject = new RealSubject();
            IProxy proxySubject = new ProxySubject(realSubject);
            ImageDisplayer displayer = new ImageDisplayer(proxySubject);
            displayer.DisplayImage(120, 130, "https://weather.com/image.jpg");
            Thread.Sleep(4000);
            displayer.DisplayImage(120, 130, "https://weather.com/image.jpg");
            displayer.DisplayImage(120, 130, "https://stockpixel.com/image.jpg");
        }
    }
}
