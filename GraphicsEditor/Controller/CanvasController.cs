using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Xml.Serialization;
using GeometricPrimitives;
using GraphicsEditor.Repository;

namespace GraphicsEditor.Controller
{
    public class CanvasController
    {
        private ShapeRepository _shapeRepository;

        public CanvasController()
        {
            _shapeRepository = new ShapeRepository();
        }

        public void Show(Graphics graphics)
        {
            foreach (var shape in _shapeRepository.Shapes)
            {
                shape.Draw(graphics);
            }
        }

        //TODO: implement
        #region Not implemented

        public void AddShape(Shape shape)
        {
            
        }

        public void DeleteShape(Shape shape)
        {
            
        }


        #endregion
        
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