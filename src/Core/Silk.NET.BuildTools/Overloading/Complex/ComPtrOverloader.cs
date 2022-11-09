// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using Silk.NET.BuildTools.Common;
using Silk.NET.BuildTools.Common.Builders;
using Silk.NET.BuildTools.Common.Functions;

namespace Silk.NET.BuildTools.Overloading;

public class ComPtrOverloader : IComplexFunctionOverloader
{
    private static bool IsComStruct(string name, Project core)
    {
        return core.ComRefs.Contains(name) || core.Structs.Any
        (
            x => x.ComBases.Contains(name) ||
                 x.Name == name && x.Uuid is not null && (x.Vtbl?.Count > 0 || x.ComBases?.Count > 0)
        );
    }

    private static bool IsComRef(Parameter param, Project core, bool prevRiid = false)
        => prevRiid && param.Type.ToString() == "void**" ||
           param.Type.IndirectionLevels == 2 && IsComStruct(param.Type.Name, core);

    public bool TryGetFunctionVariant(Function original, out ImplementedFunction varied, Project core)
    {
        var inv = original.Parameters
            .Select(x => (!x.Type.IsIn ? !x.Type.IsOut ? !x.Type.IsByRef ? "" : "ref " : "out " : "in ") + x.Name.AtEscape())
            .ToList();

        var parameters = original.Parameters.ToList();
        var nti = 0;
        var nrm = 0;
        var gens = original.GenericTypeParameters.ToList();
        var sb = new StringBuilder();
        sb.AppendLine("// ComPtrOverloader");
        for (var i = 0; i < original.Parameters.Count; i++)
        {
            var param = original.Parameters[i];
            if (param.Type.ToString() == "Guid*" && original.Parameters.Count > i + 1 && IsComRef(original.Parameters[i + 1], core, true))
            {
                var @out = i + 2 == original.Parameters.Count;
                
                inv[i] = $"SilkMarshal.GuidPtrOf<TI{nti}>()";
                parameters.RemoveAt(i - nrm);
                gens.Add
                (
                    new GenericTypeParameter
                    (
                        $"TI{nti}",
                        parameters[i - nrm].Type.Name == "void"
                            ? new[] { "unmanaged", $"IComVtbl<TI{nti}>" }
                            : new[] { "unmanaged", $"IComVtbl<{parameters[i - nrm].Type.Name}>", $"IComVtbl<TI{nti}>" }
                    )
                );

                inv[i + 1] = $"({parameters[i - nrm].Type}) {parameters[i - nrm].Name.AtEscape()}.GetAddressOf()";
                parameters[i - nrm] = new ParameterSignatureBuilder(parameters[i - nrm])
                    .WithType
                    (
                        new Type
                        {
                            Name = "ComPtr",
                            GenericTypes = new List<Type>
                                { new() { Name = $"TI{nti}", IsGenericTypeParameterReference = true } },
                            IsOut = @out,
                            IsByRef = !@out
                        }
                    )
                    .Build();

                if (@out)
                {
                    sb.AppendLine($"{parameters[i - nrm].Name.AtEscape()} = default;");
                }

                nrm++; // we've removed the guid parameter
                nti++; // we've added a generic type parameter
                i++; // we've already handled the next parameter (ppvObject)
            }
            else if (IsComRef(original.Parameters[i], core))
            {
                gens.Add
                (
                    new GenericTypeParameter
                    (
                        $"TI{nti}",
                        new[] { "unmanaged", $"IComVtbl<{parameters[i - nrm].Type.Name}>", $"IComVtbl<TI{nti}>" }
                    )
                );
                inv[i] = $"({parameters[i - nrm].Type}) {parameters[i - nrm].Name.AtEscape()}.GetAddressOf()";
                parameters[i - nrm] = new ParameterSignatureBuilder(parameters[i - nrm])
                    .WithType
                    (
                        new Type
                        {
                            Name = "ComPtr",
                            GenericTypes = new List<Type>
                                { new() { Name = $"TI{nti}", IsGenericTypeParameterReference = true } },
                            IsByRef = true
                        }
                    )
                    .Build();
                nti++; // we've added a generic type parameter
            }
            else if (param.Type.IndirectionLevels == 1 && !param.Type.IsByRef && !param.Type.IsOut && !param.Type.IsIn && IsComStruct(param.Type.Name, core))
            {
                gens.Add
                (
                    new GenericTypeParameter
                    (
                        $"TI{nti}",
                        new[] { "unmanaged", $"IComVtbl<{parameters[i - nrm].Type.Name}>", $"IComVtbl<TI{nti}>" }
                    )
                );
                inv[i] = $"({parameters[i - nrm].Type}) {parameters[i - nrm].Name.AtEscape()}.Handle";
                parameters[i - nrm] = new ParameterSignatureBuilder(parameters[i - nrm])
                    .WithType
                    (
                        new Type
                        {
                            Name = "ComPtr",
                            GenericTypes = new List<Type>
                                { new() { Name = $"TI{nti}", IsGenericTypeParameterReference = true } }
                        }
                    )
                    .Build();
                nti++; // we've added a generic type parameter
            }
        }

        if (original.ReturnType.ToString() != "void")
        {
            sb.Append("return ");
        }

        sb.Append(original.InvocationPrefix);
        sb.Append(original.Name);
        sb.Append('(');
        sb.Append(string.Join(", ", inv));
        sb.AppendLine(");");
        varied = new ImplementedFunction
        (
            new FunctionSignatureBuilder(original).WithGenericTypeParameters(gens).WithParameters(parameters).Build(),
            sb, original
        );

        return nti > 0;
    }
}
