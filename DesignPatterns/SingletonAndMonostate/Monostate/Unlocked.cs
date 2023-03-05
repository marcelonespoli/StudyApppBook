namespace DesignPatterns.SingletonAndMonostate.Monostate
{
    internal class Unlocked : Turnstile
    {
        public override void Coin()
        {
            Refound();
        }

        public override void Pass()
        {
            Lock(true);
            State = LOCKED;
        }
    }
}
