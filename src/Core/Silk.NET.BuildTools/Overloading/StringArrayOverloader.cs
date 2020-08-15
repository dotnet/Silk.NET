// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using System.Collections.Generic;
using System.Linq;
using System.Text;
using Silk.NET.BuildTools.Common;
using Silk.NET.BuildTools.Common.Builders;
using Silk.NET.BuildTools.Common.Functions;

namespace Silk.NET.BuildTools.Overloading
{
    public class StringArrayOverloader : IFunctionOverloader
    {
        public bool TryCreateVariant(Parameter parameter, out Parameter variant, Project core)
        {
            variant = null;
            return false;
        }

        public bool TryCreateVariant(Type returnType, out Type variant, Project core)
        {
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
            // SuperInvoke currently can't properly marshal string spans, so we need to help out.
            var sb = new StringBuilder();
            var pl = new List<Parameter>();
            var ep = new List<string>();
            var varied = false;
            sb.AppendLine("// StringArrayOverloader");
            pl.AddRange(function.Parameters);
            for (var i = 0; i < pl.Count; i++)
            {
                var parameter = pl[i];
                if (parameter.Type.ToString() == "char**" || parameter.Type.ToString() == "byte**")
                {
                    pl[i] = new ParameterSignatureBuilder(parameter).WithType
                        (
                            new Type
                            {
                                Name = "string", ArrayDimensions = 1
                            }
                        )
                        .WithName(parameter.Name + "Sa")
                        .Build();
                    varied = true;
                    sb.AppendLine
                    (
                        $"var {parameter.Name} = ({parameter.Type}) SilkMarshal.MarshalStringArrayToPtr({parameter.Name}Sa);"
                    );
                    ep.Add($"SilkMarshal.CopyPtrToStringArray((IntPtr) {parameter.Name}, {parameter.Name}Sa);");
                }
            }

            if (function.ReturnType.ToString() != "void")
            {
                sb.Append("var ret = ");
            }

            sb.AppendLine
            (
                $"{function.Name}" +
                "(" + string.Join
                (
                    ", ",
                    function.Parameters.Select
                    (
                        x => (x.Type.IsByRef ? "ref " : string.Empty) + (Utilities.CSharpKeywords.Contains
                            (x.Name)
                            ? "@"
                            : string.Empty) + x.Name
                    )
                ) + ");"
            );

            foreach (var epilogueLine in ep)
            {
                sb.AppendLine(epilogueLine);
            }

            if (function.ReturnType.ToString() != "void")
            {
                sb.AppendLine("return ret;");
            }

            if (varied)
            {
                overload = new ImplementedFunction
                    (new FunctionSignatureBuilder(function).WithParameters(pl).Build(), sb, function);
                return true;
            }

            overload = null;
            return false;
        }
    }
}
