namespace DesignPatterns.Proxy_Pattern.Virtual_Proxy
{
    public class RealSubject : IProxy
    {
        public Task<Image> GetImage(double width, double height, string url, Action<Image> onLoaded)
        {
            Thread.Sleep(4000); // Simulating time-consuming operation
            Console.WriteLine("Loading image with width: " + width + " and height: " + height + ", url: " + url);
            onLoaded(new Image(width, height, url));
            return Task.FromResult(new Image(width, height, url));
        }
    }
}