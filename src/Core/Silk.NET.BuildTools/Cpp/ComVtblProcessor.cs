// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.BuildTools.Bind;
using Silk.NET.BuildTools.Common;
using Silk.NET.BuildTools.Common.Builders;
using Silk.NET.BuildTools.Common.Functions;
using Silk.NET.BuildTools.Overloading;
using Attribute = Silk.NET.BuildTools.Common.Attribute;
using Type = Silk.NET.BuildTools.Common.Functions.Type;

namespace Silk.NET.BuildTools.Cpp
{
    public static class ComVtblProcessor
    {
        public static IEnumerable<ImplementedFunction> GetHelperFunctions
        (
            BindState task,
            Struct @struct,
            Profile profile,
            bool thisInScope = false,
            string vtbl = "LpVtbl"
        )
        {
            var sb = new StringBuilder();
            var all = GetWithVariants(@struct.Vtbl, profile, task.Task).ToList();
            foreach (var vtblFunction in all)
            {
                sb.Clear();
                Implement(sb, vtblFunction.New, @struct, vtblFunction.Original.VtblIndex, false, thisInScope);
                vtblFunction.New.IsReadOnly = true;
                vtblFunction.New.InvocationPrefix = "@this->";
                yield return new ImplementedFunction(vtblFunction.New, sb, vtblFunction.Original);
            }

            foreach (var complex in Overloader.GetOverloads(all.Select(x => x.New), profile.Projects["Core"], task.Task.OverloaderExclusions))
            {
                if (!thisInScope)
                {
                    complex.Body = Enumerable.Repeat
                    (
                        $"var @this = ({@struct.Name}*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));",
                        1
                    )
                    .Concat(complex.Body)
                    .ToArray();
                }
            
                yield return complex;
            }
        }

        public static IEnumerable<(Function Original, Function New)> GetWithVariants
        (
            IEnumerable<Function> functions,
            Profile profile,
            BindTask task
        )
        {
            var enumerable = GetOriginals(functions);
            foreach (var overloaders in Overloader.ParameterOverloaders)
            {
                enumerable = Get(enumerable, overloaders);
            }

            foreach (var overload in enumerable)
            {
                foreach (var final in SimpleReturnOverloader.GetWithOverloads
                    (overload.New, profile, Overloader.ReturnOverloaders.Filter(overload.New, task.OverloaderExclusions)))
                {
                    yield return (overload.Original, final);
                }
            }

            IEnumerable<(Function Original, Function New)> GetOriginals(IEnumerable<Function> original)
            {
                foreach (var function in original)
                {
                    yield return (function, function);
                }
            }

            IEnumerable<(Function, Function)> Get
                (IEnumerable<(Function, Function)> functions, ISimpleParameterOverloader[] overloaders)
            {
                foreach (var function in functions)
                {
                    foreach (var overload in SimpleParameterOverloader.GetWithOverloads
                        (function.Item2, profile, overloaders.Filter(function.Item2, task.OverloaderExclusions)))
                    {
                        yield return (function.Item1, overload);
                    }
                }
            }
        }

        public static void Implement
        (
            StringBuilder sb,
            Function function,
            Struct parent,
            int index,
            bool retDeref = false,
            bool thisInScope = false
        )
        {
            if (function.Attributes.IsBuildToolsIntrinsic(out var args) && args[0] == "$CPPRETFIXUP")
            {
                sb.AppendLine($"{function.ReturnType} silkDotNetReturnFixupResult;");
                sb.AppendLine("var pSilkDotNetReturnFixupResult = &silkDotNetReturnFixupResult;");
                var indIncremented = new TypeSignatureBuilder(function.ReturnType)
                    .WithIndirectionLevel(function.ReturnType.IndirectionLevels + 1)
                    .Build();
                var fixedUpFunction = new FunctionSignatureBuilder(function)
                    .WithReturnType(indIncremented)
                    .WithAttributes(Array.Empty<Attribute>())
                    .WithParameters
                    (
                        function.Parameters.Prepend
                        (
                            new Parameter
                            {
                                Name = "pSilkDotNetReturnFixupResult",
                                Type = indIncremented
                            }
                        ).ToArray()
                    ).Build();
                Implement(sb, fixedUpFunction, parent, index, true, thisInScope);
                return;
            }
            
            var ind = "";
            if (!thisInScope)
            {
                sb.AppendLine($"var @this = ({parent.Name}*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));");
            }

            var epilogue = new List<Action>();
            var parameterInvocations = new List<(Type Type, string Parameter)>
            {
                (new Type {Name = parent.Name, IndirectionLevels = 1}, "@this")
            };

            if (function.ReturnType.ToString() != "void")
            {
                sb.AppendLine($"{function.ReturnType} ret = default;");
            }

            for (var i = 0; i < function.Parameters.Count; i++)
            {
                var parameter = function.Parameters[i];

                string name = Utilities.CSharpKeywords.Contains(parameter.Name) ? $"@{parameter.Name}" : parameter.Name;

                if (parameter.Type.Name == "string")
                {
                    var nativeStringEncoding = parameter.Type.MapNativeString();
                    sb.Append($"var {parameter.Name}Ptr = (byte*) SilkMarshal.StringToPtr({name}, ");
                    sb.AppendLine($"{nativeStringEncoding});");
                    if (parameter.Type.IsIn || parameter.Type.IsByRef)
                    {
                        sb.AppendLine($"var {parameter.Name}Pp = &{parameter.Name}Ptr;");
                        parameterInvocations.Add
                            ((new Type {Name = "byte", IndirectionLevels = 2}, $"{name}Pp"));
                    }
                    else if (parameter.Type.IsOut)
                    {
                        throw new NotSupportedException
                        (
                            "COM VTables don't support out strings due to lack of flow and count information."
                        );
                    }
                    else
                    {
                        parameterInvocations.Add
                        (
                            (new Type {Name = "byte", IndirectionLevels = 1}, $"{parameter.Name}Ptr")
                        );
                    }

                    epilogue.Add
                    (
                        () =>
                        {
                            if (parameter.Type.IsByRef)
                            {
                                sb.Append($"{name} = SilkMarshal.PtrToString(*{parameter.Name}Pp, ");
                                sb.AppendLine($"{nativeStringEncoding});");
                            }

                            sb.AppendLine($"SilkMarshal.Free((nint){parameter.Name}Ptr);");
                        }
                    );
                }
                else if (parameter.Type.IsIn || parameter.Type.IsOut || parameter.Type.IsByRef)
                {
                    var noRef = new TypeSignatureBuilder(parameter.Type)
                        .WithByRef(false)
                        .WithIsIn(false)
                        .WithIsOut(false)
                        .WithIndirectionLevel(parameter.Type.IndirectionLevels + 1)
                        .WithName(parameter.Type.IsGenericTypeParameterReference ? "void" : parameter.Type.Name)
                        .Build();
                    sb.AppendLine
                    (
                        ind + $"fixed ({noRef} {parameter.Name}Ptr = &{name})"
                    );
                    sb.AppendLine(ind + "{");
                    parameterInvocations.Add((noRef, $"{parameter.Name}Ptr"));
                    ind += "    ";
                    epilogue.Add
                    (
                        () =>
                        {
                            ind = ind.Substring(0, ind.Length - 4);
                            sb.AppendLine(ind + "}");
                        }
                    );
                }
                else
                {
                    parameterInvocations.Add((parameter.Type, name));
                }
            }

            var conv = function.Convention switch
            {
                CallingConvention.Winapi => string.Empty,
                CallingConvention.Cdecl => "Cdecl",
                CallingConvention.StdCall => "Stdcall",
                CallingConvention.ThisCall => "Thiscall",
                CallingConvention.FastCall => "Fastcall",
                _ => string.Empty
            };

            var fnPtrSig = string.Join(", ", parameterInvocations.Select(x => x.Type.ToString()));
            if (!string.IsNullOrWhiteSpace(fnPtrSig))
            {
                fnPtrSig += ", ";
            }

            fnPtrSig += function.ReturnType;
            var fnPtrPre = function.ReturnType.ToString() != "void" ? $"{ind}ret = " : ind;
            var fnPtrInv = $"@this->LpVtbl[{index}])({string.Join(", ", parameterInvocations.Select(x => x.Parameter))});";
            if (conv == string.Empty)
            {
                sb.AppendLine("#if NET5_0_OR_GREATER");
                sb.AppendLine($"{fnPtrPre}((delegate* unmanaged<{fnPtrSig}>){fnPtrInv}");
                sb.AppendLine("#else");
                sb.AppendLine($"{ind}if (SilkMarshal.IsWinapiStdcall)");
                sb.AppendLine($"{ind}{{");
                sb.AppendLine($"    {fnPtrPre}((delegate* unmanaged[Stdcall]<{fnPtrSig}>){fnPtrInv}");
                sb.AppendLine($"{ind}}}");
                sb.AppendLine($"{ind}else");
                sb.AppendLine($"{ind}{{");
                sb.AppendLine($"    {fnPtrPre}((delegate* unmanaged[Cdecl]<{fnPtrSig}>){fnPtrInv}");
                sb.AppendLine($"{ind}}}");
                sb.AppendLine("#endif");
            }
            else
            {
                sb.AppendLine($"{fnPtrPre}((delegate* unmanaged[{conv}]<{fnPtrSig}>){fnPtrInv}");
            }

            for (var i = epilogue.Count - 1; i >= 0; i--)
            {
                epilogue[i]();
            }

            if (retDeref)
            {
                sb.AppendLine("return *ret;");
            }
            else if (function.ReturnType.ToString() != "void")
            {
                sb.AppendLine("return ret;");
            }
        }
    }
}
