// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using System;
using System.Text;
using Silk.NET.BuildTools.Common.Functions;

namespace Silk.NET.Generators.Interop.Marshalling
{
    public readonly struct MethodMarshalContext
    {
        public MethodMarshalContext(Action<Function, StringBuilder> writeNativeCall, StringBuilder writer, Function method)
        {
            WriteNativeCall = writeNativeCall;
            Writer = writer;
            Method = method;
        }
        public Action<Function, StringBuilder> WriteNativeCall { get; }
        public StringBuilder Writer { get; }
        public Function Method { get; }
    }
}
