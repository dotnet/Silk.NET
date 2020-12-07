// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
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

namespace Silk.NET.OpenGL.Legacy.Extensions.EXT
{
    public static class ExtDrawInstancedOverloads
    {
        public static unsafe void DrawElementsInstanced<T0>(this ExtDrawInstanced thisApi, [Flow(FlowDirection.In)] EXT mode, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "count, type"), Flow(FlowDirection.In)] ReadOnlySpan<T0> indices, [Flow(FlowDirection.In)] uint primcount) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.DrawElementsInstanced(mode, count, type, in indices.GetPinnableReference(), primcount);
        }

        public static unsafe void DrawElementsInstanced<T0>(this ExtDrawInstanced thisApi, [Flow(FlowDirection.In)] EXT mode, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] DrawElementsType type, [Count(Computed = "count, type"), Flow(FlowDirection.In)] ReadOnlySpan<T0> indices, [Flow(FlowDirection.In)] uint primcount) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.DrawElementsInstanced(mode, count, type, in indices.GetPinnableReference(), primcount);
        }

        public static unsafe void DrawElementsInstanced<T0>(this ExtDrawInstanced thisApi, [Flow(FlowDirection.In)] PrimitiveType mode, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "count, type"), Flow(FlowDirection.In)] ReadOnlySpan<T0> indices, [Flow(FlowDirection.In)] uint primcount) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.DrawElementsInstanced(mode, count, type, in indices.GetPinnableReference(), primcount);
        }

        public static unsafe void DrawElementsInstanced<T0>(this ExtDrawInstanced thisApi, [Flow(FlowDirection.In)] PrimitiveType mode, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] DrawElementsType type, [Count(Computed = "count, type"), Flow(FlowDirection.In)] ReadOnlySpan<T0> indices, [Flow(FlowDirection.In)] uint primcount) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.DrawElementsInstanced(mode, count, type, in indices.GetPinnableReference(), primcount);
        }

    }
}

