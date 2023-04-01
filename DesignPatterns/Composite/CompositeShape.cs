using DesignPatterns.Composite.Interfaces;
using System.Collections;

namespace DesignPatterns.Composite
{
    public class CompositeShape : Shape
    {
        private ArrayList shapes = new ArrayList();

        public void Add(Shape shape)
        {
            shapes.Add(shape);
        }

        public void Draw()
        {
            foreach (Shape shape in shapes)
                shape.Draw();
        }
    }
}
