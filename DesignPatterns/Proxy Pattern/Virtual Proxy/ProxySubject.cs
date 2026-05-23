namespace DesignPatterns.Proxy_Pattern.Virtual_Proxy
{
    public class ProxySubject : IProxy
    {
        private IProxy realSubject;
        private Image image;
        public ProxySubject(IProxy realSubject)
        {
            this.realSubject = realSubject;
        }
        public Task<Image> GetImage(double width, double height, string url, Action<Image> onLoaded)
        {
            Image result = null;
            if(image == null || image.url != url)
            {
                if(image != null)
                {
                    Console.WriteLine("Image is not loaded yet, loading previous image...");
                    result = image;
                }
                else
                {
                    Console.WriteLine("Image is not loaded yet, loading image...");
                    result = new Image(100, 100, "placeholder.jpg");   
                }
                Thread thread = new Thread(async () =>
                {
                    image = await realSubject.GetImage(width, height, url, onLoaded);
                    result = image;
                });
                thread.Start();
            }
            else
            {
                result = image;
            }
            onLoaded(result);
            return Task.FromResult(result);
        }
    }
}