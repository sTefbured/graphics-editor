using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using System.Xml.Serialization;
using GeometricPrimitives;

namespace GraphicsEditor.Repository
{
    public class ShapeRepository
    {
        private List<Shape> _shapes;
        private readonly ShapeTypesRepository _shapeTypesRepository;

        public ShapeRepository(ShapeTypesRepository shapeTypesRepository)
        {
            _shapes = new List<Shape>();
            _shapeTypesRepository = shapeTypesRepository;
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
            try
            {
                _shapes = (List<Shape>) serializer.Deserialize(fileStream);
            }
            catch (InvalidOperationException e)
            {
                MessageBox.Show(@"Error! Type '" + e.InnerException?.Message.Split('\'')[1] +
                                @"' was not found. Are you missing a shape assembly?");
            }
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