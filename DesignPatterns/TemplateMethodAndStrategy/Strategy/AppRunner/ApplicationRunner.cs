namespace DesignPatterns.TemplateMethodAndStrategy.Strategy.AppRunner
{
    public class ApplicationRunner
    {
        private readonly Application _application;

        public ApplicationRunner(Application application)
        {
            _application = application;
        }

        public void Run()
        {
            _application.Init();
            while (!_application.Done())
            {
                _application.Idle();
            }
            _application.CleanUp();
        }
    }
}
