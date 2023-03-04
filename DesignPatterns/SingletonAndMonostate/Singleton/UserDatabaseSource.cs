namespace DesignPatterns.SingletonAndMonostate.Singleton
{
    public sealed class UserDatabaseSource : UserDatabase
    {
        private static UserDatabase instance = new UserDatabaseSource();

        public static UserDatabase Instance
        {
            get
            {
                return instance;
            }
        }

        private UserDatabaseSource() { }

        public User ReadUser(string username)
        {
            // some implementation here
            return new User();
        }

        public void WriteUser(User user)
        {
            // some implementation here
        }
    }
}
