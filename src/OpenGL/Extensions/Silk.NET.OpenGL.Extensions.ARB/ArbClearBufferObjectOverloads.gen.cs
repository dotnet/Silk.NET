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
    public static class ArbClearBufferObjectOverloads
    {
        public static unsafe void ClearBufferData<T0>(this ArbClearBufferObject thisApi, [Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] ARB internalformat, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type"), Flow(FlowDirection.In)] Span<T0> data) where T0 : struct
        {
            // SpanOverloader
            fixed (void* dataSpp = data)
                thisApi.ClearBufferData(target, internalformat, format, type, dataSpp);
        }

        public static unsafe void ClearBufferData<T0>(this ArbClearBufferObject thisApi, [Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] ARB internalformat, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] ARB type, [Count(Computed = "format, type"), Flow(FlowDirection.In)] Span<T0> data) where T0 : struct
        {
            // SpanOverloader
            fixed (void* dataSpp = data)
                thisApi.ClearBufferData(target, internalformat, format, type, dataSpp);
        }

        public static unsafe void ClearBufferData<T0>(this ArbClearBufferObject thisApi, [Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] ARB internalformat, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type"), Flow(FlowDirection.In)] Span<T0> data) where T0 : struct
        {
            // SpanOverloader
            fixed (void* dataSpp = data)
                thisApi.ClearBufferData(target, internalformat, format, type, dataSpp);
        }

        public static unsafe void ClearBufferData<T0>(this ArbClearBufferObject thisApi, [Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] SizedInternalFormat internalformat, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] ARB type, [Count(Computed = "format, type"), Flow(FlowDirection.In)] Span<T0> data) where T0 : struct
        {
            // SpanOverloader
            fixed (void* dataSpp = data)
                thisApi.ClearBufferData(target, internalformat, format, type, dataSpp);
        }

        public static unsafe void ClearBufferData<T0>(this ArbClearBufferObject thisApi, [Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] SizedInternalFormat internalformat, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type"), Flow(FlowDirection.In)] Span<T0> data) where T0 : struct
        {
            // SpanOverloader
            fixed (void* dataSpp = data)
                thisApi.ClearBufferData(target, internalformat, format, type, dataSpp);
        }

        public static unsafe void ClearBufferData<T0>(this ArbClearBufferObject thisApi, [Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] SizedInternalFormat internalformat, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] ARB type, [Count(Computed = "format, type"), Flow(FlowDirection.In)] Span<T0> data) where T0 : struct
        {
            // SpanOverloader
            fixed (void* dataSpp = data)
                thisApi.ClearBufferData(target, internalformat, format, type, dataSpp);
        }

        public static unsafe void ClearBufferData<T0>(this ArbClearBufferObject thisApi, [Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] SizedInternalFormat internalformat, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type"), Flow(FlowDirection.In)] Span<T0> data) where T0 : struct
        {
            // SpanOverloader
            fixed (void* dataSpp = data)
                thisApi.ClearBufferData(target, internalformat, format, type, dataSpp);
        }

        public static unsafe void ClearBufferData<T0>(this ArbClearBufferObject thisApi, [Flow(FlowDirection.In)] BufferStorageTarget target, [Flow(FlowDirection.In)] ARB internalformat, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] ARB type, [Count(Computed = "format, type"), Flow(FlowDirection.In)] Span<T0> data) where T0 : struct
        {
            // SpanOverloader
            fixed (void* dataSpp = data)
                thisApi.ClearBufferData(target, internalformat, format, type, dataSpp);
        }

        public static unsafe void ClearBufferData<T0>(this ArbClearBufferObject thisApi, [Flow(FlowDirection.In)] BufferStorageTarget target, [Flow(FlowDirection.In)] ARB internalformat, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type"), Flow(FlowDirection.In)] Span<T0> data) where T0 : struct
        {
            // SpanOverloader
            fixed (void* dataSpp = data)
                thisApi.ClearBufferData(target, internalformat, format, type, dataSpp);
        }

        public static unsafe void ClearBufferData<T0>(this ArbClearBufferObject thisApi, [Flow(FlowDirection.In)] BufferStorageTarget target, [Flow(FlowDirection.In)] ARB internalformat, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] ARB type, [Count(Computed = "format, type"), Flow(FlowDirection.In)] Span<T0> data) where T0 : struct
        {
            // SpanOverloader
            fixed (void* dataSpp = data)
                thisApi.ClearBufferData(target, internalformat, format, type, dataSpp);
        }

        public static unsafe void ClearBufferData<T0>(this ArbClearBufferObject thisApi, [Flow(FlowDirection.In)] BufferStorageTarget target, [Flow(FlowDirection.In)] ARB internalformat, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type"), Flow(FlowDirection.In)] Span<T0> data) where T0 : struct
        {
            // SpanOverloader
            fixed (void* dataSpp = data)
                thisApi.ClearBufferData(target, internalformat, format, type, dataSpp);
        }

        public static unsafe void ClearBufferData<T0>(this ArbClearBufferObject thisApi, [Flow(FlowDirection.In)] BufferStorageTarget target, [Flow(FlowDirection.In)] SizedInternalFormat internalformat, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] ARB type, [Count(Computed = "format, type"), Flow(FlowDirection.In)] Span<T0> data) where T0 : struct
        {
            // SpanOverloader
            fixed (void* dataSpp = data)
                thisApi.ClearBufferData(target, internalformat, format, type, dataSpp);
        }

        public static unsafe void ClearBufferData<T0>(this ArbClearBufferObject thisApi, [Flow(FlowDirection.In)] BufferStorageTarget target, [Flow(FlowDirection.In)] SizedInternalFormat internalformat, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type"), Flow(FlowDirection.In)] Span<T0> data) where T0 : struct
        {
            // SpanOverloader
            fixed (void* dataSpp = data)
                thisApi.ClearBufferData(target, internalformat, format, type, dataSpp);
        }

        public static unsafe void ClearBufferData<T0>(this ArbClearBufferObject thisApi, [Flow(FlowDirection.In)] BufferStorageTarget target, [Flow(FlowDirection.In)] SizedInternalFormat internalformat, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] ARB type, [Count(Computed = "format, type"), Flow(FlowDirection.In)] Span<T0> data) where T0 : struct
        {
            // SpanOverloader
            fixed (void* dataSpp = data)
                thisApi.ClearBufferData(target, internalformat, format, type, dataSpp);
        }

        public static unsafe void ClearBufferData<T0>(this ArbClearBufferObject thisApi, [Flow(FlowDirection.In)] BufferStorageTarget target, [Flow(FlowDirection.In)] SizedInternalFormat internalformat, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type"), Flow(FlowDirection.In)] Span<T0> data) where T0 : struct
        {
            // SpanOverloader
            fixed (void* dataSpp = data)
                thisApi.ClearBufferData(target, internalformat, format, type, dataSpp);
        }

        public static unsafe void ClearBufferSubData<T0>(this ArbClearBufferObject thisApi, [Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] ARB internalformat, [Flow(FlowDirection.In)] nint offset, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type"), Flow(FlowDirection.In)] Span<T0> data) where T0 : struct
        {
            // SpanOverloader
            fixed (void* dataSpp = data)
                thisApi.ClearBufferSubData(target, internalformat, offset, size, format, type, dataSpp);
        }

        public static unsafe void ClearBufferSubData<T0>(this ArbClearBufferObject thisApi, [Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] ARB internalformat, [Flow(FlowDirection.In)] nint offset, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] ARB type, [Count(Computed = "format, type"), Flow(FlowDirection.In)] Span<T0> data) where T0 : struct
        {
            // SpanOverloader
            fixed (void* dataSpp = data)
                thisApi.ClearBufferSubData(target, internalformat, offset, size, format, type, dataSpp);
        }

        public static unsafe void ClearBufferSubData<T0>(this ArbClearBufferObject thisApi, [Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] ARB internalformat, [Flow(FlowDirection.In)] nint offset, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type"), Flow(FlowDirection.In)] Span<T0> data) where T0 : struct
        {
            // SpanOverloader
            fixed (void* dataSpp = data)
                thisApi.ClearBufferSubData(target, internalformat, offset, size, format, type, dataSpp);
        }

        public static unsafe void ClearBufferSubData<T0>(this ArbClearBufferObject thisApi, [Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] SizedInternalFormat internalformat, [Flow(FlowDirection.In)] nint offset, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] ARB type, [Count(Computed = "format, type"), Flow(FlowDirection.In)] Span<T0> data) where T0 : struct
        {
            // SpanOverloader
            fixed (void* dataSpp = data)
                thisApi.ClearBufferSubData(target, internalformat, offset, size, format, type, dataSpp);
        }

        public static unsafe void ClearBufferSubData<T0>(this ArbClearBufferObject thisApi, [Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] SizedInternalFormat internalformat, [Flow(FlowDirection.In)] nint offset, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type"), Flow(FlowDirection.In)] Span<T0> data) where T0 : struct
        {
            // SpanOverloader
            fixed (void* dataSpp = data)
                thisApi.ClearBufferSubData(target, internalformat, offset, size, format, type, dataSpp);
        }

        public static unsafe void ClearBufferSubData<T0>(this ArbClearBufferObject thisApi, [Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] SizedInternalFormat internalformat, [Flow(FlowDirection.In)] nint offset, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] ARB type, [Count(Computed = "format, type"), Flow(FlowDirection.In)] Span<T0> data) where T0 : struct
        {
            // SpanOverloader
            fixed (void* dataSpp = data)
                thisApi.ClearBufferSubData(target, internalformat, offset, size, format, type, dataSpp);
        }

        public static unsafe void ClearBufferSubData<T0>(this ArbClearBufferObject thisApi, [Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] SizedInternalFormat internalformat, [Flow(FlowDirection.In)] nint offset, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type"), Flow(FlowDirection.In)] Span<T0> data) where T0 : struct
        {
            // SpanOverloader
            fixed (void* dataSpp = data)
                thisApi.ClearBufferSubData(target, internalformat, offset, size, format, type, dataSpp);
        }

        public static unsafe void ClearBufferSubData<T0>(this ArbClearBufferObject thisApi, [Flow(FlowDirection.In)] BufferTargetARB target, [Flow(FlowDirection.In)] ARB internalformat, [Flow(FlowDirection.In)] nint offset, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] ARB type, [Count(Computed = "format, type"), Flow(FlowDirection.In)] Span<T0> data) where T0 : struct
        {
            // SpanOverloader
            fixed (void* dataSpp = data)
                thisApi.ClearBufferSubData(target, internalformat, offset, size, format, type, dataSpp);
        }

        public static unsafe void ClearBufferSubData<T0>(this ArbClearBufferObject thisApi, [Flow(FlowDirection.In)] BufferTargetARB target, [Flow(FlowDirection.In)] ARB internalformat, [Flow(FlowDirection.In)] nint offset, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type"), Flow(FlowDirection.In)] Span<T0> data) where T0 : struct
        {
            // SpanOverloader
            fixed (void* dataSpp = data)
                thisApi.ClearBufferSubData(target, internalformat, offset, size, format, type, dataSpp);
        }

        public static unsafe void ClearBufferSubData<T0>(this ArbClearBufferObject thisApi, [Flow(FlowDirection.In)] BufferTargetARB target, [Flow(FlowDirection.In)] ARB internalformat, [Flow(FlowDirection.In)] nint offset, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] ARB type, [Count(Computed = "format, type"), Flow(FlowDirection.In)] Span<T0> data) where T0 : struct
        {
            // SpanOverloader
            fixed (void* dataSpp = data)
                thisApi.ClearBufferSubData(target, internalformat, offset, size, format, type, dataSpp);
        }

        public static unsafe void ClearBufferSubData<T0>(this ArbClearBufferObject thisApi, [Flow(FlowDirection.In)] BufferTargetARB target, [Flow(FlowDirection.In)] ARB internalformat, [Flow(FlowDirection.In)] nint offset, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type"), Flow(FlowDirection.In)] Span<T0> data) where T0 : struct
        {
            // SpanOverloader
            fixed (void* dataSpp = data)
                thisApi.ClearBufferSubData(target, internalformat, offset, size, format, type, dataSpp);
        }

        public static unsafe void ClearBufferSubData<T0>(this ArbClearBufferObject thisApi, [Flow(FlowDirection.In)] BufferTargetARB target, [Flow(FlowDirection.In)] SizedInternalFormat internalformat, [Flow(FlowDirection.In)] nint offset, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] ARB type, [Count(Computed = "format, type"), Flow(FlowDirection.In)] Span<T0> data) where T0 : struct
        {
            // SpanOverloader
            fixed (void* dataSpp = data)
                thisApi.ClearBufferSubData(target, internalformat, offset, size, format, type, dataSpp);
        }

        public static unsafe void ClearBufferSubData<T0>(this ArbClearBufferObject thisApi, [Flow(FlowDirection.In)] BufferTargetARB target, [Flow(FlowDirection.In)] SizedInternalFormat internalformat, [Flow(FlowDirection.In)] nint offset, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type"), Flow(FlowDirection.In)] Span<T0> data) where T0 : struct
        {
            // SpanOverloader
            fixed (void* dataSpp = data)
                thisApi.ClearBufferSubData(target, internalformat, offset, size, format, type, dataSpp);
        }

        public static unsafe void ClearBufferSubData<T0>(this ArbClearBufferObject thisApi, [Flow(FlowDirection.In)] BufferTargetARB target, [Flow(FlowDirection.In)] SizedInternalFormat internalformat, [Flow(FlowDirection.In)] nint offset, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] ARB type, [Count(Computed = "format, type"), Flow(FlowDirection.In)] Span<T0> data) where T0 : struct
        {
            // SpanOverloader
            fixed (void* dataSpp = data)
                thisApi.ClearBufferSubData(target, internalformat, offset, size, format, type, dataSpp);
        }

        public static unsafe void ClearBufferSubData<T0>(this ArbClearBufferObject thisApi, [Flow(FlowDirection.In)] BufferTargetARB target, [Flow(FlowDirection.In)] SizedInternalFormat internalformat, [Flow(FlowDirection.In)] nint offset, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type"), Flow(FlowDirection.In)] Span<T0> data) where T0 : struct
        {
            // SpanOverloader
            fixed (void* dataSpp = data)
                thisApi.ClearBufferSubData(target, internalformat, offset, size, format, type, dataSpp);
        }

    }
}

