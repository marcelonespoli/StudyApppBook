namespace DesignPatterns.TemplateMethodAndStrategy.TemplateMethod.AppRunner
{
    public class FtoCTemplateMethod : Application
    {
        private TextReader input;
        private TextWriter output;

        protected override void Init()
        {
            input = Console.In;
            output = Console.Out;
        }

        protected override void Idle()
        {
            var fahrString = input.ReadLine();
            if (fahrString == null || fahrString.Length == 0)
                SetDone();
            else
            {
                var fahr = double.Parse(fahrString);
                var celcius = 5.0 / 9.0 * (fahr - 32);
                output.WriteLine($"F = {fahr}, C = {celcius}");
            }
        }

        protected override void CleanUp()
        {
            output.WriteLine("ftco exit");
        }
    }
}
