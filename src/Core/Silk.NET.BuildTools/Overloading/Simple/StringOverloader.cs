// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Collections.Generic;
using Silk.NET.BuildTools.Common;
using Silk.NET.BuildTools.Common.Builders;
using Silk.NET.BuildTools.Common.Functions;

namespace Silk.NET.BuildTools.Overloading
{
    public class StringOverloader : ISimpleParameterOverloader, ISimpleReturnOverloader
    {
        public bool TryGetParameterVariant(Parameter parameter, out Parameter variant, Profile _)
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
                                    ((parameter.Count?.IsStatic ?? false) || (parameter.Count?.IsReference ?? false)),
                            OriginalName = parameter.Type.OriginalName
                        }
                    );
                
                if (!(parameter.Flow == FlowDirection.Out &&
                    ((parameter.Count?.IsStatic ?? false) || (parameter.Count?.IsReference ?? false))))
                {
                    variantBuilder = variantBuilder.WithCount(null);
                }

                variant = variantBuilder.Build();
                variant.Attributes.Add
                (
                    new()
                    {
                        Name = "UnmanagedType",
                        Arguments = new() { variant.Type.MapUnmanagedType() }
                    }
                );

                return true;
            }

            variant = null;
            return false;
        }

        public bool TryGetReturnTypeVariant(Type returnType, out Type varied, List<Attribute> attrs, Profile _)
        {
            if (returnType.ToString() == "char*" || returnType.ToString() == "byte*" ||
                returnType.ToString() == "GLchar*" || returnType.ToString() == "GLbyte*" ||
                returnType.ToString() == "GLubyte*")
            {
                varied = new Type {Name = "string", IndirectionLevels = 0, OriginalName = returnType.OriginalName};
                attrs.Add
                (
                    new()
                    {
                        Name = "return: UnmanagedType",
                        Arguments = new() { varied.MapUnmanagedType() }
                    }
                );

                return true;
            }

            varied = null;
            return false;
        }
    }
}
