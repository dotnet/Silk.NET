// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;
using Silk.NET.Core;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.OpenGLES.Extensions.OES
{
    public static class OesGetProgramBinaryOverloads
    {
        public static unsafe void GetProgramBinary<T0>(this OesGetProgramBinary thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(FlowDirection.Out)] Span<OES> binaryFormat, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<T0> binary) where T0 : struct
        {
            // SpanOverloader
            fixed (void* binarySpp = binary)
                thisApi.GetProgramBinary(program, bufSize, length, out binaryFormat.GetPinnableReference(), binarySpp);
        }

        public static unsafe void GetProgramBinary<T0>(this OesGetProgramBinary thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] Span<uint> length, [Count(Count = 1), Flow(FlowDirection.Out)] OES* binaryFormat, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<T0> binary) where T0 : struct
        {
            // SpanOverloader
            fixed (void* binarySpp = binary)
                thisApi.GetProgramBinary(program, bufSize, out length.GetPinnableReference(), binaryFormat, binarySpp);
        }

        public static unsafe void GetProgramBinary<T0>(this OesGetProgramBinary thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] Span<uint> length, [Count(Count = 1), Flow(FlowDirection.Out)] Span<OES> binaryFormat, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<T0> binary) where T0 : struct
        {
            // SpanOverloader
            fixed (void* binarySpp = binary)
                thisApi.GetProgramBinary(program, bufSize, out length.GetPinnableReference(), out binaryFormat.GetPinnableReference(), binarySpp);
        }

    }
}

