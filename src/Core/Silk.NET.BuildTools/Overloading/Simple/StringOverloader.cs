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
    public class StringOverloader : ISimpleParameterOverloader, ISimpleReturnOverloader
    {
        public bool TryGetParameterVariant(Parameter parameter, out Parameter variant, Project core)
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

        public bool TryGetReturnTypeVariant(Type returnType, out Type varied, Project core)
        {
            if (returnType.ToString() == "char*" || returnType.ToString() == "byte*" ||
                returnType.ToString() == "GLchar*" || returnType.ToString() == "GLbyte*" ||
                returnType.ToString() == "GLubyte*")
            {
                varied = new Type {Name = "string", IndirectionLevels = 0};
                return true;
            }

            varied = null;
            return false;
        }
    }
}
