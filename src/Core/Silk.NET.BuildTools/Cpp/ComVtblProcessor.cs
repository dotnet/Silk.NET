// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.BuildTools.Common;
using Silk.NET.BuildTools.Common.Builders;
using Silk.NET.BuildTools.Common.Functions;
using Silk.NET.BuildTools.Overloading;
using Type = Silk.NET.BuildTools.Common.Functions.Type;

namespace Silk.NET.BuildTools.Cpp
{
    public static class ComVtblProcessor
    {
        public static IEnumerable<ImplementedFunction> GetHelperFunctions(Struct @struct, Project core)
        {
            var sb = new StringBuilder();
            foreach (var vtblFunction in GetWithVariants(@struct.Vtbl, core))
            {
                sb.Clear();
                Implement(sb, vtblFunction.New, @struct, vtblFunction.Original.VtblIndex);
                vtblFunction.New.IsReadOnly = true;
                yield return new ImplementedFunction(vtblFunction.New, sb, vtblFunction.Original);
            }
        }

        public static IEnumerable<(Function Original, Function New)> GetWithVariants
        (
            IEnumerable<Function> functions,
            Project core
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
                    (overload.New, core, Overloader.ReturnOverloaders))
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
                        (function.Item2, core, overloaders))
                    {
                        yield return (function.Item1, overload);
                    }
                }
            }
        }

        public static void Implement(StringBuilder sb, Function function, Struct parent, int index)
        {
            var ind = "";
            sb.AppendLine($"var @this = ({parent.Name}*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));");

            var epilogue = new List<Action>();
            var parameterInvocations = new List<(Type Type, string Parameter)>
            {
                (new Type {Name = parent.Name, IndirectionLevels = 1}, "@this")
            };

            if (function.ReturnType.ToString() != "void")
            {
                sb.AppendLine($"    {function.ReturnType} ret = default;");
            }

            for (var i = 0; i < function.Parameters.Count; i++)
            {
                var parameter = function.Parameters[i];
                if (parameter.Type.Name == "string")
                {
                    // assume ansi
                    if (parameter.Type.IsIn)
                    {
                        sb.AppendLine
                            ($"var {parameter.Name}PtrInit = (byte*) Marshal.StringToHGlobalAnsi({parameter.Name});");
                        sb.AppendLine($"var {parameter.Name}Ptr = &{parameter.Name}PtrInit;");
                        parameterInvocations.Add
                            ((new Type {Name = "byte", IndirectionLevels = 2}, $"{parameter.Name}Ptr"));
                        epilogue.Add(() => sb.AppendLine($"Marshal.FreeHGlobal((IntPtr){parameter.Name}PtrInit);"));
                    }
                    else if (parameter.Type.IsByRef)
                    {
                        sb.AppendLine
                            ($"var {parameter.Name}PtrInit = (byte*) Marshal.StringToHGlobalAnsi({parameter.Name});");
                        sb.AppendLine($"var {parameter.Name}Ptr = &{parameter.Name}PtrInit;");
                        parameterInvocations.Add
                            ((new Type {Name = "byte", IndirectionLevels = 2}, $"{parameter.Name}Ptr"));
                        epilogue.Add
                        (
                            () =>
                            {
                                sb.AppendLine($"{parameter.Name} = Marshal.PtrToStringAnsi(*{parameter.Name}Ptr);");
                                sb.AppendLine($"Marshal.FreeHGlobal((IntPtr){parameter.Name}PtrInit);");
                            }
                        );
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
                        sb.AppendLine
                            ($"var {parameter.Name}Ptr = (byte*) Marshal.StringToHGlobalAnsi({parameter.Name});");
                        parameterInvocations.Add
                            ((new Type {Name = "byte", IndirectionLevels = 1}, $"{parameter.Name}Ptr"));
                        epilogue.Add
                        (
                            () => { sb.AppendLine($"Marshal.FreeHGlobal((IntPtr){parameter.Name}Ptr);"); }
                        );
                    }
                }
                else if (parameter.Type.IsIn || parameter.Type.IsOut || parameter.Type.IsByRef)
                {
                    var noRef = new TypeSignatureBuilder(parameter.Type)
                        .WithByRef(false)
                        .WithIsIn(false)
                        .WithIsOut(false)
                        .WithIndirectionLevel(parameter.Type.IndirectionLevels + 1)
                        .Build();
                    sb.AppendLine
                    (
                        ind + $"fixed ({noRef} {parameter.Name}Ptr = &{parameter.Name})"
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
                    parameterInvocations.Add((parameter.Type, parameter.Name));
                }
            }

            if (function.ReturnType.ToString() != "void")
            {
                sb.Append(ind + "ret = ");
            }
            else
            {
                sb.Append(ind);
            }

            var conv = function.Convention switch
            {
                CallingConvention.Winapi => throw new NotImplementedException(),
                CallingConvention.Cdecl => "Cdecl",
                CallingConvention.StdCall => "Stdcall",
                CallingConvention.ThisCall => "Thiscall",
                CallingConvention.FastCall => "Fastcall",
                _ => "Cdecl"
            };

            var fnPtrSig = string.Join(", ", parameterInvocations.Select(x => x.Type.ToString()));
            if (!string.IsNullOrWhiteSpace(fnPtrSig))
            {
                fnPtrSig += ", ";
            }

            fnPtrSig += function.ReturnType;
            sb.Append($"((delegate* unmanaged[{conv}]<{fnPtrSig}>)");
            sb.Append($"LpVtbl[{index}])");
            sb.AppendLine("(" + string.Join(", ", parameterInvocations.Select(x => x.Parameter)) + ");");

            for (var i = epilogue.Count - 1; i >= 0; i--)
            {
                epilogue[i]();
            }

            if (function.ReturnType.ToString() != "void")
            {
                sb.AppendLine("return ret;");
            }
        }
    }
}
