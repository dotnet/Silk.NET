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

namespace Silk.NET.OpenGL.Legacy.Extensions.ARB
{
    public static class ArbClearBufferObjectOverloads
    {
        public static unsafe void ClearBufferData<T0>(this ArbClearBufferObject thisApi, [Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] ARB internalformat, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] ARB type, [Count(Computed = "format, type"), Flow(FlowDirection.In)] ReadOnlySpan<T0> data) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.ClearBufferData(target, internalformat, format, type, in data.GetPinnableReference());
        }

        public static unsafe void ClearBufferData<T0>(this ArbClearBufferObject thisApi, [Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] ARB internalformat, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type"), Flow(FlowDirection.In)] ReadOnlySpan<T0> data) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.ClearBufferData(target, internalformat, format, type, in data.GetPinnableReference());
        }

        public static unsafe void ClearBufferData<T0>(this ArbClearBufferObject thisApi, [Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] ARB internalformat, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] ARB type, [Count(Computed = "format, type"), Flow(FlowDirection.In)] ReadOnlySpan<T0> data) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.ClearBufferData(target, internalformat, format, type, in data.GetPinnableReference());
        }

        public static unsafe void ClearBufferData<T0>(this ArbClearBufferObject thisApi, [Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] ARB internalformat, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type"), Flow(FlowDirection.In)] ReadOnlySpan<T0> data) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.ClearBufferData(target, internalformat, format, type, in data.GetPinnableReference());
        }

        public static unsafe void ClearBufferData<T0>(this ArbClearBufferObject thisApi, [Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] ARB type, [Count(Computed = "format, type"), Flow(FlowDirection.In)] ReadOnlySpan<T0> data) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.ClearBufferData(target, internalformat, format, type, in data.GetPinnableReference());
        }

        public static unsafe void ClearBufferData<T0>(this ArbClearBufferObject thisApi, [Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type"), Flow(FlowDirection.In)] ReadOnlySpan<T0> data) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.ClearBufferData(target, internalformat, format, type, in data.GetPinnableReference());
        }

        public static unsafe void ClearBufferData<T0>(this ArbClearBufferObject thisApi, [Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] ARB type, [Count(Computed = "format, type"), Flow(FlowDirection.In)] ReadOnlySpan<T0> data) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.ClearBufferData(target, internalformat, format, type, in data.GetPinnableReference());
        }

        public static unsafe void ClearBufferData<T0>(this ArbClearBufferObject thisApi, [Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type"), Flow(FlowDirection.In)] ReadOnlySpan<T0> data) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.ClearBufferData(target, internalformat, format, type, in data.GetPinnableReference());
        }

        public static unsafe void ClearBufferData<T0>(this ArbClearBufferObject thisApi, [Flow(FlowDirection.In)] BufferStorageTarget target, [Flow(FlowDirection.In)] ARB internalformat, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] ARB type, [Count(Computed = "format, type"), Flow(FlowDirection.In)] ReadOnlySpan<T0> data) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.ClearBufferData(target, internalformat, format, type, in data.GetPinnableReference());
        }

        public static unsafe void ClearBufferData<T0>(this ArbClearBufferObject thisApi, [Flow(FlowDirection.In)] BufferStorageTarget target, [Flow(FlowDirection.In)] ARB internalformat, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type"), Flow(FlowDirection.In)] ReadOnlySpan<T0> data) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.ClearBufferData(target, internalformat, format, type, in data.GetPinnableReference());
        }

        public static unsafe void ClearBufferData<T0>(this ArbClearBufferObject thisApi, [Flow(FlowDirection.In)] BufferStorageTarget target, [Flow(FlowDirection.In)] ARB internalformat, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] ARB type, [Count(Computed = "format, type"), Flow(FlowDirection.In)] ReadOnlySpan<T0> data) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.ClearBufferData(target, internalformat, format, type, in data.GetPinnableReference());
        }

        public static unsafe void ClearBufferData<T0>(this ArbClearBufferObject thisApi, [Flow(FlowDirection.In)] BufferStorageTarget target, [Flow(FlowDirection.In)] ARB internalformat, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type"), Flow(FlowDirection.In)] ReadOnlySpan<T0> data) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.ClearBufferData(target, internalformat, format, type, in data.GetPinnableReference());
        }

        public static unsafe void ClearBufferData<T0>(this ArbClearBufferObject thisApi, [Flow(FlowDirection.In)] BufferStorageTarget target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] ARB type, [Count(Computed = "format, type"), Flow(FlowDirection.In)] ReadOnlySpan<T0> data) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.ClearBufferData(target, internalformat, format, type, in data.GetPinnableReference());
        }

        public static unsafe void ClearBufferData<T0>(this ArbClearBufferObject thisApi, [Flow(FlowDirection.In)] BufferStorageTarget target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type"), Flow(FlowDirection.In)] ReadOnlySpan<T0> data) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.ClearBufferData(target, internalformat, format, type, in data.GetPinnableReference());
        }

        public static unsafe void ClearBufferData<T0>(this ArbClearBufferObject thisApi, [Flow(FlowDirection.In)] BufferStorageTarget target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] ARB type, [Count(Computed = "format, type"), Flow(FlowDirection.In)] ReadOnlySpan<T0> data) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.ClearBufferData(target, internalformat, format, type, in data.GetPinnableReference());
        }

        public static unsafe void ClearBufferData<T0>(this ArbClearBufferObject thisApi, [Flow(FlowDirection.In)] BufferStorageTarget target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type"), Flow(FlowDirection.In)] ReadOnlySpan<T0> data) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.ClearBufferData(target, internalformat, format, type, in data.GetPinnableReference());
        }

        public static unsafe void ClearBufferSubData<T0>(this ArbClearBufferObject thisApi, [Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] ARB internalformat, [Flow(FlowDirection.In)] IntPtr offset, [Flow(FlowDirection.In)] UIntPtr size, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] ARB type, [Count(Computed = "format, type"), Flow(FlowDirection.In)] ReadOnlySpan<T0> data) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.ClearBufferSubData(target, internalformat, offset, size, format, type, in data.GetPinnableReference());
        }

        public static unsafe void ClearBufferSubData<T0>(this ArbClearBufferObject thisApi, [Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] ARB internalformat, [Flow(FlowDirection.In)] IntPtr offset, [Flow(FlowDirection.In)] UIntPtr size, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type"), Flow(FlowDirection.In)] ReadOnlySpan<T0> data) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.ClearBufferSubData(target, internalformat, offset, size, format, type, in data.GetPinnableReference());
        }

        public static unsafe void ClearBufferSubData<T0>(this ArbClearBufferObject thisApi, [Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] ARB internalformat, [Flow(FlowDirection.In)] IntPtr offset, [Flow(FlowDirection.In)] UIntPtr size, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] ARB type, [Count(Computed = "format, type"), Flow(FlowDirection.In)] ReadOnlySpan<T0> data) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.ClearBufferSubData(target, internalformat, offset, size, format, type, in data.GetPinnableReference());
        }

        public static unsafe void ClearBufferSubData<T0>(this ArbClearBufferObject thisApi, [Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] ARB internalformat, [Flow(FlowDirection.In)] IntPtr offset, [Flow(FlowDirection.In)] UIntPtr size, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type"), Flow(FlowDirection.In)] ReadOnlySpan<T0> data) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.ClearBufferSubData(target, internalformat, offset, size, format, type, in data.GetPinnableReference());
        }

        public static unsafe void ClearBufferSubData<T0>(this ArbClearBufferObject thisApi, [Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] IntPtr offset, [Flow(FlowDirection.In)] UIntPtr size, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] ARB type, [Count(Computed = "format, type"), Flow(FlowDirection.In)] ReadOnlySpan<T0> data) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.ClearBufferSubData(target, internalformat, offset, size, format, type, in data.GetPinnableReference());
        }

        public static unsafe void ClearBufferSubData<T0>(this ArbClearBufferObject thisApi, [Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] IntPtr offset, [Flow(FlowDirection.In)] UIntPtr size, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type"), Flow(FlowDirection.In)] ReadOnlySpan<T0> data) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.ClearBufferSubData(target, internalformat, offset, size, format, type, in data.GetPinnableReference());
        }

        public static unsafe void ClearBufferSubData<T0>(this ArbClearBufferObject thisApi, [Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] IntPtr offset, [Flow(FlowDirection.In)] UIntPtr size, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] ARB type, [Count(Computed = "format, type"), Flow(FlowDirection.In)] ReadOnlySpan<T0> data) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.ClearBufferSubData(target, internalformat, offset, size, format, type, in data.GetPinnableReference());
        }

        public static unsafe void ClearBufferSubData<T0>(this ArbClearBufferObject thisApi, [Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] IntPtr offset, [Flow(FlowDirection.In)] UIntPtr size, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type"), Flow(FlowDirection.In)] ReadOnlySpan<T0> data) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.ClearBufferSubData(target, internalformat, offset, size, format, type, in data.GetPinnableReference());
        }

        public static unsafe void ClearBufferSubData<T0>(this ArbClearBufferObject thisApi, [Flow(FlowDirection.In)] BufferTargetARB target, [Flow(FlowDirection.In)] ARB internalformat, [Flow(FlowDirection.In)] IntPtr offset, [Flow(FlowDirection.In)] UIntPtr size, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] ARB type, [Count(Computed = "format, type"), Flow(FlowDirection.In)] ReadOnlySpan<T0> data) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.ClearBufferSubData(target, internalformat, offset, size, format, type, in data.GetPinnableReference());
        }

        public static unsafe void ClearBufferSubData<T0>(this ArbClearBufferObject thisApi, [Flow(FlowDirection.In)] BufferTargetARB target, [Flow(FlowDirection.In)] ARB internalformat, [Flow(FlowDirection.In)] IntPtr offset, [Flow(FlowDirection.In)] UIntPtr size, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type"), Flow(FlowDirection.In)] ReadOnlySpan<T0> data) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.ClearBufferSubData(target, internalformat, offset, size, format, type, in data.GetPinnableReference());
        }

        public static unsafe void ClearBufferSubData<T0>(this ArbClearBufferObject thisApi, [Flow(FlowDirection.In)] BufferTargetARB target, [Flow(FlowDirection.In)] ARB internalformat, [Flow(FlowDirection.In)] IntPtr offset, [Flow(FlowDirection.In)] UIntPtr size, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] ARB type, [Count(Computed = "format, type"), Flow(FlowDirection.In)] ReadOnlySpan<T0> data) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.ClearBufferSubData(target, internalformat, offset, size, format, type, in data.GetPinnableReference());
        }

        public static unsafe void ClearBufferSubData<T0>(this ArbClearBufferObject thisApi, [Flow(FlowDirection.In)] BufferTargetARB target, [Flow(FlowDirection.In)] ARB internalformat, [Flow(FlowDirection.In)] IntPtr offset, [Flow(FlowDirection.In)] UIntPtr size, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type"), Flow(FlowDirection.In)] ReadOnlySpan<T0> data) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.ClearBufferSubData(target, internalformat, offset, size, format, type, in data.GetPinnableReference());
        }

        public static unsafe void ClearBufferSubData<T0>(this ArbClearBufferObject thisApi, [Flow(FlowDirection.In)] BufferTargetARB target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] IntPtr offset, [Flow(FlowDirection.In)] UIntPtr size, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] ARB type, [Count(Computed = "format, type"), Flow(FlowDirection.In)] ReadOnlySpan<T0> data) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.ClearBufferSubData(target, internalformat, offset, size, format, type, in data.GetPinnableReference());
        }

        public static unsafe void ClearBufferSubData<T0>(this ArbClearBufferObject thisApi, [Flow(FlowDirection.In)] BufferTargetARB target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] IntPtr offset, [Flow(FlowDirection.In)] UIntPtr size, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type"), Flow(FlowDirection.In)] ReadOnlySpan<T0> data) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.ClearBufferSubData(target, internalformat, offset, size, format, type, in data.GetPinnableReference());
        }

        public static unsafe void ClearBufferSubData<T0>(this ArbClearBufferObject thisApi, [Flow(FlowDirection.In)] BufferTargetARB target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] IntPtr offset, [Flow(FlowDirection.In)] UIntPtr size, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] ARB type, [Count(Computed = "format, type"), Flow(FlowDirection.In)] ReadOnlySpan<T0> data) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.ClearBufferSubData(target, internalformat, offset, size, format, type, in data.GetPinnableReference());
        }

        public static unsafe void ClearBufferSubData<T0>(this ArbClearBufferObject thisApi, [Flow(FlowDirection.In)] BufferTargetARB target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] IntPtr offset, [Flow(FlowDirection.In)] UIntPtr size, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type"), Flow(FlowDirection.In)] ReadOnlySpan<T0> data) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.ClearBufferSubData(target, internalformat, offset, size, format, type, in data.GetPinnableReference());
        }

    }
}

