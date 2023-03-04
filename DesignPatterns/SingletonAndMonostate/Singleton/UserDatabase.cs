namespace DesignPatterns.SingletonAndMonostate.Singleton
{
    public interface UserDatabase 
    {
        User ReadUser(string username);
        void WriteUser(User user);
    }

    public class User
    {

    }
}
