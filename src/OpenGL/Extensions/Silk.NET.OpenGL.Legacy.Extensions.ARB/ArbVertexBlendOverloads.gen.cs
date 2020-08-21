// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
using System;
using System.Runtime.InteropServices;
using System.Text;
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

        public static unsafe void WeightPointer<T0>(this ArbVertexBlend thisApi, [Flow(FlowDirection.In)] int size, [Flow(FlowDirection.In)] ARB type, [Flow(FlowDirection.In)] uint stride, [Count(Computed = "type, stride"), Flow(FlowDirection.In)] ReadOnlySpan<T0> pointer) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.WeightPointer(size, type, stride, in pointer.GetPinnableReference());
        }

        public static unsafe void WeightPointer<T0>(this ArbVertexBlend thisApi, [Flow(FlowDirection.In)] int size, [Flow(FlowDirection.In)] WeightPointerTypeARB type, [Flow(FlowDirection.In)] uint stride, [Count(Computed = "type, stride"), Flow(FlowDirection.In)] ReadOnlySpan<T0> pointer) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.WeightPointer(size, type, stride, in pointer.GetPinnableReference());
        }

    }
}

