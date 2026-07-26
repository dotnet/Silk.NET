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
    public static class KhrUnifiedSvmOverloads
    {
        public static unsafe int GetSvmpointerInfo(this KhrUnifiedSvm thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint context, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint device, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* ptr, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SvmPointerInfo param_name, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint param_value_size, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* param_value, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<nuint> param_value_size_ret)
        {
            // SpanOverloader
            return thisApi.GetSvmpointerInfo(context, device, ptr, param_name, param_value_size, param_value, out param_value_size_ret.GetPinnableReference());
        }

        public static unsafe int GetSvmpointerInfo<T0>(this KhrUnifiedSvm thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint context, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint device, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* ptr, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SvmPointerInfo param_name, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint param_value_size, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T0> param_value, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] nuint* param_value_size_ret) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.GetSvmpointerInfo(context, device, ptr, param_name, param_value_size, out param_value.GetPinnableReference(), param_value_size_ret);
        }

        public static unsafe int GetSvmpointerInfo<T0>(this KhrUnifiedSvm thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint context, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint device, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* ptr, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SvmPointerInfo param_name, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint param_value_size, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T0> param_value, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<nuint> param_value_size_ret) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.GetSvmpointerInfo(context, device, ptr, param_name, param_value_size, out param_value.GetPinnableReference(), out param_value_size_ret.GetPinnableReference());
        }

        public static unsafe int GetSvmpointerInfo<T0>(this KhrUnifiedSvm thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint context, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint device, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> ptr, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SvmPointerInfo param_name, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint param_value_size, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* param_value, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] nuint* param_value_size_ret) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.GetSvmpointerInfo(context, device, in ptr.GetPinnableReference(), param_name, param_value_size, param_value, param_value_size_ret);
        }

        public static unsafe int GetSvmpointerInfo<T0>(this KhrUnifiedSvm thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint context, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint device, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> ptr, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SvmPointerInfo param_name, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint param_value_size, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* param_value, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<nuint> param_value_size_ret) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.GetSvmpointerInfo(context, device, in ptr.GetPinnableReference(), param_name, param_value_size, param_value, out param_value_size_ret.GetPinnableReference());
        }

        public static unsafe int GetSvmpointerInfo<T0, T1>(this KhrUnifiedSvm thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint context, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint device, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> ptr, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SvmPointerInfo param_name, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint param_value_size, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T1> param_value, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] nuint* param_value_size_ret) where T0 : unmanaged where T1 : unmanaged
        {
            // SpanOverloader
            return thisApi.GetSvmpointerInfo(context, device, in ptr.GetPinnableReference(), param_name, param_value_size, out param_value.GetPinnableReference(), param_value_size_ret);
        }

        public static unsafe int GetSvmpointerInfo<T0, T1>(this KhrUnifiedSvm thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint context, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint device, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> ptr, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SvmPointerInfo param_name, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint param_value_size, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T1> param_value, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<nuint> param_value_size_ret) where T0 : unmanaged where T1 : unmanaged
        {
            // SpanOverloader
            return thisApi.GetSvmpointerInfo(context, device, in ptr.GetPinnableReference(), param_name, param_value_size, out param_value.GetPinnableReference(), out param_value_size_ret.GetPinnableReference());
        }

        [Obsolete("The \"ungrouped\" enums (KHR) are deprecated in favour of the \"grouped\" enums (SvmPointerInfo). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", false)]
        public static unsafe int GetSvmpointerInfo(this KhrUnifiedSvm thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint context, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint device, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* ptr, [Flow(Silk.NET.Core.Native.FlowDirection.In)] KHR param_name, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint param_value_size, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* param_value, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<nuint> param_value_size_ret)
        {
            // SpanOverloader
            return thisApi.GetSvmpointerInfo(context, device, ptr, param_name, param_value_size, param_value, out param_value_size_ret.GetPinnableReference());
        }

        [Obsolete("The \"ungrouped\" enums (KHR) are deprecated in favour of the \"grouped\" enums (SvmPointerInfo). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", false)]
        public static unsafe int GetSvmpointerInfo<T0>(this KhrUnifiedSvm thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint context, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint device, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* ptr, [Flow(Silk.NET.Core.Native.FlowDirection.In)] KHR param_name, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint param_value_size, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T0> param_value, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] nuint* param_value_size_ret) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.GetSvmpointerInfo(context, device, ptr, param_name, param_value_size, out param_value.GetPinnableReference(), param_value_size_ret);
        }

        [Obsolete("The \"ungrouped\" enums (KHR) are deprecated in favour of the \"grouped\" enums (SvmPointerInfo). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", false)]
        public static unsafe int GetSvmpointerInfo<T0>(this KhrUnifiedSvm thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint context, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint device, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* ptr, [Flow(Silk.NET.Core.Native.FlowDirection.In)] KHR param_name, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint param_value_size, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T0> param_value, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<nuint> param_value_size_ret) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.GetSvmpointerInfo(context, device, ptr, param_name, param_value_size, out param_value.GetPinnableReference(), out param_value_size_ret.GetPinnableReference());
        }

        [Obsolete("The \"ungrouped\" enums (KHR) are deprecated in favour of the \"grouped\" enums (SvmPointerInfo). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", false)]
        public static unsafe int GetSvmpointerInfo<T0>(this KhrUnifiedSvm thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint context, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint device, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> ptr, [Flow(Silk.NET.Core.Native.FlowDirection.In)] KHR param_name, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint param_value_size, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* param_value, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] nuint* param_value_size_ret) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.GetSvmpointerInfo(context, device, in ptr.GetPinnableReference(), param_name, param_value_size, param_value, param_value_size_ret);
        }

        [Obsolete("The \"ungrouped\" enums (KHR) are deprecated in favour of the \"grouped\" enums (SvmPointerInfo). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", false)]
        public static unsafe int GetSvmpointerInfo<T0>(this KhrUnifiedSvm thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint context, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint device, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> ptr, [Flow(Silk.NET.Core.Native.FlowDirection.In)] KHR param_name, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint param_value_size, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* param_value, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<nuint> param_value_size_ret) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.GetSvmpointerInfo(context, device, in ptr.GetPinnableReference(), param_name, param_value_size, param_value, out param_value_size_ret.GetPinnableReference());
        }

        [Obsolete("The \"ungrouped\" enums (KHR) are deprecated in favour of the \"grouped\" enums (SvmPointerInfo). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", false)]
        public static unsafe int GetSvmpointerInfo<T0, T1>(this KhrUnifiedSvm thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint context, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint device, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> ptr, [Flow(Silk.NET.Core.Native.FlowDirection.In)] KHR param_name, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint param_value_size, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T1> param_value, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] nuint* param_value_size_ret) where T0 : unmanaged where T1 : unmanaged
        {
            // SpanOverloader
            return thisApi.GetSvmpointerInfo(context, device, in ptr.GetPinnableReference(), param_name, param_value_size, out param_value.GetPinnableReference(), param_value_size_ret);
        }

        [Obsolete("The \"ungrouped\" enums (KHR) are deprecated in favour of the \"grouped\" enums (SvmPointerInfo). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", false)]
        public static unsafe int GetSvmpointerInfo<T0, T1>(this KhrUnifiedSvm thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint context, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint device, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> ptr, [Flow(Silk.NET.Core.Native.FlowDirection.In)] KHR param_name, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint param_value_size, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T1> param_value, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<nuint> param_value_size_ret) where T0 : unmanaged where T1 : unmanaged
        {
            // SpanOverloader
            return thisApi.GetSvmpointerInfo(context, device, in ptr.GetPinnableReference(), param_name, param_value_size, out param_value.GetPinnableReference(), out param_value_size_ret.GetPinnableReference());
        }

        public static unsafe int GetSvmsuggestedTypeIndex(this KhrUnifiedSvm thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint context, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SvmCapabilities required_capabilities, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SvmCapabilities desired_capabilities, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SvmAllocProperties* properties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint size, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> suggested_svm_type_index)
        {
            // SpanOverloader
            return thisApi.GetSvmsuggestedTypeIndex(context, required_capabilities, desired_capabilities, properties, size, out suggested_svm_type_index.GetPinnableReference());
        }

        public static unsafe int GetSvmsuggestedTypeIndex(this KhrUnifiedSvm thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint context, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SvmCapabilities required_capabilities, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SvmCapabilities desired_capabilities, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<SvmAllocProperties> properties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint size, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* suggested_svm_type_index)
        {
            // SpanOverloader
            return thisApi.GetSvmsuggestedTypeIndex(context, required_capabilities, desired_capabilities, in properties.GetPinnableReference(), size, suggested_svm_type_index);
        }

        public static unsafe int GetSvmsuggestedTypeIndex(this KhrUnifiedSvm thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint context, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SvmCapabilities required_capabilities, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SvmCapabilities desired_capabilities, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<SvmAllocProperties> properties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint size, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> suggested_svm_type_index)
        {
            // SpanOverloader
            return thisApi.GetSvmsuggestedTypeIndex(context, required_capabilities, desired_capabilities, in properties.GetPinnableReference(), size, out suggested_svm_type_index.GetPinnableReference());
        }

        [Obsolete("The \"ungrouped\" enums (KHR) are deprecated in favour of the \"grouped\" enums (SvmCapabilities, SvmAllocProperties). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", true)]
        public static unsafe int GetSvmsuggestedTypeIndex(this KhrUnifiedSvm thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint context, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SvmCapabilities required_capabilities, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SvmCapabilities desired_capabilities, [Flow(Silk.NET.Core.Native.FlowDirection.In)] KHR* properties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint size, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> suggested_svm_type_index)
        {
            // SpanOverloader
            return thisApi.GetSvmsuggestedTypeIndex(context, required_capabilities, desired_capabilities, properties, size, out suggested_svm_type_index.GetPinnableReference());
        }

        [Obsolete("The \"ungrouped\" enums (KHR) are deprecated in favour of the \"grouped\" enums (SvmCapabilities, SvmAllocProperties). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", true)]
        public static unsafe int GetSvmsuggestedTypeIndex(this KhrUnifiedSvm thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint context, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SvmCapabilities required_capabilities, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SvmCapabilities desired_capabilities, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<KHR> properties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint size, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* suggested_svm_type_index)
        {
            // SpanOverloader
            return thisApi.GetSvmsuggestedTypeIndex(context, required_capabilities, desired_capabilities, in properties.GetPinnableReference(), size, suggested_svm_type_index);
        }

        [Obsolete("The \"ungrouped\" enums (KHR) are deprecated in favour of the \"grouped\" enums (SvmCapabilities, SvmAllocProperties). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", true)]
        public static unsafe int GetSvmsuggestedTypeIndex(this KhrUnifiedSvm thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint context, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SvmCapabilities required_capabilities, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SvmCapabilities desired_capabilities, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<KHR> properties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint size, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> suggested_svm_type_index)
        {
            // SpanOverloader
            return thisApi.GetSvmsuggestedTypeIndex(context, required_capabilities, desired_capabilities, in properties.GetPinnableReference(), size, out suggested_svm_type_index.GetPinnableReference());
        }

        [Obsolete("The \"ungrouped\" enums (KHR) are deprecated in favour of the \"grouped\" enums (SvmCapabilities, SvmAllocProperties). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", true)]
        public static unsafe int GetSvmsuggestedTypeIndex(this KhrUnifiedSvm thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint context, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SvmCapabilities required_capabilities, [Flow(Silk.NET.Core.Native.FlowDirection.In)] KHR desired_capabilities, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SvmAllocProperties* properties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint size, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> suggested_svm_type_index)
        {
            // SpanOverloader
            return thisApi.GetSvmsuggestedTypeIndex(context, required_capabilities, desired_capabilities, properties, size, out suggested_svm_type_index.GetPinnableReference());
        }

        [Obsolete("The \"ungrouped\" enums (KHR) are deprecated in favour of the \"grouped\" enums (SvmCapabilities, SvmAllocProperties). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", true)]
        public static unsafe int GetSvmsuggestedTypeIndex(this KhrUnifiedSvm thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint context, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SvmCapabilities required_capabilities, [Flow(Silk.NET.Core.Native.FlowDirection.In)] KHR desired_capabilities, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<SvmAllocProperties> properties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint size, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* suggested_svm_type_index)
        {
            // SpanOverloader
            return thisApi.GetSvmsuggestedTypeIndex(context, required_capabilities, desired_capabilities, in properties.GetPinnableReference(), size, suggested_svm_type_index);
        }

        [Obsolete("The \"ungrouped\" enums (KHR) are deprecated in favour of the \"grouped\" enums (SvmCapabilities, SvmAllocProperties). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", true)]
        public static unsafe int GetSvmsuggestedTypeIndex(this KhrUnifiedSvm thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint context, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SvmCapabilities required_capabilities, [Flow(Silk.NET.Core.Native.FlowDirection.In)] KHR desired_capabilities, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<SvmAllocProperties> properties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint size, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> suggested_svm_type_index)
        {
            // SpanOverloader
            return thisApi.GetSvmsuggestedTypeIndex(context, required_capabilities, desired_capabilities, in properties.GetPinnableReference(), size, out suggested_svm_type_index.GetPinnableReference());
        }

        [Obsolete("The \"ungrouped\" enums (KHR) are deprecated in favour of the \"grouped\" enums (SvmCapabilities, SvmAllocProperties). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", true)]
        public static unsafe int GetSvmsuggestedTypeIndex(this KhrUnifiedSvm thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint context, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SvmCapabilities required_capabilities, [Flow(Silk.NET.Core.Native.FlowDirection.In)] KHR desired_capabilities, [Flow(Silk.NET.Core.Native.FlowDirection.In)] KHR* properties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint size, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> suggested_svm_type_index)
        {
            // SpanOverloader
            return thisApi.GetSvmsuggestedTypeIndex(context, required_capabilities, desired_capabilities, properties, size, out suggested_svm_type_index.GetPinnableReference());
        }

        [Obsolete("The \"ungrouped\" enums (KHR) are deprecated in favour of the \"grouped\" enums (SvmCapabilities, SvmAllocProperties). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", true)]
        public static unsafe int GetSvmsuggestedTypeIndex(this KhrUnifiedSvm thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint context, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SvmCapabilities required_capabilities, [Flow(Silk.NET.Core.Native.FlowDirection.In)] KHR desired_capabilities, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<KHR> properties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint size, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* suggested_svm_type_index)
        {
            // SpanOverloader
            return thisApi.GetSvmsuggestedTypeIndex(context, required_capabilities, desired_capabilities, in properties.GetPinnableReference(), size, suggested_svm_type_index);
        }

        [Obsolete("The \"ungrouped\" enums (KHR) are deprecated in favour of the \"grouped\" enums (SvmCapabilities, SvmAllocProperties). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", true)]
        public static unsafe int GetSvmsuggestedTypeIndex(this KhrUnifiedSvm thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint context, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SvmCapabilities required_capabilities, [Flow(Silk.NET.Core.Native.FlowDirection.In)] KHR desired_capabilities, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<KHR> properties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint size, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> suggested_svm_type_index)
        {
            // SpanOverloader
            return thisApi.GetSvmsuggestedTypeIndex(context, required_capabilities, desired_capabilities, in properties.GetPinnableReference(), size, out suggested_svm_type_index.GetPinnableReference());
        }

        [Obsolete("The \"ungrouped\" enums (KHR) are deprecated in favour of the \"grouped\" enums (SvmCapabilities, SvmAllocProperties). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", true)]
        public static unsafe int GetSvmsuggestedTypeIndex(this KhrUnifiedSvm thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint context, [Flow(Silk.NET.Core.Native.FlowDirection.In)] KHR required_capabilities, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SvmCapabilities desired_capabilities, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SvmAllocProperties* properties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint size, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> suggested_svm_type_index)
        {
            // SpanOverloader
            return thisApi.GetSvmsuggestedTypeIndex(context, required_capabilities, desired_capabilities, properties, size, out suggested_svm_type_index.GetPinnableReference());
        }

        [Obsolete("The \"ungrouped\" enums (KHR) are deprecated in favour of the \"grouped\" enums (SvmCapabilities, SvmAllocProperties). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", true)]
        public static unsafe int GetSvmsuggestedTypeIndex(this KhrUnifiedSvm thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint context, [Flow(Silk.NET.Core.Native.FlowDirection.In)] KHR required_capabilities, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SvmCapabilities desired_capabilities, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<SvmAllocProperties> properties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint size, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* suggested_svm_type_index)
        {
            // SpanOverloader
            return thisApi.GetSvmsuggestedTypeIndex(context, required_capabilities, desired_capabilities, in properties.GetPinnableReference(), size, suggested_svm_type_index);
        }

        [Obsolete("The \"ungrouped\" enums (KHR) are deprecated in favour of the \"grouped\" enums (SvmCapabilities, SvmAllocProperties). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", true)]
        public static unsafe int GetSvmsuggestedTypeIndex(this KhrUnifiedSvm thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint context, [Flow(Silk.NET.Core.Native.FlowDirection.In)] KHR required_capabilities, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SvmCapabilities desired_capabilities, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<SvmAllocProperties> properties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint size, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> suggested_svm_type_index)
        {
            // SpanOverloader
            return thisApi.GetSvmsuggestedTypeIndex(context, required_capabilities, desired_capabilities, in properties.GetPinnableReference(), size, out suggested_svm_type_index.GetPinnableReference());
        }

        [Obsolete("The \"ungrouped\" enums (KHR) are deprecated in favour of the \"grouped\" enums (SvmCapabilities, SvmAllocProperties). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", true)]
        public static unsafe int GetSvmsuggestedTypeIndex(this KhrUnifiedSvm thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint context, [Flow(Silk.NET.Core.Native.FlowDirection.In)] KHR required_capabilities, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SvmCapabilities desired_capabilities, [Flow(Silk.NET.Core.Native.FlowDirection.In)] KHR* properties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint size, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> suggested_svm_type_index)
        {
            // SpanOverloader
            return thisApi.GetSvmsuggestedTypeIndex(context, required_capabilities, desired_capabilities, properties, size, out suggested_svm_type_index.GetPinnableReference());
        }

        [Obsolete("The \"ungrouped\" enums (KHR) are deprecated in favour of the \"grouped\" enums (SvmCapabilities, SvmAllocProperties). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", true)]
        public static unsafe int GetSvmsuggestedTypeIndex(this KhrUnifiedSvm thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint context, [Flow(Silk.NET.Core.Native.FlowDirection.In)] KHR required_capabilities, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SvmCapabilities desired_capabilities, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<KHR> properties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint size, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* suggested_svm_type_index)
        {
            // SpanOverloader
            return thisApi.GetSvmsuggestedTypeIndex(context, required_capabilities, desired_capabilities, in properties.GetPinnableReference(), size, suggested_svm_type_index);
        }

        [Obsolete("The \"ungrouped\" enums (KHR) are deprecated in favour of the \"grouped\" enums (SvmCapabilities, SvmAllocProperties). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", true)]
        public static unsafe int GetSvmsuggestedTypeIndex(this KhrUnifiedSvm thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint context, [Flow(Silk.NET.Core.Native.FlowDirection.In)] KHR required_capabilities, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SvmCapabilities desired_capabilities, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<KHR> properties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint size, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> suggested_svm_type_index)
        {
            // SpanOverloader
            return thisApi.GetSvmsuggestedTypeIndex(context, required_capabilities, desired_capabilities, in properties.GetPinnableReference(), size, out suggested_svm_type_index.GetPinnableReference());
        }

        [Obsolete("The \"ungrouped\" enums (KHR) are deprecated in favour of the \"grouped\" enums (SvmCapabilities, SvmAllocProperties). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", true)]
        public static unsafe int GetSvmsuggestedTypeIndex(this KhrUnifiedSvm thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint context, [Flow(Silk.NET.Core.Native.FlowDirection.In)] KHR required_capabilities, [Flow(Silk.NET.Core.Native.FlowDirection.In)] KHR desired_capabilities, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SvmAllocProperties* properties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint size, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> suggested_svm_type_index)
        {
            // SpanOverloader
            return thisApi.GetSvmsuggestedTypeIndex(context, required_capabilities, desired_capabilities, properties, size, out suggested_svm_type_index.GetPinnableReference());
        }

        [Obsolete("The \"ungrouped\" enums (KHR) are deprecated in favour of the \"grouped\" enums (SvmCapabilities, SvmAllocProperties). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", true)]
        public static unsafe int GetSvmsuggestedTypeIndex(this KhrUnifiedSvm thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint context, [Flow(Silk.NET.Core.Native.FlowDirection.In)] KHR required_capabilities, [Flow(Silk.NET.Core.Native.FlowDirection.In)] KHR desired_capabilities, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<SvmAllocProperties> properties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint size, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* suggested_svm_type_index)
        {
            // SpanOverloader
            return thisApi.GetSvmsuggestedTypeIndex(context, required_capabilities, desired_capabilities, in properties.GetPinnableReference(), size, suggested_svm_type_index);
        }

        [Obsolete("The \"ungrouped\" enums (KHR) are deprecated in favour of the \"grouped\" enums (SvmCapabilities, SvmAllocProperties). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", true)]
        public static unsafe int GetSvmsuggestedTypeIndex(this KhrUnifiedSvm thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint context, [Flow(Silk.NET.Core.Native.FlowDirection.In)] KHR required_capabilities, [Flow(Silk.NET.Core.Native.FlowDirection.In)] KHR desired_capabilities, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<SvmAllocProperties> properties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint size, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> suggested_svm_type_index)
        {
            // SpanOverloader
            return thisApi.GetSvmsuggestedTypeIndex(context, required_capabilities, desired_capabilities, in properties.GetPinnableReference(), size, out suggested_svm_type_index.GetPinnableReference());
        }

        [Obsolete("The \"ungrouped\" enums (KHR) are deprecated in favour of the \"grouped\" enums (SvmCapabilities, SvmAllocProperties). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", true)]
        public static unsafe int GetSvmsuggestedTypeIndex(this KhrUnifiedSvm thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint context, [Flow(Silk.NET.Core.Native.FlowDirection.In)] KHR required_capabilities, [Flow(Silk.NET.Core.Native.FlowDirection.In)] KHR desired_capabilities, [Flow(Silk.NET.Core.Native.FlowDirection.In)] KHR* properties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint size, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> suggested_svm_type_index)
        {
            // SpanOverloader
            return thisApi.GetSvmsuggestedTypeIndex(context, required_capabilities, desired_capabilities, properties, size, out suggested_svm_type_index.GetPinnableReference());
        }

        [Obsolete("The \"ungrouped\" enums (KHR) are deprecated in favour of the \"grouped\" enums (SvmCapabilities, SvmAllocProperties). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", true)]
        public static unsafe int GetSvmsuggestedTypeIndex(this KhrUnifiedSvm thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint context, [Flow(Silk.NET.Core.Native.FlowDirection.In)] KHR required_capabilities, [Flow(Silk.NET.Core.Native.FlowDirection.In)] KHR desired_capabilities, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<KHR> properties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint size, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* suggested_svm_type_index)
        {
            // SpanOverloader
            return thisApi.GetSvmsuggestedTypeIndex(context, required_capabilities, desired_capabilities, in properties.GetPinnableReference(), size, suggested_svm_type_index);
        }

        [Obsolete("The \"ungrouped\" enums (KHR) are deprecated in favour of the \"grouped\" enums (SvmCapabilities, SvmAllocProperties). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", true)]
        public static unsafe int GetSvmsuggestedTypeIndex(this KhrUnifiedSvm thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint context, [Flow(Silk.NET.Core.Native.FlowDirection.In)] KHR required_capabilities, [Flow(Silk.NET.Core.Native.FlowDirection.In)] KHR desired_capabilities, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<KHR> properties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint size, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> suggested_svm_type_index)
        {
            // SpanOverloader
            return thisApi.GetSvmsuggestedTypeIndex(context, required_capabilities, desired_capabilities, in properties.GetPinnableReference(), size, out suggested_svm_type_index.GetPinnableReference());
        }

        public static unsafe void* SvmallocWithProperties(this KhrUnifiedSvm thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint context, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SvmAllocProperties* properties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint svm_type_index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint size, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<int> errcode_ret)
        {
            // SpanOverloader
            return thisApi.SvmallocWithProperties(context, properties, svm_type_index, size, out errcode_ret.GetPinnableReference());
        }

        public static unsafe void* SvmallocWithProperties(this KhrUnifiedSvm thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint context, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<SvmAllocProperties> properties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint svm_type_index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint size, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* errcode_ret)
        {
            // SpanOverloader
            return thisApi.SvmallocWithProperties(context, in properties.GetPinnableReference(), svm_type_index, size, errcode_ret);
        }

        public static unsafe void* SvmallocWithProperties(this KhrUnifiedSvm thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint context, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<SvmAllocProperties> properties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint svm_type_index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint size, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<int> errcode_ret)
        {
            // SpanOverloader
            return thisApi.SvmallocWithProperties(context, in properties.GetPinnableReference(), svm_type_index, size, out errcode_ret.GetPinnableReference());
        }

        [Obsolete("The \"ungrouped\" enums (KHR) are deprecated in favour of the \"grouped\" enums (SvmAllocProperties). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", true)]
        public static unsafe void* SvmallocWithProperties(this KhrUnifiedSvm thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint context, [Flow(Silk.NET.Core.Native.FlowDirection.In)] KHR* properties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint svm_type_index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint size, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<int> errcode_ret)
        {
            // SpanOverloader
            return thisApi.SvmallocWithProperties(context, properties, svm_type_index, size, out errcode_ret.GetPinnableReference());
        }

        [Obsolete("The \"ungrouped\" enums (KHR) are deprecated in favour of the \"grouped\" enums (SvmAllocProperties). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", true)]
        public static unsafe void* SvmallocWithProperties(this KhrUnifiedSvm thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint context, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<KHR> properties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint svm_type_index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint size, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* errcode_ret)
        {
            // SpanOverloader
            return thisApi.SvmallocWithProperties(context, in properties.GetPinnableReference(), svm_type_index, size, errcode_ret);
        }

        [Obsolete("The \"ungrouped\" enums (KHR) are deprecated in favour of the \"grouped\" enums (SvmAllocProperties). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", true)]
        public static unsafe void* SvmallocWithProperties(this KhrUnifiedSvm thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint context, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<KHR> properties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint svm_type_index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint size, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<int> errcode_ret)
        {
            // SpanOverloader
            return thisApi.SvmallocWithProperties(context, in properties.GetPinnableReference(), svm_type_index, size, out errcode_ret.GetPinnableReference());
        }

        public static unsafe int SvmfreeWithProperties<T0>(this KhrUnifiedSvm thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint context, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SvmFreeProperties* properties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SvmFreeFlags flags, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T0> ptr) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.SvmfreeWithProperties(context, properties, flags, out ptr.GetPinnableReference());
        }

        public static unsafe int SvmfreeWithProperties(this KhrUnifiedSvm thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint context, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<SvmFreeProperties> properties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SvmFreeFlags flags, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* ptr)
        {
            // SpanOverloader
            return thisApi.SvmfreeWithProperties(context, in properties.GetPinnableReference(), flags, ptr);
        }

        public static unsafe int SvmfreeWithProperties<T0>(this KhrUnifiedSvm thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint context, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<SvmFreeProperties> properties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SvmFreeFlags flags, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T0> ptr) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.SvmfreeWithProperties(context, in properties.GetPinnableReference(), flags, out ptr.GetPinnableReference());
        }

        [Obsolete("The \"ungrouped\" enums (KHR) are deprecated in favour of the \"grouped\" enums (SvmFreeProperties, SvmFreeFlags). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", true)]
        public static unsafe int SvmfreeWithProperties<T0>(this KhrUnifiedSvm thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint context, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SvmFreeProperties* properties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] KHR flags, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T0> ptr) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.SvmfreeWithProperties(context, properties, flags, out ptr.GetPinnableReference());
        }

        [Obsolete("The \"ungrouped\" enums (KHR) are deprecated in favour of the \"grouped\" enums (SvmFreeProperties, SvmFreeFlags). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", true)]
        public static unsafe int SvmfreeWithProperties(this KhrUnifiedSvm thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint context, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<SvmFreeProperties> properties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] KHR flags, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* ptr)
        {
            // SpanOverloader
            return thisApi.SvmfreeWithProperties(context, in properties.GetPinnableReference(), flags, ptr);
        }

        [Obsolete("The \"ungrouped\" enums (KHR) are deprecated in favour of the \"grouped\" enums (SvmFreeProperties, SvmFreeFlags). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", true)]
        public static unsafe int SvmfreeWithProperties<T0>(this KhrUnifiedSvm thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint context, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<SvmFreeProperties> properties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] KHR flags, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T0> ptr) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.SvmfreeWithProperties(context, in properties.GetPinnableReference(), flags, out ptr.GetPinnableReference());
        }

        [Obsolete("The \"ungrouped\" enums (KHR) are deprecated in favour of the \"grouped\" enums (SvmFreeProperties, SvmFreeFlags). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", true)]
        public static unsafe int SvmfreeWithProperties<T0>(this KhrUnifiedSvm thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint context, [Flow(Silk.NET.Core.Native.FlowDirection.In)] KHR* properties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SvmFreeFlags flags, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T0> ptr) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.SvmfreeWithProperties(context, properties, flags, out ptr.GetPinnableReference());
        }

        [Obsolete("The \"ungrouped\" enums (KHR) are deprecated in favour of the \"grouped\" enums (SvmFreeProperties, SvmFreeFlags). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", true)]
        public static unsafe int SvmfreeWithProperties(this KhrUnifiedSvm thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint context, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<KHR> properties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SvmFreeFlags flags, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* ptr)
        {
            // SpanOverloader
            return thisApi.SvmfreeWithProperties(context, in properties.GetPinnableReference(), flags, ptr);
        }

        [Obsolete("The \"ungrouped\" enums (KHR) are deprecated in favour of the \"grouped\" enums (SvmFreeProperties, SvmFreeFlags). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", true)]
        public static unsafe int SvmfreeWithProperties<T0>(this KhrUnifiedSvm thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint context, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<KHR> properties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SvmFreeFlags flags, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T0> ptr) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.SvmfreeWithProperties(context, in properties.GetPinnableReference(), flags, out ptr.GetPinnableReference());
        }

        [Obsolete("The \"ungrouped\" enums (KHR) are deprecated in favour of the \"grouped\" enums (SvmFreeProperties, SvmFreeFlags). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", true)]
        public static unsafe int SvmfreeWithProperties<T0>(this KhrUnifiedSvm thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint context, [Flow(Silk.NET.Core.Native.FlowDirection.In)] KHR* properties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] KHR flags, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T0> ptr) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.SvmfreeWithProperties(context, properties, flags, out ptr.GetPinnableReference());
        }

        [Obsolete("The \"ungrouped\" enums (KHR) are deprecated in favour of the \"grouped\" enums (SvmFreeProperties, SvmFreeFlags). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", true)]
        public static unsafe int SvmfreeWithProperties(this KhrUnifiedSvm thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint context, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<KHR> properties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] KHR flags, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* ptr)
        {
            // SpanOverloader
            return thisApi.SvmfreeWithProperties(context, in properties.GetPinnableReference(), flags, ptr);
        }

        [Obsolete("The \"ungrouped\" enums (KHR) are deprecated in favour of the \"grouped\" enums (SvmFreeProperties, SvmFreeFlags). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", true)]
        public static unsafe int SvmfreeWithProperties<T0>(this KhrUnifiedSvm thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint context, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<KHR> properties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] KHR flags, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T0> ptr) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.SvmfreeWithProperties(context, in properties.GetPinnableReference(), flags, out ptr.GetPinnableReference());
        }

    }
}

