namespace DesignPatterns.Proxy_Pattern.Virtual_Proxy
{
    public class Image
    {
        public double width { get; private set; }
        public double height { get; private set; }
        public string url { get; private set; }

        public Image(double width, double height, string url)
        {
            this.width = width;
            this.height = height;
            this.url = url;
        }
    }
}