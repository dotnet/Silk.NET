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

namespace Silk.NET.OpenGL.Extensions.ARB
{
    public static class ArbVertexType2101010RevOverloads
    {
        public static unsafe void VertexAttribP1(this ArbVertexType2101010Rev thisApi, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] ARB type, [Flow(FlowDirection.In)] bool normalized, [Count(Count = 1), Flow(FlowDirection.In)] ReadOnlySpan<uint> value)
        {
            // SpanOverloader
            thisApi.VertexAttribP1(index, type, normalized, in value.GetPinnableReference());
        }

        public static unsafe void VertexAttribP1(this ArbVertexType2101010Rev thisApi, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] VertexAttribPointerType type, [Flow(FlowDirection.In)] bool normalized, [Count(Count = 1), Flow(FlowDirection.In)] ReadOnlySpan<uint> value)
        {
            // SpanOverloader
            thisApi.VertexAttribP1(index, type, normalized, in value.GetPinnableReference());
        }

        public static unsafe void VertexAttribP2(this ArbVertexType2101010Rev thisApi, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] ARB type, [Flow(FlowDirection.In)] bool normalized, [Count(Count = 1), Flow(FlowDirection.In)] ReadOnlySpan<uint> value)
        {
            // SpanOverloader
            thisApi.VertexAttribP2(index, type, normalized, in value.GetPinnableReference());
        }

        public static unsafe void VertexAttribP2(this ArbVertexType2101010Rev thisApi, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] VertexAttribPointerType type, [Flow(FlowDirection.In)] bool normalized, [Count(Count = 1), Flow(FlowDirection.In)] ReadOnlySpan<uint> value)
        {
            // SpanOverloader
            thisApi.VertexAttribP2(index, type, normalized, in value.GetPinnableReference());
        }

        public static unsafe void VertexAttribP3(this ArbVertexType2101010Rev thisApi, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] ARB type, [Flow(FlowDirection.In)] bool normalized, [Count(Count = 1), Flow(FlowDirection.In)] ReadOnlySpan<uint> value)
        {
            // SpanOverloader
            thisApi.VertexAttribP3(index, type, normalized, in value.GetPinnableReference());
        }

        public static unsafe void VertexAttribP3(this ArbVertexType2101010Rev thisApi, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] VertexAttribPointerType type, [Flow(FlowDirection.In)] bool normalized, [Count(Count = 1), Flow(FlowDirection.In)] ReadOnlySpan<uint> value)
        {
            // SpanOverloader
            thisApi.VertexAttribP3(index, type, normalized, in value.GetPinnableReference());
        }

        public static unsafe void VertexAttribP4(this ArbVertexType2101010Rev thisApi, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] ARB type, [Flow(FlowDirection.In)] bool normalized, [Count(Count = 1), Flow(FlowDirection.In)] ReadOnlySpan<uint> value)
        {
            // SpanOverloader
            thisApi.VertexAttribP4(index, type, normalized, in value.GetPinnableReference());
        }

        public static unsafe void VertexAttribP4(this ArbVertexType2101010Rev thisApi, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] VertexAttribPointerType type, [Flow(FlowDirection.In)] bool normalized, [Count(Count = 1), Flow(FlowDirection.In)] ReadOnlySpan<uint> value)
        {
            // SpanOverloader
            thisApi.VertexAttribP4(index, type, normalized, in value.GetPinnableReference());
        }

    }
}

