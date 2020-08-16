// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using System.Collections.Generic;
using Silk.NET.BuildTools.Common;
using Silk.NET.BuildTools.Common.Builders;
using Silk.NET.BuildTools.Common.Functions;

namespace Silk.NET.BuildTools.Overloading
{
    public class StringOverloader : IFunctionOverloader
    {
        public bool TryCreateVariant(Parameter parameter, out Parameter variant, Project core)
        {
            if (parameter.Type.ToString() == "char*" || parameter.Type.ToString() == "byte*" ||
                parameter.Type.ToString() == "GLchar*" || parameter.Type.ToString() == "GLbyte*" ||
                parameter.Type.ToString() == "GLubyte*")
            {
                var variantBuilder = new ParameterSignatureBuilder(parameter)
                    .WithType
                    (
                        new Type
                        {
                            Name = "string", IndirectionLevels = 0,
                            IsOut = parameter.Flow == FlowDirection.Out &&
                                    ((parameter.Count?.IsStatic ?? false) || (parameter.Count?.IsReference ?? false))
                        }
                    );
                
                if (!(parameter.Flow == FlowDirection.Out &&
                    ((parameter.Count?.IsStatic ?? false) || (parameter.Count?.IsReference ?? false))))
                {
                    variantBuilder = variantBuilder.WithCount(null);
                }

                variant = variantBuilder.Build();

                return true;
            }

            variant = null;
            return false;
        }

        public bool TryCreateVariant(Type returnType, out Type variant, Project core)
        {
            if (returnType.ToString() == "char*" || returnType.ToString() == "byte*" ||
                returnType.ToString() == "GLchar*" || returnType.ToString() == "GLbyte*" ||
                returnType.ToString() == "GLubyte*")
            {
                variant = new Type {Name = "string", IndirectionLevels = 0};
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
