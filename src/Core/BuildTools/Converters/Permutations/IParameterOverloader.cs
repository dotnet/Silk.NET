// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using System.Collections.Generic;
using Silk.NET.BuildTools.Common.Functions;

namespace Silk.NET.BuildTools.Converters.Permutations
{
    public interface IParameterOverloader
    {
        bool IsApplicable(Parameter parameter);
        bool IsApplicable(Type type);
        IEnumerable<Parameter> GetParameterPermutations(ParameterOverloadContext parameter);
        IEnumerable<Type> GetReturnTypePermutations(Type type);
    }
}
