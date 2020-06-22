// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using Silk.NET.BuildTools.Common;
using Silk.NET.BuildTools.Common.Functions;

namespace Silk.NET.BuildTools.Overloading
{
    public interface IFunctionOverloader
    {
        bool TryCreateVariant(Parameter parameter, out Parameter variant, Project core);
        bool TryCreateVariant(Type returnType, out Type variant, Project core);
        bool TryCreateVariant(Function function, out Function variant, Project core);
        bool TryCreateOverload(Function function, out ImplementedFunction overload, Project core);
    }
}
