using DesignPatterns.TemplateMethodAndStrategy.TemplateMethod.AppRunner;

namespace ConsoleAppTests
{
    public class RunFtoRaw
    {
        public RunFtoRaw()
        {
            //new FtoRaw().Execute();
            new FtoCTemplateMethod().Run();
        }

    }
}
