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
    public static class ArbShaderAtomicCountersOverloads
    {
        public static unsafe void GetActiveAtomicCounterBuffer(this ArbShaderAtomicCounters thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint bufferIndex, [Flow(FlowDirection.In)] ARB pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetActiveAtomicCounterBuffer(program, bufferIndex, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetActiveAtomicCounterBuffer(this ArbShaderAtomicCounters thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint bufferIndex, [Flow(FlowDirection.In)] AtomicCounterBufferPName pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetActiveAtomicCounterBuffer(program, bufferIndex, pname, out @params.GetPinnableReference());
        }

    }
}

