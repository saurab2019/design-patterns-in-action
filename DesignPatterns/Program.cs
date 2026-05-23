using DesignPatterns.Proxy_Pattern.Remote_Proxy.Server;
using DesignPatterns.Proxy_Pattern.Remote_Proxy.Client;
using DesignPatterns.Proxy_Pattern.Virtual_Proxy;
using System.Threading;

//Proxy Pattern
/*Remote Proxy
GunballMachine realSubject = new GunballMachine("Gunball Machine 1", "This is a gunball machine");
GunballMachineProxy proxy = new GunballMachineProxy(realSubject);

GunballMonitor monitor = new GunballMonitor(proxy);
monitor.display();

//Switch the real subject to another gunball machine
GunballMachine realSubject2 = new GunballMachine("Gunball Machine 2", "This is another gunball machine");
proxy.setRealSubject(realSubject2);
monitor.display();
*/

//Virtual Proxy
IProxy realSubject = new RealSubject();
IProxy proxySubject = new ProxySubject(realSubject);
ImageDisplayer displayer = new ImageDisplayer(proxySubject);
displayer.DisplayImage(120, 130, "https://weather.com/image.jpg");
Thread.Sleep(4000);
displayer.DisplayImage(120, 130, "https://weather.com/image.jpg");
displayer.DisplayImage(120, 130, "https://stockpixel.com/image.jpg");