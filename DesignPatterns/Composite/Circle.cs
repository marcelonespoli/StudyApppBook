using DesignPatterns.Composite.Interfaces;

namespace DesignPatterns.Composite
{  
    public class Circle : Shape
    {
        public string Result { get; private set; }
        public void Draw()
        {
            Result = "Drawing a circle"; 
        }
    }
}
