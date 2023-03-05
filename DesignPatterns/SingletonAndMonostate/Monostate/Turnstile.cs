namespace DesignPatterns.SingletonAndMonostate.Monostate
{
    public class Turnstile
    {
        private static bool isLocked = true;
        private static bool isAlarming = false;
        private static int coins = 0;
        private static int refounds = 0;
        protected static readonly Turnstile LOCKED = new Locked();
        protected static readonly Turnstile UNLOCKED = new Unlocked();
        protected static Turnstile State = LOCKED;

        public void Reset()
        {
            Lock(true);
            Alarm(false);
            coins = 0;
            refounds = 0;
            State = LOCKED;
        }

        public bool IsLocked()
        {
            return isLocked;
        }

        public bool Alarm()
        {
            return isAlarming;
        }

        public virtual void Coin()
        {
            State.Coin();
        }

        public virtual void Pass()
        {
            State.Pass();
        }

        protected void Lock(bool shouldLock)
        {
            isLocked = shouldLock;
        }

        protected void Alarm(bool shouldAlarm)
        {
            isAlarming = shouldAlarm;
        }

        public int Coins
        {
            get { return coins; }
        }

        public int Refounds
        {
            get { return refounds; }
        }

        public void Deposit()
        {
            coins++;
        }

        public void Refound()
        {
            refounds++;
        }
    }
}
