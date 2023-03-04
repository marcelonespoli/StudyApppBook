using DesignPatterns.SingletonAndMonostate.Singleton;
using System.Reflection;

namespace Tests
{
    public class Singleton
    {
        [Fact]
        public void TestCreateSingleton()
        {
            var s1 = UserDatabaseSource.Instance;
            var s2 = UserDatabaseSource.Instance;
            Assert.Same(s1, s2);
        }

        [Fact]
        public void TestnoPublicConstructors()
        {
            Type s = typeof(UserDatabaseSource);
            ConstructorInfo[] ctrs = s.GetConstructors();
            var hasPublicConstructor = false;
            foreach (var item in ctrs)
            {
                if(item.IsPublic)
                {
                    hasPublicConstructor = true;
                    break;
                }
            }
            Assert.False(hasPublicConstructor);
        }
    }
}
