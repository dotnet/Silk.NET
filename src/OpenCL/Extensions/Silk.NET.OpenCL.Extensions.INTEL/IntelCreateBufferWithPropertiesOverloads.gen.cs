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

namespace Silk.NET.OpenCL.Extensions.INTEL
{
    public static class IntelCreateBufferWithPropertiesOverloads
    {
        public static unsafe nint CreateBufferWithProperties(this IntelCreateBufferWithProperties thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint context, [Flow(Silk.NET.Core.Native.FlowDirection.In)] MemProperties* properties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] MemFlags flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint size, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* host_ptr, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<int> errcode_ret)
        {
            // SpanOverloader
            return thisApi.CreateBufferWithProperties(context, properties, flags, size, host_ptr, out errcode_ret.GetPinnableReference());
        }

        public static unsafe nint CreateBufferWithProperties<T0>(this IntelCreateBufferWithProperties thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint context, [Flow(Silk.NET.Core.Native.FlowDirection.In)] MemProperties* properties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] MemFlags flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint size, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T0> host_ptr, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* errcode_ret) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.CreateBufferWithProperties(context, properties, flags, size, out host_ptr.GetPinnableReference(), errcode_ret);
        }

        public static unsafe nint CreateBufferWithProperties<T0>(this IntelCreateBufferWithProperties thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint context, [Flow(Silk.NET.Core.Native.FlowDirection.In)] MemProperties* properties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] MemFlags flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint size, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T0> host_ptr, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<int> errcode_ret) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.CreateBufferWithProperties(context, properties, flags, size, out host_ptr.GetPinnableReference(), out errcode_ret.GetPinnableReference());
        }

        public static unsafe nint CreateBufferWithProperties(this IntelCreateBufferWithProperties thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint context, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<MemProperties> properties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] MemFlags flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint size, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* host_ptr, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* errcode_ret)
        {
            // SpanOverloader
            return thisApi.CreateBufferWithProperties(context, in properties.GetPinnableReference(), flags, size, host_ptr, errcode_ret);
        }

        public static unsafe nint CreateBufferWithProperties(this IntelCreateBufferWithProperties thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint context, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<MemProperties> properties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] MemFlags flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint size, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* host_ptr, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<int> errcode_ret)
        {
            // SpanOverloader
            return thisApi.CreateBufferWithProperties(context, in properties.GetPinnableReference(), flags, size, host_ptr, out errcode_ret.GetPinnableReference());
        }

        public static unsafe nint CreateBufferWithProperties<T0>(this IntelCreateBufferWithProperties thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint context, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<MemProperties> properties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] MemFlags flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint size, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T0> host_ptr, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* errcode_ret) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.CreateBufferWithProperties(context, in properties.GetPinnableReference(), flags, size, out host_ptr.GetPinnableReference(), errcode_ret);
        }

        public static unsafe nint CreateBufferWithProperties<T0>(this IntelCreateBufferWithProperties thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint context, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<MemProperties> properties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] MemFlags flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint size, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T0> host_ptr, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<int> errcode_ret) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.CreateBufferWithProperties(context, in properties.GetPinnableReference(), flags, size, out host_ptr.GetPinnableReference(), out errcode_ret.GetPinnableReference());
        }

        [Obsolete("The \"ungrouped\" enums (INTEL, CLEnum) are deprecated in favour of the \"grouped\" enums (MemProperties, MemFlags). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", true)]
        public static unsafe nint CreateBufferWithProperties(this IntelCreateBufferWithProperties thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint context, [Flow(Silk.NET.Core.Native.FlowDirection.In)] MemProperties* properties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CLEnum flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint size, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* host_ptr, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<int> errcode_ret)
        {
            // SpanOverloader
            return thisApi.CreateBufferWithProperties(context, properties, flags, size, host_ptr, out errcode_ret.GetPinnableReference());
        }

        [Obsolete("The \"ungrouped\" enums (INTEL, CLEnum) are deprecated in favour of the \"grouped\" enums (MemProperties, MemFlags). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", true)]
        public static unsafe nint CreateBufferWithProperties<T0>(this IntelCreateBufferWithProperties thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint context, [Flow(Silk.NET.Core.Native.FlowDirection.In)] MemProperties* properties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CLEnum flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint size, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T0> host_ptr, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* errcode_ret) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.CreateBufferWithProperties(context, properties, flags, size, out host_ptr.GetPinnableReference(), errcode_ret);
        }

        [Obsolete("The \"ungrouped\" enums (INTEL, CLEnum) are deprecated in favour of the \"grouped\" enums (MemProperties, MemFlags). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", true)]
        public static unsafe nint CreateBufferWithProperties<T0>(this IntelCreateBufferWithProperties thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint context, [Flow(Silk.NET.Core.Native.FlowDirection.In)] MemProperties* properties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CLEnum flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint size, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T0> host_ptr, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<int> errcode_ret) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.CreateBufferWithProperties(context, properties, flags, size, out host_ptr.GetPinnableReference(), out errcode_ret.GetPinnableReference());
        }

        [Obsolete("The \"ungrouped\" enums (INTEL, CLEnum) are deprecated in favour of the \"grouped\" enums (MemProperties, MemFlags). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", true)]
        public static unsafe nint CreateBufferWithProperties(this IntelCreateBufferWithProperties thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint context, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<MemProperties> properties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CLEnum flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint size, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* host_ptr, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* errcode_ret)
        {
            // SpanOverloader
            return thisApi.CreateBufferWithProperties(context, in properties.GetPinnableReference(), flags, size, host_ptr, errcode_ret);
        }

        [Obsolete("The \"ungrouped\" enums (INTEL, CLEnum) are deprecated in favour of the \"grouped\" enums (MemProperties, MemFlags). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", true)]
        public static unsafe nint CreateBufferWithProperties(this IntelCreateBufferWithProperties thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint context, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<MemProperties> properties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CLEnum flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint size, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* host_ptr, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<int> errcode_ret)
        {
            // SpanOverloader
            return thisApi.CreateBufferWithProperties(context, in properties.GetPinnableReference(), flags, size, host_ptr, out errcode_ret.GetPinnableReference());
        }

        [Obsolete("The \"ungrouped\" enums (INTEL, CLEnum) are deprecated in favour of the \"grouped\" enums (MemProperties, MemFlags). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", true)]
        public static unsafe nint CreateBufferWithProperties<T0>(this IntelCreateBufferWithProperties thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint context, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<MemProperties> properties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CLEnum flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint size, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T0> host_ptr, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* errcode_ret) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.CreateBufferWithProperties(context, in properties.GetPinnableReference(), flags, size, out host_ptr.GetPinnableReference(), errcode_ret);
        }

        [Obsolete("The \"ungrouped\" enums (INTEL, CLEnum) are deprecated in favour of the \"grouped\" enums (MemProperties, MemFlags). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", true)]
        public static unsafe nint CreateBufferWithProperties<T0>(this IntelCreateBufferWithProperties thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint context, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<MemProperties> properties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CLEnum flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint size, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T0> host_ptr, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<int> errcode_ret) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.CreateBufferWithProperties(context, in properties.GetPinnableReference(), flags, size, out host_ptr.GetPinnableReference(), out errcode_ret.GetPinnableReference());
        }

        [Obsolete("The \"ungrouped\" enums (INTEL, CLEnum) are deprecated in favour of the \"grouped\" enums (MemProperties, MemFlags). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", true)]
        public static unsafe nint CreateBufferWithProperties(this IntelCreateBufferWithProperties thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint context, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CLEnum* properties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] MemFlags flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint size, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* host_ptr, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<int> errcode_ret)
        {
            // SpanOverloader
            return thisApi.CreateBufferWithProperties(context, properties, flags, size, host_ptr, out errcode_ret.GetPinnableReference());
        }

        [Obsolete("The \"ungrouped\" enums (INTEL, CLEnum) are deprecated in favour of the \"grouped\" enums (MemProperties, MemFlags). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", true)]
        public static unsafe nint CreateBufferWithProperties<T0>(this IntelCreateBufferWithProperties thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint context, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CLEnum* properties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] MemFlags flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint size, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T0> host_ptr, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* errcode_ret) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.CreateBufferWithProperties(context, properties, flags, size, out host_ptr.GetPinnableReference(), errcode_ret);
        }

        [Obsolete("The \"ungrouped\" enums (INTEL, CLEnum) are deprecated in favour of the \"grouped\" enums (MemProperties, MemFlags). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", true)]
        public static unsafe nint CreateBufferWithProperties<T0>(this IntelCreateBufferWithProperties thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint context, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CLEnum* properties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] MemFlags flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint size, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T0> host_ptr, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<int> errcode_ret) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.CreateBufferWithProperties(context, properties, flags, size, out host_ptr.GetPinnableReference(), out errcode_ret.GetPinnableReference());
        }

        [Obsolete("The \"ungrouped\" enums (INTEL, CLEnum) are deprecated in favour of the \"grouped\" enums (MemProperties, MemFlags). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", true)]
        public static unsafe nint CreateBufferWithProperties(this IntelCreateBufferWithProperties thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint context, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<CLEnum> properties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] MemFlags flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint size, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* host_ptr, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* errcode_ret)
        {
            // SpanOverloader
            return thisApi.CreateBufferWithProperties(context, in properties.GetPinnableReference(), flags, size, host_ptr, errcode_ret);
        }

        [Obsolete("The \"ungrouped\" enums (INTEL, CLEnum) are deprecated in favour of the \"grouped\" enums (MemProperties, MemFlags). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", true)]
        public static unsafe nint CreateBufferWithProperties(this IntelCreateBufferWithProperties thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint context, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<CLEnum> properties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] MemFlags flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint size, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* host_ptr, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<int> errcode_ret)
        {
            // SpanOverloader
            return thisApi.CreateBufferWithProperties(context, in properties.GetPinnableReference(), flags, size, host_ptr, out errcode_ret.GetPinnableReference());
        }

        [Obsolete("The \"ungrouped\" enums (INTEL, CLEnum) are deprecated in favour of the \"grouped\" enums (MemProperties, MemFlags). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", true)]
        public static unsafe nint CreateBufferWithProperties<T0>(this IntelCreateBufferWithProperties thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint context, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<CLEnum> properties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] MemFlags flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint size, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T0> host_ptr, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* errcode_ret) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.CreateBufferWithProperties(context, in properties.GetPinnableReference(), flags, size, out host_ptr.GetPinnableReference(), errcode_ret);
        }

        [Obsolete("The \"ungrouped\" enums (INTEL, CLEnum) are deprecated in favour of the \"grouped\" enums (MemProperties, MemFlags). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", true)]
        public static unsafe nint CreateBufferWithProperties<T0>(this IntelCreateBufferWithProperties thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint context, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<CLEnum> properties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] MemFlags flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint size, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T0> host_ptr, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<int> errcode_ret) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.CreateBufferWithProperties(context, in properties.GetPinnableReference(), flags, size, out host_ptr.GetPinnableReference(), out errcode_ret.GetPinnableReference());
        }

        [Obsolete("The \"ungrouped\" enums (INTEL, CLEnum) are deprecated in favour of the \"grouped\" enums (MemProperties, MemFlags). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", true)]
        public static unsafe nint CreateBufferWithProperties(this IntelCreateBufferWithProperties thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint context, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CLEnum* properties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CLEnum flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint size, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* host_ptr, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<int> errcode_ret)
        {
            // SpanOverloader
            return thisApi.CreateBufferWithProperties(context, properties, flags, size, host_ptr, out errcode_ret.GetPinnableReference());
        }

        [Obsolete("The \"ungrouped\" enums (INTEL, CLEnum) are deprecated in favour of the \"grouped\" enums (MemProperties, MemFlags). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", true)]
        public static unsafe nint CreateBufferWithProperties<T0>(this IntelCreateBufferWithProperties thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint context, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CLEnum* properties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CLEnum flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint size, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T0> host_ptr, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* errcode_ret) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.CreateBufferWithProperties(context, properties, flags, size, out host_ptr.GetPinnableReference(), errcode_ret);
        }

        [Obsolete("The \"ungrouped\" enums (INTEL, CLEnum) are deprecated in favour of the \"grouped\" enums (MemProperties, MemFlags). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", true)]
        public static unsafe nint CreateBufferWithProperties<T0>(this IntelCreateBufferWithProperties thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint context, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CLEnum* properties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CLEnum flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint size, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T0> host_ptr, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<int> errcode_ret) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.CreateBufferWithProperties(context, properties, flags, size, out host_ptr.GetPinnableReference(), out errcode_ret.GetPinnableReference());
        }

        [Obsolete("The \"ungrouped\" enums (INTEL, CLEnum) are deprecated in favour of the \"grouped\" enums (MemProperties, MemFlags). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", true)]
        public static unsafe nint CreateBufferWithProperties(this IntelCreateBufferWithProperties thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint context, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<CLEnum> properties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CLEnum flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint size, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* host_ptr, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* errcode_ret)
        {
            // SpanOverloader
            return thisApi.CreateBufferWithProperties(context, in properties.GetPinnableReference(), flags, size, host_ptr, errcode_ret);
        }

        [Obsolete("The \"ungrouped\" enums (INTEL, CLEnum) are deprecated in favour of the \"grouped\" enums (MemProperties, MemFlags). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", true)]
        public static unsafe nint CreateBufferWithProperties(this IntelCreateBufferWithProperties thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint context, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<CLEnum> properties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CLEnum flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint size, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* host_ptr, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<int> errcode_ret)
        {
            // SpanOverloader
            return thisApi.CreateBufferWithProperties(context, in properties.GetPinnableReference(), flags, size, host_ptr, out errcode_ret.GetPinnableReference());
        }

        [Obsolete("The \"ungrouped\" enums (INTEL, CLEnum) are deprecated in favour of the \"grouped\" enums (MemProperties, MemFlags). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", true)]
        public static unsafe nint CreateBufferWithProperties<T0>(this IntelCreateBufferWithProperties thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint context, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<CLEnum> properties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CLEnum flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint size, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T0> host_ptr, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* errcode_ret) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.CreateBufferWithProperties(context, in properties.GetPinnableReference(), flags, size, out host_ptr.GetPinnableReference(), errcode_ret);
        }

        [Obsolete("The \"ungrouped\" enums (INTEL, CLEnum) are deprecated in favour of the \"grouped\" enums (MemProperties, MemFlags). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", true)]
        public static unsafe nint CreateBufferWithProperties<T0>(this IntelCreateBufferWithProperties thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint context, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<CLEnum> properties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CLEnum flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint size, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T0> host_ptr, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<int> errcode_ret) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.CreateBufferWithProperties(context, in properties.GetPinnableReference(), flags, size, out host_ptr.GetPinnableReference(), out errcode_ret.GetPinnableReference());
        }

    }
}

