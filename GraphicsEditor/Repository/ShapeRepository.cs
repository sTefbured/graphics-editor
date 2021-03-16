using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Xml.Serialization;
using GeometricPrimitives;
using GraphicsEditor.MockModel;

namespace GraphicsEditor.Repository
{
    public class ShapeRepository
    {
        public List<Shape> Shapes { get; private set; }

        public ShapeRepository()
        {
            Shapes = new List<Shape>();
            // MockLine mockLine1 = new MockLine(new Point(50, 100), new Point(70, 50));
            // mockLine1.Initialize();
            // MockLine mockLine2 = new MockLine(new Point(100, 80), new Point(70, 50));
            // mockLine2.Initialize();
            // Shapes = new List<Shape>
            // {
            //     mockLine1,
            //     mockLine2
            // };
        }

        public void SaveToFile(string filePath)
        {
            FileStream fileStream = File.OpenWrite(filePath);
            XmlSerializer serializer = new XmlSerializer(typeof(List<Shape>), new[] {typeof(MockLine)});
            serializer.Serialize(fileStream, Shapes);
            fileStream.Close();
        }

        public void LoadFromFile(string filePath)
        {
            Shapes = new List<Shape>();
            FileStream fileStream = File.OpenRead(filePath);
            XmlSerializer serializer = new XmlSerializer(typeof(List<Shape>), new[] {typeof(MockLine)});
            Shapes = (List<Shape>) serializer.Deserialize(fileStream);
            fileStream.Close();
        }
    }
}