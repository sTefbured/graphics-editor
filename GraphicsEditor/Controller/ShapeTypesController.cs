using System;
using System.Collections.Generic;
using GraphicsEditor.Repository;

namespace GraphicsEditor.Controller
{
    public class ShapeTypesController
    {
        private readonly ShapeTypesRepository _shapeTypesRepository;

        public ShapeTypesController(ShapeTypesRepository shapeTypesRepository)
        {
            _shapeTypesRepository = shapeTypesRepository;
        }

        public ICollection<Type> AddFromAssembly(string assemblyPath)
        {
            return _shapeTypesRepository.Add(assemblyPath);
        }
    }
}