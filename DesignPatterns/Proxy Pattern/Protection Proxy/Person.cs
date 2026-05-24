namespace DesignPatterns.Proxy_Pattern.Protection_Proxy
{
    public interface Person
    {
        string getName();
        string getGender();
        string getInterests();
        int getGeekRating();
        void setName(string name);
        void setGender(string gender);
        void setInterests(string interests);
        void setGeekRating(int rating);
    }
}
