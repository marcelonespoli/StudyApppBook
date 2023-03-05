namespace DesignPatterns.SingletonAndMonostate.Monostate.SimpleExample
{
    public class Monostate
    {
        private static int x;

        public int X
        {
            get { return x; }
            set { x = value; }
        }
    }
}
