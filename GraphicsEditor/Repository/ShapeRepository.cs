using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml.Serialization;
using GeometricPrimitives;

namespace GraphicsEditor.Repository
{
    public class ShapeRepository
    {
        private List<Shape> _shapes;
        private readonly ShapeTypesRepository _shapeTypesRepository;

        public ShapeRepository()
        {
            _shapes = new List<Shape>();
            _shapeTypesRepository = new ShapeTypesRepository();
        }

        public void SaveToFile(string filePath)
        {
            FileStream fileStream = File.OpenWrite(filePath);
            Type[] shapeTypes = _shapeTypesRepository.ShapeTypes.ToArray();
            XmlSerializer serializer = new XmlSerializer(typeof(List<Shape>), shapeTypes);
            serializer.Serialize(fileStream, _shapes);
            fileStream.Close();
        }

        public void LoadFromFile(string filePath)
        {
            FileStream fileStream = File.OpenRead(filePath);
            Type[] shapeTypes = _shapeTypesRepository.ShapeTypes.ToArray();
            XmlSerializer serializer = new XmlSerializer(typeof(List<Shape>), shapeTypes);
            _shapes = (List<Shape>) serializer.Deserialize(fileStream);
            fileStream.Close();
        }

        public ICollection<Shape> GetAll()
        {
            return _shapes;
        }

        public void Add(Shape shape)
        {
            _shapes.Add(shape);
        }
    }
}