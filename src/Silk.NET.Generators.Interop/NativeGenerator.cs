// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using System;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.BuildTools.Common;
using Silk.NET.BuildTools.Common.Functions;
using Silk.NET.Generators.Interop.Marshalling;

namespace Silk.NET.Generators.Interop
{
    public static class NativeGenerator
    {
        public static IMarshaller[] Marshallers { get; }
        public static ImplementedFunction GetImplementation(Function inSig)
        {
            var current = 0;
            Function finalOutSig = null;
            var sb = new StringBuilder();
            if (Marshallers.Length == 0)
            {
                MarshalNext(inSig, sb);
            }
            
            var ctx = new MethodMarshalContext(MarshalNext, sb, inSig);
            Marshallers[0].Marshal(ctx);
            void MarshalNext(Function outSig, StringBuilder sb)
            {
                current++;
                if (current >= Marshallers.Length)
                {
                    sb.AppendLine
                    (
                        (outSig.ReturnType.ToString() != "void" ? "return " : null) + 
                        $"((delegate*{GetCallConv(outSig)}<{GetDecl(outSig)}>)"+
                        $"(_addresses[$SLOT$] ??= LoadFunction(\"{outSig.NativeName}\")))" +
                        $"({GetCall(outSig)});"
                    );

                    finalOutSig = outSig;
                }
                else
                {
                    Marshallers[current].Marshal(new MethodMarshalContext(MarshalNext, sb, outSig));
                }
            }
            
            return new ImplementedFunction(finalOutSig, sb, inSig);

            string GetCall(Function sig) => string.Join(", ", sig.Parameters.Select(x => x.Name));
            
            string GetDecl(Function sig) => string.Join
                (", ", sig.Parameters.Select(x => x.Type.ToString()).Concat(new[] {sig.ReturnType.ToString()}));

            string? GetCallConv(Function sig) =>
                sig.Convention switch
                {
                    CallingConvention.Cdecl => " cdecl",
                    CallingConvention.FastCall => throw new NotSupportedException(),
                    CallingConvention.StdCall => " stdcall",
                    CallingConvention.ThisCall => " thiscall",
                    CallingConvention.Winapi => " stdcall",
                    null => null,
                    _ => null
                };
        }
    }
}
