using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Text.Json;
using System.Xml.Serialization;
using GeometricPrimitives;
using Line = Line.Line;

namespace GraphicsEditor
{
    public class Canvas
    {
        private ICollection<Shape> _shapes;

        public Canvas()
        {
            _shapes = new List<Shape>();
        }

        public void Show(Graphics graphics)
        {
            Rectangle rect = new Rectangle(200, 200, -50, -50);
            graphics.DrawRectangle(Pens.Black, rect.X, rect.Y, rect.Width, rect.Height);
            foreach (var shape in _shapes)
            {
                shape.Draw(graphics);
            }
        }

        public void AddShape(Shape shape)
        {
            _shapes.Add(shape);
        }

        public void DeleteShape(Shape shape)
        {
            _shapes.Remove(shape);
        }

        public void Save(string path)
        {
            FileStream fileStream = File.OpenWrite(path);
            foreach (var shape in _shapes)
            {
                XmlSerializer serializer = new XmlSerializer(typeof(Shape), new[]{typeof(global::Line.Line)});
                serializer.Serialize(fileStream, shape);
            }
            fileStream.Close();
        }
        
        public void Load(string path)
        {
            _shapes = new List<Shape>();
            FileStream fileStream = File.OpenRead(path);
            XmlSerializer serializer = new XmlSerializer(typeof(Shape), new[] {typeof(global::Line.Line)});
            Shape shape = (Shape)serializer.Deserialize(fileStream);
            _shapes.Add(shape);
        }
    }
}