namespace DesignPatterns.Proxy_Pattern.Virtual_Proxy
{
    public class ImageDisplayer
    {
        private IProxy realSubject;

        public ImageDisplayer(IProxy realSubject)
        {
            this.realSubject = realSubject;
        }

        public void DisplayImage(double width, double height, string url)
        {
            realSubject.GetImage(width, height, url, (image) => {
                Console.WriteLine("Image loaded successfully, now displaying the image...");
                Console.WriteLine("Image details: width: " + image.width + ", height: " + image.height + ", url: " + image.url);
                Console.WriteLine("Image displayed successfully.");
                Console.WriteLine();
            });
        }
    }
}