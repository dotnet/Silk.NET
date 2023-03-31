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

namespace Silk.NET.OpenGL.Legacy.Extensions.EXT
{
    public static class ExtDrawRangeElementsOverloads
    {
        public static unsafe void DrawRangeElements<T0>(this ExtDrawRangeElements thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT mode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint start, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint end, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT type, [Count(Computed = "count, type"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> indices) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.DrawRangeElements(mode, start, end, count, type, in indices.GetPinnableReference());
        }

        public static unsafe void DrawRangeElements<T0>(this ExtDrawRangeElements thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT mode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint start, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint end, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] DrawElementsType type, [Count(Computed = "count, type"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> indices) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.DrawRangeElements(mode, start, end, count, type, in indices.GetPinnableReference());
        }

        public static unsafe void DrawRangeElements<T0>(this ExtDrawRangeElements thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PrimitiveType mode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint start, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint end, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT type, [Count(Computed = "count, type"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> indices) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.DrawRangeElements(mode, start, end, count, type, in indices.GetPinnableReference());
        }

        public static unsafe void DrawRangeElements<T0>(this ExtDrawRangeElements thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PrimitiveType mode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint start, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint end, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] DrawElementsType type, [Count(Computed = "count, type"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> indices) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.DrawRangeElements(mode, start, end, count, type, in indices.GetPinnableReference());
        }

    }
}

