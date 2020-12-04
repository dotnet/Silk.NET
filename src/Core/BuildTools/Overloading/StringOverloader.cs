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
                variant = new ParameterSignatureBuilder(parameter)
                    .WithType
                    (
                        new Type
                        {
                            Name = "string", IndirectionLevels = 0,
                            IsOut = parameter.Flow == FlowDirection.Out &&
                                    ((parameter.Count?.IsStatic ?? false) || (parameter.Count?.IsReference ?? false))
                        }
                    )
                    .WithCount(null) // scrap the count as it causes trouble later down the line
                    .Build();

                if (variant.Type.IsOut)
                {
                    variant.Attributes.Add
                    (
                        new Attribute
                        {
                            Name = "Ultz.SuperInvoke.InteropServices.CountAttribute",
                            Arguments = new List<string>
                            {
                                parameter.Count.IsStatic
                                    ? "Ultz.SuperInvoke.InteropServices.CountType.Constant"
                                    : "Ultz.SuperInvoke.InteropServices.CountType.ParameterReference",
                                (parameter.Count.IsStatic
                                    ? parameter.Count.StaticCount
                                    : parameter.Origin.Parameters.FindIndex
                                          (x => x.Name == parameter.Count.ValueReference) -
                                      parameter.Origin.Parameters.IndexOf(parameter)).ToString()
                            }
                        }
                    );
                }

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
                variant = new Type { Name = "string", IndirectionLevels = 0 };
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
