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

namespace Silk.NET.OpenCL.Extensions.KHR
{
    public static class KhrExternalSemaphoreOverloads
    {
        public static unsafe int GetSemaphoreHandleForType(this KhrExternalSemaphore thisApi, [Flow(FlowDirection.In)] nint sema_object, [Flow(FlowDirection.In)] nint device, [Flow(FlowDirection.In)] uint handle_type, [Flow(FlowDirection.In)] nuint handle_size, [Flow(FlowDirection.Out)] void* handle_ptr, [Flow(FlowDirection.Out)] Span<nuint> handle_size_ret)
        {
            // SpanOverloader
            return thisApi.GetSemaphoreHandleForType(sema_object, device, handle_type, handle_size, handle_ptr, out handle_size_ret.GetPinnableReference());
        }

        public static unsafe int GetSemaphoreHandleForType<T0>(this KhrExternalSemaphore thisApi, [Flow(FlowDirection.In)] nint sema_object, [Flow(FlowDirection.In)] nint device, [Flow(FlowDirection.In)] uint handle_type, [Flow(FlowDirection.In)] nuint handle_size, [Flow(FlowDirection.Out)] Span<T0> handle_ptr, [Flow(FlowDirection.Out)] nuint* handle_size_ret) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.GetSemaphoreHandleForType(sema_object, device, handle_type, handle_size, out handle_ptr.GetPinnableReference(), handle_size_ret);
        }

        public static unsafe int GetSemaphoreHandleForType<T0>(this KhrExternalSemaphore thisApi, [Flow(FlowDirection.In)] nint sema_object, [Flow(FlowDirection.In)] nint device, [Flow(FlowDirection.In)] uint handle_type, [Flow(FlowDirection.In)] nuint handle_size, [Flow(FlowDirection.Out)] Span<T0> handle_ptr, [Flow(FlowDirection.Out)] Span<nuint> handle_size_ret) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.GetSemaphoreHandleForType(sema_object, device, handle_type, handle_size, out handle_ptr.GetPinnableReference(), out handle_size_ret.GetPinnableReference());
        }

    }
}

