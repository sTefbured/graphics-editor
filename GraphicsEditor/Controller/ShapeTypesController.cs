using System;
using GraphicsEditor.Repository;

namespace GraphicsEditor.Controller
{
    public class ShapeTypesController
    {
        private readonly ShapeTypesRepository _shapeTypesRepository;

        public ShapeTypesController()
        {
            _shapeTypesRepository = new ShapeTypesRepository();
        }

        public void AddFromAssembly(string assemblyPath)
        {
            _shapeTypesRepository.Add(assemblyPath);
        }
    }
}