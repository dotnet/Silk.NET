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
        public static unsafe int GetSemaphoreHandleForType(this KhrExternalSemaphore thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint sema_object, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint device, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ExternalSemaphoreHandleType handle_type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint handle_size, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* handle_ptr, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<nuint> handle_size_ret)
        {
            // SpanOverloader
            return thisApi.GetSemaphoreHandleForType(sema_object, device, handle_type, handle_size, handle_ptr, out handle_size_ret.GetPinnableReference());
        }

        public static unsafe int GetSemaphoreHandleForType<T0>(this KhrExternalSemaphore thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint sema_object, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint device, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ExternalSemaphoreHandleType handle_type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint handle_size, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T0> handle_ptr, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] nuint* handle_size_ret) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.GetSemaphoreHandleForType(sema_object, device, handle_type, handle_size, out handle_ptr.GetPinnableReference(), handle_size_ret);
        }

        public static unsafe int GetSemaphoreHandleForType<T0>(this KhrExternalSemaphore thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint sema_object, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint device, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ExternalSemaphoreHandleType handle_type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint handle_size, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T0> handle_ptr, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<nuint> handle_size_ret) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.GetSemaphoreHandleForType(sema_object, device, handle_type, handle_size, out handle_ptr.GetPinnableReference(), out handle_size_ret.GetPinnableReference());
        }

        [Obsolete("The \"ungrouped\" enums (KHR) are deprecated in favour of the \"grouped\" enums (ExternalSemaphoreHandleType). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", false)]
        public static unsafe int GetSemaphoreHandleForType(this KhrExternalSemaphore thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint sema_object, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint device, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint handle_type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint handle_size, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* handle_ptr, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<nuint> handle_size_ret)
        {
            // SpanOverloader
            return thisApi.GetSemaphoreHandleForType(sema_object, device, handle_type, handle_size, handle_ptr, out handle_size_ret.GetPinnableReference());
        }

        [Obsolete("The \"ungrouped\" enums (KHR) are deprecated in favour of the \"grouped\" enums (ExternalSemaphoreHandleType). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", false)]
        public static unsafe int GetSemaphoreHandleForType<T0>(this KhrExternalSemaphore thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint sema_object, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint device, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint handle_type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint handle_size, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T0> handle_ptr, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] nuint* handle_size_ret) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.GetSemaphoreHandleForType(sema_object, device, handle_type, handle_size, out handle_ptr.GetPinnableReference(), handle_size_ret);
        }

        [Obsolete("The \"ungrouped\" enums (KHR) are deprecated in favour of the \"grouped\" enums (ExternalSemaphoreHandleType). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", false)]
        public static unsafe int GetSemaphoreHandleForType<T0>(this KhrExternalSemaphore thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint sema_object, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint device, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint handle_type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint handle_size, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T0> handle_ptr, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<nuint> handle_size_ret) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.GetSemaphoreHandleForType(sema_object, device, handle_type, handle_size, out handle_ptr.GetPinnableReference(), out handle_size_ret.GetPinnableReference());
        }

    }
}

