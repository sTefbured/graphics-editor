using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using GeometricPrimitives;

namespace GraphicsEditor.Repository
{
    public class ShapeTypesRepository
    {
        public List<Type> ShapeTypes { get; }

        public ShapeTypesRepository()
        {
            ShapeTypes = new List<Type>();
        }

        private ICollection<Type> GetTypesFromAssembly(string assemblyPath)
        {
            Assembly assembly = Assembly.LoadFrom(assemblyPath);
            Type[] loadedTypes = assembly.GetTypes();
            ICollection<Type> shapeTypes = new List<Type>();
            foreach (var type in loadedTypes)
            {
                if (type.IsSubclassOf(typeof(Shape)))
                {
                    shapeTypes.Add(type);
                }
            }
            return shapeTypes;
        }

        public ICollection<Type> Add(string assemblyPath)
        {
            ICollection<Type> types = GetTypesFromAssembly(assemblyPath);
            foreach (var type in types)
            {
                ShapeTypes.Add(type);
            }

            return types;
        }
    }
}