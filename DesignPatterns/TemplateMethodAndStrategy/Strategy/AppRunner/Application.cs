namespace DesignPatterns.TemplateMethodAndStrategy.Strategy.AppRunner
{
    public interface Application
    {
        void Init();
        void Idle();
        void CleanUp();
        bool Done();
    }
}
