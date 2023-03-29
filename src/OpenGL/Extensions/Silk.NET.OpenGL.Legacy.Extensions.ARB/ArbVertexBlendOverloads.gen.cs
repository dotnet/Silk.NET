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
    public static class ArbVertexBlendOverloads
    {
        public static unsafe void Weight(this ArbVertexBlend thisApi, [Flow(FlowDirection.In)] int size, [Count(Parameter = "size"), Flow(FlowDirection.In)] ReadOnlySpan<sbyte> weights)
        {
            // SpanOverloader
            thisApi.Weight(size, in weights.GetPinnableReference());
        }

        public static unsafe void Weight(this ArbVertexBlend thisApi, [Flow(FlowDirection.In)] int size, [Count(Parameter = "size"), Flow(FlowDirection.In)] ReadOnlySpan<short> weights)
        {
            // SpanOverloader
            thisApi.Weight(size, in weights.GetPinnableReference());
        }

        public static unsafe void Weight(this ArbVertexBlend thisApi, [Flow(FlowDirection.In)] int size, [Count(Parameter = "size"), Flow(FlowDirection.In)] ReadOnlySpan<int> weights)
        {
            // SpanOverloader
            thisApi.Weight(size, in weights.GetPinnableReference());
        }

        public static unsafe void Weight(this ArbVertexBlend thisApi, [Flow(FlowDirection.In)] int size, [Count(Parameter = "size"), Flow(FlowDirection.In)] ReadOnlySpan<float> weights)
        {
            // SpanOverloader
            thisApi.Weight(size, in weights.GetPinnableReference());
        }

        public static unsafe void Weight(this ArbVertexBlend thisApi, [Flow(FlowDirection.In)] int size, [Count(Parameter = "size"), Flow(FlowDirection.In)] ReadOnlySpan<double> weights)
        {
            // SpanOverloader
            thisApi.Weight(size, in weights.GetPinnableReference());
        }

        public static unsafe void Weight(this ArbVertexBlend thisApi, [Flow(FlowDirection.In)] int size, [Count(Parameter = "size"), Flow(FlowDirection.In)] ReadOnlySpan<byte> weights)
        {
            // SpanOverloader
            thisApi.Weight(size, in weights.GetPinnableReference());
        }

        public static unsafe void Weight(this ArbVertexBlend thisApi, [Flow(FlowDirection.In)] int size, [Count(Parameter = "size"), Flow(FlowDirection.In)] ReadOnlySpan<ushort> weights)
        {
            // SpanOverloader
            thisApi.Weight(size, in weights.GetPinnableReference());
        }

        public static unsafe void Weight(this ArbVertexBlend thisApi, [Flow(FlowDirection.In)] int size, [Count(Parameter = "size"), Flow(FlowDirection.In)] ReadOnlySpan<uint> weights)
        {
            // SpanOverloader
            thisApi.Weight(size, in weights.GetPinnableReference());
        }

        public static unsafe void WeightPointer<T0>(this ArbVertexBlend thisApi, [Flow(FlowDirection.In)] int size, [Flow(FlowDirection.In)] WeightPointerTypeARB type, [Flow(FlowDirection.In)] uint stride, [Count(Computed = "type, stride"), Flow(FlowDirection.In)] Span<T0> pointer) where T0 : struct
        {
            // SpanOverloader
            fixed (void* pointerSpp = pointer)
                thisApi.WeightPointer(size, type, stride, pointerSpp);
        }

    }
}

