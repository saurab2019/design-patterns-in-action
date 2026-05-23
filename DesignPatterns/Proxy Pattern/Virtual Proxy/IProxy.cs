namespace DesignPatterns.Proxy_Pattern.Virtual_Proxy
{
    public interface IProxy
    {
        Task<Image> GetImage(double width, double height, string url, Action<Image> onLoaded);
    }
}