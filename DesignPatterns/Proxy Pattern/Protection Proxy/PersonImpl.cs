namespace DesignPatterns.Proxy_Pattern.Protection_Proxy
{
    public class PersonImpl : Person
    {
        private string name;
        private string gender;
        private string interests;
        private int geekRating;
        private static int totalRating = 0;
        private static int ratingCount = 0;
        public string getName()
        {
            return name;
        }
        public string getGender()
        {
            return gender;

        }
        public string getInterests()
        {
            return interests;
        }
        public int getGeekRating()
        {
            return geekRating;
        }
        public void setName(string name)
        {
            this.name = name;
        }
        public void setGender(string gender)
        {
            this.gender = gender;
        }
        public void setInterests(string interests)
        {
            this.interests = interests;
        }
        public void setGeekRating(int geekRating)
        {
            Console.WriteLine("Updating geek rating...");
            totalRating += geekRating;
            
            this.geekRating = totalRating / ++ratingCount;
        
        }

    }
}