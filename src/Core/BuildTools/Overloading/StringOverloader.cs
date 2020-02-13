// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using Silk.NET.BuildTools.Common;
using Silk.NET.BuildTools.Common.Builders;
using Silk.NET.BuildTools.Common.Functions;

namespace Silk.NET.BuildTools.Overloading
{
    public class StringOverloader : IFunctionOverloader
    {
        public bool TryCreateVariant(Parameter parameter, out Parameter variant, Project core)
        {
            if (parameter.Type.ToString() == "char*" || parameter.Type.ToString() == "byte*")
            {
                variant = new ParameterSignatureBuilder(parameter).WithType(new Type{Name = "string"}).Build();
                return true;
            }

            variant = null;
            return false;
        }

        public bool TryCreateVariant(Type returnType, out Type variant, Project core)
        {
            if (returnType.ToString() == "char*" || returnType.ToString() == "byte*")
            {
                variant = new Type{Name = "string"};
                return true;
            }

            variant = null;
            return false;
        }

        public bool TryCreateVariant(Function function, out Function variant, Project core)
        {
            variant = null;
            return false;
        }

        public bool TryCreateOverload(Function function, out ImplementedFunction overload, Project core)
        {
            overload = null;
            return false;
        }
    }
}
