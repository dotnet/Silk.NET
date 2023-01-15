// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Collections.Generic;
using System.Linq;
using System.Text;
using Silk.NET.BuildTools.Common;
using Silk.NET.BuildTools.Common.Builders;
using Silk.NET.BuildTools.Common.Functions;

namespace Silk.NET.BuildTools.Overloading
{
    public class StringArrayOverloader : IComplexFunctionOverloader
    {
        public bool TryGetFunctionVariant(Function function, out ImplementedFunction overload, Project core)
        {
            // SilkTouch currently can't properly marshal string spans, so we need to help out.
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
                                Name = "string", ArrayDimensions = 1, OriginalName = parameter.Type.OriginalName
                            }
                        )
                        .WithName(parameter.Name + "Sa")
                        .Build();
                    varied = true;
                    sb.AppendLine
                    (
                        $"var {parameter.Name} = ({parameter.Type}) SilkMarshal.StringArrayToPtr({parameter.Name}Sa);"
                    );
                    ep.Add($"SilkMarshal.CopyPtrToStringArray((nint) {parameter.Name}, {parameter.Name}Sa);");
                    ep.Add($"SilkMarshal.Free((nint) {parameter.Name});");
                }
            }

            if (function.ReturnType.ToString() != "void")
            {
                sb.Append("var ret = ");
            }

            sb.AppendLine
            (
                $"{function.InvocationPrefix}{function.Name}" +
                "(" + string.Join
                (
                    ", ",
                    function.Parameters.Select
                    (
                        x => (x.Type.IsIn ? "in " : string.Empty) + (x.Type.IsOut ? "out " : string.Empty) +
                             (x.Type.IsByRef ? "ref " : string.Empty) + (Utilities.CSharpKeywords.Contains
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
