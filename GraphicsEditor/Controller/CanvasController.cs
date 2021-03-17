using System.Drawing;
using GeometricPrimitives;
using GraphicsEditor.Repository;

namespace GraphicsEditor.Controller
{
    public class CanvasController
    {
        private readonly ShapeRepository _shapeRepository;

        public CanvasController()
        {
            _shapeRepository = new ShapeRepository();
        }

        public void Show(Graphics graphics)
        {
            foreach (var shape in _shapeRepository.GetAll())
            {
                shape.Draw(graphics);
            }
        }
        
        public void AddShape(Shape shape)
        {
            _shapeRepository.Add(shape);
        }

        //TODO: implement
        public void DeleteShape(Shape shape)
        {
            
        }
        
        public void Save(string path)
        {
            _shapeRepository.SaveToFile(path);
        }
        
        public void Load(string path)
        {
            _shapeRepository.LoadFromFile(path);
        }
    }
}