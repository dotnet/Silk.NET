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

namespace Silk.NET.OpenGL.Legacy.Extensions.EXT
{
    public static class ExtVertexWeightingOverloads
    {
        public static unsafe void VertexWeight(this ExtVertexWeighting thisApi, [Count(Count = 1), Flow(FlowDirection.In)] ReadOnlySpan<float> weight)
        {
            // SpanOverloader
            thisApi.VertexWeight(in weight.GetPinnableReference());
        }

        public static unsafe void VertexWeightPointer<T0>(this ExtVertexWeighting thisApi, [Flow(FlowDirection.In)] int size, [Flow(FlowDirection.In)] EXT type, [Flow(FlowDirection.In)] uint stride, [Count(Computed = "type, stride"), Flow(FlowDirection.In)] ReadOnlySpan<T0> pointer) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.VertexWeightPointer(size, type, stride, in pointer.GetPinnableReference());
        }

        public static unsafe void VertexWeightPointer<T0>(this ExtVertexWeighting thisApi, [Flow(FlowDirection.In)] int size, [Flow(FlowDirection.In)] VertexWeightPointerTypeEXT type, [Flow(FlowDirection.In)] uint stride, [Count(Computed = "type, stride"), Flow(FlowDirection.In)] ReadOnlySpan<T0> pointer) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.VertexWeightPointer(size, type, stride, in pointer.GetPinnableReference());
        }

    }
}

