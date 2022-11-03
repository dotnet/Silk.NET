// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Linq;
using System.Text;
using Silk.NET.BuildTools.Common;
using Silk.NET.BuildTools.Common.Builders;
using Silk.NET.BuildTools.Common.Functions;

namespace Silk.NET.BuildTools.Overloading;

public class NonKhrReturnTypeOverloader : IComplexFunctionOverloader
{
    public bool TryGetFunctionVariant(Function original, out ImplementedFunction varied, Project core)
    {
        varied = default;
        if (ReturnTypeOverloader.IsApplicable(original) ||
            (original.ReturnType.Name != "void" && original.ReturnType.OriginalName != "HRESULT") ||
            !(original.Parameters.LastOrDefault()?.Type.IsOut ?? false))
        {
            return false;
        }

        var sb = new StringBuilder();
        sb.AppendLine("// NonKhrReturnTypeOverloader");
        if (original.ReturnType.OriginalName == "HRESULT")
        {
            sb.Append("SilkMarshal.ThrowHResult(");
        }

        sb.Append(original.InvocationPrefix);
        sb.Append(original.Name);
        sb.Append('(');
        sb.Append
        (
            string.Join
            (
                ", ",
                original.Parameters.SkipLast(1)
                    .Select
                    (
                        x => (!x.Type.IsIn ? !x.Type.IsOut ? !x.Type.IsByRef ? "" : "ref " : "out " : "in ") + x.Name
                    )
            )
        );

        if (original.Parameters.Count > 1)
        {
            sb.Append(", ");
        }

        sb.Append($"{original.Parameters.Last().Type} silkRet)");
        if (original.ReturnType.OriginalName == "HRESULT")
        {
            sb.Append(')');
        }

        sb.AppendLine(";");
        sb.AppendLine("return silkRet;");
        varied = new ImplementedFunction
        (
            new FunctionSignatureBuilder(original)
                .WithParameters(original.Parameters.SkipLast(1).ToList())
                .WithReturnType(new TypeSignatureBuilder(original.Parameters.Last().Type).WithIsOut(false).Build())
                .Build(),
            sb,
            original
        );

        return true;
    }
}
