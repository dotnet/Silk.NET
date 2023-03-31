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

namespace Silk.NET.OpenGLES.Extensions.NV
{
    public static class NVDrawInstancedOverloads
    {
        public static unsafe void DrawElementsInstanced<T0>(this NVDrawInstanced thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV mode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV type, [Count(Computed = "count, type"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> indices, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint primcount) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.DrawElementsInstanced(mode, count, type, in indices.GetPinnableReference(), primcount);
        }

        public static unsafe void DrawElementsInstanced<T0>(this NVDrawInstanced thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV mode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] DrawElementsType type, [Count(Computed = "count, type"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> indices, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint primcount) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.DrawElementsInstanced(mode, count, type, in indices.GetPinnableReference(), primcount);
        }

        public static unsafe void DrawElementsInstanced<T0>(this NVDrawInstanced thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PrimitiveType mode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV type, [Count(Computed = "count, type"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> indices, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint primcount) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.DrawElementsInstanced(mode, count, type, in indices.GetPinnableReference(), primcount);
        }

        public static unsafe void DrawElementsInstanced<T0>(this NVDrawInstanced thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PrimitiveType mode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] DrawElementsType type, [Count(Computed = "count, type"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> indices, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint primcount) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.DrawElementsInstanced(mode, count, type, in indices.GetPinnableReference(), primcount);
        }

    }
}

