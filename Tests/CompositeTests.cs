using DesignPatterns.Composite;

namespace Tests
{
    public class CompositeTests
    {
        [Fact] 
        public void TestComposite() 
        {
            var circle = new Circle();
            var square = new Square();
            var composite = new CompositeShape();
            composite.Add(circle);
            composite.Add(square);

            composite.Draw();
            Assert.Equal("Drawing a circle", circle.Result);
            Assert.Equal("Drawing a square", square.Result);
        }
    }
}
