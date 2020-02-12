// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using System.Collections.Generic;
using Silk.NET.BuildTools.Common.Functions;

namespace Silk.NET.BuildTools.Converters.Permutations
{
    public class StaticCountOverloader : IParameterOverloader
    {
        public bool IsApplicable(ParameterOverloadContext parameter) => parameter.Parameter.Count.StaticCount > 1;

        public bool IsApplicable(Type type) => false;

        public IEnumerable<Parameter> GetParameterPermutations(ParameterOverloadContext parameter)
        {
            
        }

        public IEnumerable<Type> GetReturnTypePermutations(Type type)
        {
            throw new System.NotImplementedException();
        }
    }
}
