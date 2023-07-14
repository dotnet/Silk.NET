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
    public static class ArbClearBufferObjectOverloads
    {
        public static unsafe void ClearBufferData<T0>(this ArbClearBufferObject thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Count(Computed = "format, type"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> data) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.ClearBufferData(target, internalformat, format, type, in data.GetPinnableReference());
        }

        public static unsafe void ClearBufferData<T0>(this ArbClearBufferObject thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Count(Computed = "format, type"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> data) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.ClearBufferData(target, internalformat, format, type, in data.GetPinnableReference());
        }

        public static unsafe void ClearBufferData<T0>(this ArbClearBufferObject thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Count(Computed = "format, type"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> data) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.ClearBufferData(target, internalformat, format, type, in data.GetPinnableReference());
        }

        public static unsafe void ClearBufferData<T0>(this ArbClearBufferObject thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Count(Computed = "format, type"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> data) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.ClearBufferData(target, internalformat, format, type, in data.GetPinnableReference());
        }

        public static unsafe void ClearBufferData<T0>(this ArbClearBufferObject thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SizedInternalFormat internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Count(Computed = "format, type"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> data) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.ClearBufferData(target, internalformat, format, type, in data.GetPinnableReference());
        }

        public static unsafe void ClearBufferData<T0>(this ArbClearBufferObject thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SizedInternalFormat internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Count(Computed = "format, type"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> data) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.ClearBufferData(target, internalformat, format, type, in data.GetPinnableReference());
        }

        public static unsafe void ClearBufferData<T0>(this ArbClearBufferObject thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SizedInternalFormat internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Count(Computed = "format, type"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> data) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.ClearBufferData(target, internalformat, format, type, in data.GetPinnableReference());
        }

        public static unsafe void ClearBufferData<T0>(this ArbClearBufferObject thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SizedInternalFormat internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Count(Computed = "format, type"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> data) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.ClearBufferData(target, internalformat, format, type, in data.GetPinnableReference());
        }

        public static unsafe void ClearBufferData<T0>(this ArbClearBufferObject thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BufferStorageTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Count(Computed = "format, type"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> data) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.ClearBufferData(target, internalformat, format, type, in data.GetPinnableReference());
        }

        public static unsafe void ClearBufferData<T0>(this ArbClearBufferObject thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BufferStorageTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Count(Computed = "format, type"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> data) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.ClearBufferData(target, internalformat, format, type, in data.GetPinnableReference());
        }

        public static unsafe void ClearBufferData<T0>(this ArbClearBufferObject thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BufferStorageTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Count(Computed = "format, type"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> data) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.ClearBufferData(target, internalformat, format, type, in data.GetPinnableReference());
        }

        public static unsafe void ClearBufferData<T0>(this ArbClearBufferObject thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BufferStorageTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Count(Computed = "format, type"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> data) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.ClearBufferData(target, internalformat, format, type, in data.GetPinnableReference());
        }

        public static unsafe void ClearBufferData<T0>(this ArbClearBufferObject thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BufferStorageTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SizedInternalFormat internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Count(Computed = "format, type"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> data) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.ClearBufferData(target, internalformat, format, type, in data.GetPinnableReference());
        }

        public static unsafe void ClearBufferData<T0>(this ArbClearBufferObject thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BufferStorageTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SizedInternalFormat internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Count(Computed = "format, type"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> data) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.ClearBufferData(target, internalformat, format, type, in data.GetPinnableReference());
        }

        public static unsafe void ClearBufferData<T0>(this ArbClearBufferObject thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BufferStorageTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SizedInternalFormat internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Count(Computed = "format, type"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> data) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.ClearBufferData(target, internalformat, format, type, in data.GetPinnableReference());
        }

        public static unsafe void ClearBufferData<T0>(this ArbClearBufferObject thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BufferStorageTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SizedInternalFormat internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Count(Computed = "format, type"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> data) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.ClearBufferData(target, internalformat, format, type, in data.GetPinnableReference());
        }

        public static unsafe void ClearBufferSubData<T0>(this ArbClearBufferObject thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint offset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Count(Computed = "format, type"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> data) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.ClearBufferSubData(target, internalformat, offset, size, format, type, in data.GetPinnableReference());
        }

        public static unsafe void ClearBufferSubData<T0>(this ArbClearBufferObject thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint offset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Count(Computed = "format, type"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> data) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.ClearBufferSubData(target, internalformat, offset, size, format, type, in data.GetPinnableReference());
        }

        public static unsafe void ClearBufferSubData<T0>(this ArbClearBufferObject thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint offset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Count(Computed = "format, type"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> data) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.ClearBufferSubData(target, internalformat, offset, size, format, type, in data.GetPinnableReference());
        }

        public static unsafe void ClearBufferSubData<T0>(this ArbClearBufferObject thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint offset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Count(Computed = "format, type"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> data) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.ClearBufferSubData(target, internalformat, offset, size, format, type, in data.GetPinnableReference());
        }

        public static unsafe void ClearBufferSubData<T0>(this ArbClearBufferObject thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SizedInternalFormat internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint offset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Count(Computed = "format, type"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> data) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.ClearBufferSubData(target, internalformat, offset, size, format, type, in data.GetPinnableReference());
        }

        public static unsafe void ClearBufferSubData<T0>(this ArbClearBufferObject thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SizedInternalFormat internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint offset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Count(Computed = "format, type"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> data) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.ClearBufferSubData(target, internalformat, offset, size, format, type, in data.GetPinnableReference());
        }

        public static unsafe void ClearBufferSubData<T0>(this ArbClearBufferObject thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SizedInternalFormat internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint offset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Count(Computed = "format, type"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> data) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.ClearBufferSubData(target, internalformat, offset, size, format, type, in data.GetPinnableReference());
        }

        public static unsafe void ClearBufferSubData<T0>(this ArbClearBufferObject thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SizedInternalFormat internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint offset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Count(Computed = "format, type"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> data) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.ClearBufferSubData(target, internalformat, offset, size, format, type, in data.GetPinnableReference());
        }

        public static unsafe void ClearBufferSubData<T0>(this ArbClearBufferObject thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BufferTargetARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint offset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Count(Computed = "format, type"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> data) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.ClearBufferSubData(target, internalformat, offset, size, format, type, in data.GetPinnableReference());
        }

        public static unsafe void ClearBufferSubData<T0>(this ArbClearBufferObject thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BufferTargetARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint offset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Count(Computed = "format, type"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> data) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.ClearBufferSubData(target, internalformat, offset, size, format, type, in data.GetPinnableReference());
        }

        public static unsafe void ClearBufferSubData<T0>(this ArbClearBufferObject thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BufferTargetARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint offset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Count(Computed = "format, type"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> data) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.ClearBufferSubData(target, internalformat, offset, size, format, type, in data.GetPinnableReference());
        }

        public static unsafe void ClearBufferSubData<T0>(this ArbClearBufferObject thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BufferTargetARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint offset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Count(Computed = "format, type"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> data) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.ClearBufferSubData(target, internalformat, offset, size, format, type, in data.GetPinnableReference());
        }

        public static unsafe void ClearBufferSubData<T0>(this ArbClearBufferObject thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BufferTargetARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SizedInternalFormat internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint offset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Count(Computed = "format, type"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> data) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.ClearBufferSubData(target, internalformat, offset, size, format, type, in data.GetPinnableReference());
        }

        public static unsafe void ClearBufferSubData<T0>(this ArbClearBufferObject thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BufferTargetARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SizedInternalFormat internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint offset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Count(Computed = "format, type"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> data) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.ClearBufferSubData(target, internalformat, offset, size, format, type, in data.GetPinnableReference());
        }

        public static unsafe void ClearBufferSubData<T0>(this ArbClearBufferObject thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BufferTargetARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SizedInternalFormat internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint offset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Count(Computed = "format, type"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> data) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.ClearBufferSubData(target, internalformat, offset, size, format, type, in data.GetPinnableReference());
        }

        public static unsafe void ClearBufferSubData<T0>(this ArbClearBufferObject thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BufferTargetARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SizedInternalFormat internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint offset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Count(Computed = "format, type"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> data) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.ClearBufferSubData(target, internalformat, offset, size, format, type, in data.GetPinnableReference());
        }

    }
}

