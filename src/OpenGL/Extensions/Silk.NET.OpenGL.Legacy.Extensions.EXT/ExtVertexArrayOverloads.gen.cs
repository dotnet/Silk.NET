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
    public static class ExtVertexArrayOverloads
    {
        public static unsafe void EdgeFlagPointer(this ExtVertexArray thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint stride, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Computed = "stride, count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<bool> pointer)
        {
            // SpanOverloader
            thisApi.EdgeFlagPointer(stride, count, in pointer.GetPinnableReference());
        }

        public static unsafe void IndexPointer<T0>(this ExtVertexArray thisApi, [Flow(FlowDirection.In)] IndexPointerType type, [Flow(FlowDirection.In)] uint stride, [Flow(FlowDirection.In)] uint count, [Count(Computed = "type, stride, count"), Flow(FlowDirection.In)] Span<T0> pointer) where T0 : struct
        {
            // SpanOverloader
            fixed (void* pointerSpp = pointer)
                thisApi.IndexPointer(type, stride, count, pointerSpp);
        }

        public static unsafe void NormalPointer<T0>(this ExtVertexArray thisApi, [Flow(FlowDirection.In)] NormalPointerType type, [Flow(FlowDirection.In)] uint stride, [Flow(FlowDirection.In)] uint count, [Count(Computed = "type, stride, count"), Flow(FlowDirection.In)] Span<T0> pointer) where T0 : struct
        {
            // SpanOverloader
            fixed (void* pointerSpp = pointer)
                thisApi.NormalPointer(type, stride, count, pointerSpp);
        }

        public static unsafe void TexCoordPointer<T0>(this ExtVertexArray thisApi, [Flow(FlowDirection.In)] int size, [Flow(FlowDirection.In)] TexCoordPointerType type, [Flow(FlowDirection.In)] uint stride, [Flow(FlowDirection.In)] uint count, [Count(Computed = "size, type, stride, count"), Flow(FlowDirection.In)] Span<T0> pointer) where T0 : struct
        {
            // SpanOverloader
            fixed (void* pointerSpp = pointer)
                thisApi.TexCoordPointer(size, type, stride, count, pointerSpp);
        }

        public static unsafe void VertexPointer<T0>(this ExtVertexArray thisApi, [Flow(FlowDirection.In)] int size, [Flow(FlowDirection.In)] VertexPointerType type, [Flow(FlowDirection.In)] uint stride, [Flow(FlowDirection.In)] uint count, [Count(Computed = "size, type, stride, count"), Flow(FlowDirection.In)] Span<T0> pointer) where T0 : struct
        {
            // SpanOverloader
            fixed (void* pointerSpp = pointer)
                thisApi.VertexPointer(size, type, stride, count, pointerSpp);
        }

    }
}

