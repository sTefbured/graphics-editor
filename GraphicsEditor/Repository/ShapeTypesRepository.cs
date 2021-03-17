using System;
using System.Collections.Generic;
using System.Reflection;
using GeometricPrimitives;

namespace GraphicsEditor.Repository
{
    public class ShapeTypesRepository
    {
        public HashSet<Type> ShapeTypes { get; }

        public ShapeTypesRepository()
        {
            ShapeTypes = new HashSet<Type>();
        }

        private ICollection<Type> GetTypesFromAssembly(string assemblyPath)
        {
            Assembly assembly = Assembly.LoadFile(assemblyPath);
            Type[] loadedTypes = assembly.GetTypes();
            ICollection<Type> shapeTypes = new List<Type>();
            foreach (var type in loadedTypes)
            {
                if (type.IsSubclassOf(typeof(Shape)))
                {
                    ShapeTypes.Add(type);
                }
            }
            return shapeTypes;
        }

        public void Add(string assemblyPath)
        {
            foreach (var type in GetTypesFromAssembly(assemblyPath))
            {
                ShapeTypes.Add(type);
            }
        }
    }
}