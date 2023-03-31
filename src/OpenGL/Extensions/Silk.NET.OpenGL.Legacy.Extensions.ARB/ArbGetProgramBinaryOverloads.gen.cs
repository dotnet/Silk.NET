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

namespace Silk.NET.OpenGL.Legacy.Extensions.ARB
{
    public static class ArbGetProgramBinaryOverloads
    {
        public static unsafe void GetProgramBinary<T0>(this ArbGetProgramBinary thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* binaryFormat, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T0> binary) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.GetProgramBinary(program, bufSize, length, binaryFormat, out binary.GetPinnableReference());
        }

        public static unsafe void GetProgramBinary(this ArbGetProgramBinary thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> binaryFormat, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* binary)
        {
            // SpanOverloader
            thisApi.GetProgramBinary(program, bufSize, length, out binaryFormat.GetPinnableReference(), binary);
        }

        public static unsafe void GetProgramBinary<T0>(this ArbGetProgramBinary thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> binaryFormat, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T0> binary) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.GetProgramBinary(program, bufSize, length, out binaryFormat.GetPinnableReference(), out binary.GetPinnableReference());
        }

        public static unsafe void GetProgramBinary(this ArbGetProgramBinary thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> length, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* binaryFormat, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* binary)
        {
            // SpanOverloader
            thisApi.GetProgramBinary(program, bufSize, out length.GetPinnableReference(), binaryFormat, binary);
        }

        public static unsafe void GetProgramBinary<T0>(this ArbGetProgramBinary thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> length, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* binaryFormat, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T0> binary) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.GetProgramBinary(program, bufSize, out length.GetPinnableReference(), binaryFormat, out binary.GetPinnableReference());
        }

        public static unsafe void GetProgramBinary(this ArbGetProgramBinary thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> length, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> binaryFormat, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* binary)
        {
            // SpanOverloader
            thisApi.GetProgramBinary(program, bufSize, out length.GetPinnableReference(), out binaryFormat.GetPinnableReference(), binary);
        }

        public static unsafe void GetProgramBinary<T0>(this ArbGetProgramBinary thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> length, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> binaryFormat, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T0> binary) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.GetProgramBinary(program, bufSize, out length.GetPinnableReference(), out binaryFormat.GetPinnableReference(), out binary.GetPinnableReference());
        }

        public static unsafe void ProgramBinary<T0>(this ArbGetProgramBinary thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB binaryFormat, [Count(Parameter = "length"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> binary, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint length) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.ProgramBinary(program, binaryFormat, in binary.GetPinnableReference(), length);
        }

    }
}

