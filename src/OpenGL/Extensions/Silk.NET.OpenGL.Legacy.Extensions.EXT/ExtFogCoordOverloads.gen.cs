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
    public static class ExtFogCoordOverloads
    {
        public static unsafe void FogCoord(this ExtFogCoord thisApi, [Count(Count = 1), Flow(FlowDirection.In)] ReadOnlySpan<float> coord)
        {
            // SpanOverloader
            thisApi.FogCoord(in coord.GetPinnableReference());
        }

        public static unsafe void FogCoord(this ExtFogCoord thisApi, [Count(Count = 1), Flow(FlowDirection.In)] ReadOnlySpan<double> coord)
        {
            // SpanOverloader
            thisApi.FogCoord(in coord.GetPinnableReference());
        }

        public static unsafe void FogCoordPointer<T0>(this ExtFogCoord thisApi, [Flow(FlowDirection.In)] EXT type, [Flow(FlowDirection.In)] uint stride, [Count(Computed = "type, stride"), Flow(FlowDirection.In)] ReadOnlySpan<T0> pointer) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.FogCoordPointer(type, stride, in pointer.GetPinnableReference());
        }

        public static unsafe void FogCoordPointer<T0>(this ExtFogCoord thisApi, [Flow(FlowDirection.In)] FogPointerTypeEXT type, [Flow(FlowDirection.In)] uint stride, [Count(Computed = "type, stride"), Flow(FlowDirection.In)] ReadOnlySpan<T0> pointer) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.FogCoordPointer(type, stride, in pointer.GetPinnableReference());
        }

    }
}

