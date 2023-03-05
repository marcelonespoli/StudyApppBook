namespace DesignPatterns.SingletonAndMonostate.Monostate
{
    internal class Locked : Turnstile
    {
        public override void Coin()
        {
            State = UNLOCKED;
            Lock(false);
            Alarm(false);
            Deposit();
        }

        public override void Pass()
        {
            Alarm(true);
        }
    }
}
