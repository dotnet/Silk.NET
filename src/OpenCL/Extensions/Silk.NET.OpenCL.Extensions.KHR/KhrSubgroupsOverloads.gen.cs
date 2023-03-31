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
    public static class KhrSubgroupsOverloads
    {
        public static unsafe int GetKernelSubGroupInfo(this KhrSubgroups thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint in_kernel, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint in_device, [Flow(Silk.NET.Core.Native.FlowDirection.In)] KernelSubGroupInfo param_name, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint input_value_size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* input_value, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint param_value_size, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* param_value, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<nuint> param_value_size_ret)
        {
            // SpanOverloader
            return thisApi.GetKernelSubGroupInfo(in_kernel, in_device, param_name, input_value_size, input_value, param_value_size, param_value, out param_value_size_ret.GetPinnableReference());
        }

        public static unsafe int GetKernelSubGroupInfo<T0>(this KhrSubgroups thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint in_kernel, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint in_device, [Flow(Silk.NET.Core.Native.FlowDirection.In)] KernelSubGroupInfo param_name, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint input_value_size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* input_value, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint param_value_size, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T0> param_value, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] nuint* param_value_size_ret) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.GetKernelSubGroupInfo(in_kernel, in_device, param_name, input_value_size, input_value, param_value_size, out param_value.GetPinnableReference(), param_value_size_ret);
        }

        public static unsafe int GetKernelSubGroupInfo<T0>(this KhrSubgroups thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint in_kernel, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint in_device, [Flow(Silk.NET.Core.Native.FlowDirection.In)] KernelSubGroupInfo param_name, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint input_value_size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* input_value, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint param_value_size, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T0> param_value, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<nuint> param_value_size_ret) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.GetKernelSubGroupInfo(in_kernel, in_device, param_name, input_value_size, input_value, param_value_size, out param_value.GetPinnableReference(), out param_value_size_ret.GetPinnableReference());
        }

        public static unsafe int GetKernelSubGroupInfo<T0>(this KhrSubgroups thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint in_kernel, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint in_device, [Flow(Silk.NET.Core.Native.FlowDirection.In)] KernelSubGroupInfo param_name, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint input_value_size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> input_value, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint param_value_size, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* param_value, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] nuint* param_value_size_ret) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.GetKernelSubGroupInfo(in_kernel, in_device, param_name, input_value_size, in input_value.GetPinnableReference(), param_value_size, param_value, param_value_size_ret);
        }

        public static unsafe int GetKernelSubGroupInfo<T0>(this KhrSubgroups thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint in_kernel, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint in_device, [Flow(Silk.NET.Core.Native.FlowDirection.In)] KernelSubGroupInfo param_name, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint input_value_size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> input_value, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint param_value_size, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* param_value, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<nuint> param_value_size_ret) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.GetKernelSubGroupInfo(in_kernel, in_device, param_name, input_value_size, in input_value.GetPinnableReference(), param_value_size, param_value, out param_value_size_ret.GetPinnableReference());
        }

        public static unsafe int GetKernelSubGroupInfo<T0, T1>(this KhrSubgroups thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint in_kernel, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint in_device, [Flow(Silk.NET.Core.Native.FlowDirection.In)] KernelSubGroupInfo param_name, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint input_value_size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> input_value, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint param_value_size, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T1> param_value, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] nuint* param_value_size_ret) where T0 : unmanaged where T1 : unmanaged
        {
            // SpanOverloader
            return thisApi.GetKernelSubGroupInfo(in_kernel, in_device, param_name, input_value_size, in input_value.GetPinnableReference(), param_value_size, out param_value.GetPinnableReference(), param_value_size_ret);
        }

        public static unsafe int GetKernelSubGroupInfo<T0, T1>(this KhrSubgroups thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint in_kernel, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint in_device, [Flow(Silk.NET.Core.Native.FlowDirection.In)] KernelSubGroupInfo param_name, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint input_value_size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> input_value, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint param_value_size, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T1> param_value, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<nuint> param_value_size_ret) where T0 : unmanaged where T1 : unmanaged
        {
            // SpanOverloader
            return thisApi.GetKernelSubGroupInfo(in_kernel, in_device, param_name, input_value_size, in input_value.GetPinnableReference(), param_value_size, out param_value.GetPinnableReference(), out param_value_size_ret.GetPinnableReference());
        }

        [Obsolete("The \"ungrouped\" enums (CLEnum) are deprecated in favour of the \"grouped\" enums (KernelSubGroupInfo). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", false)]
        public static unsafe int GetKernelSubGroupInfo(this KhrSubgroups thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint in_kernel, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint in_device, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint param_name, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint input_value_size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* input_value, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint param_value_size, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* param_value, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<nuint> param_value_size_ret)
        {
            // SpanOverloader
            return thisApi.GetKernelSubGroupInfo(in_kernel, in_device, param_name, input_value_size, input_value, param_value_size, param_value, out param_value_size_ret.GetPinnableReference());
        }

        [Obsolete("The \"ungrouped\" enums (CLEnum) are deprecated in favour of the \"grouped\" enums (KernelSubGroupInfo). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", false)]
        public static unsafe int GetKernelSubGroupInfo<T0>(this KhrSubgroups thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint in_kernel, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint in_device, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint param_name, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint input_value_size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* input_value, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint param_value_size, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T0> param_value, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] nuint* param_value_size_ret) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.GetKernelSubGroupInfo(in_kernel, in_device, param_name, input_value_size, input_value, param_value_size, out param_value.GetPinnableReference(), param_value_size_ret);
        }

        [Obsolete("The \"ungrouped\" enums (CLEnum) are deprecated in favour of the \"grouped\" enums (KernelSubGroupInfo). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", false)]
        public static unsafe int GetKernelSubGroupInfo<T0>(this KhrSubgroups thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint in_kernel, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint in_device, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint param_name, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint input_value_size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* input_value, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint param_value_size, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T0> param_value, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<nuint> param_value_size_ret) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.GetKernelSubGroupInfo(in_kernel, in_device, param_name, input_value_size, input_value, param_value_size, out param_value.GetPinnableReference(), out param_value_size_ret.GetPinnableReference());
        }

        [Obsolete("The \"ungrouped\" enums (CLEnum) are deprecated in favour of the \"grouped\" enums (KernelSubGroupInfo). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", false)]
        public static unsafe int GetKernelSubGroupInfo<T0>(this KhrSubgroups thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint in_kernel, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint in_device, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint param_name, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint input_value_size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> input_value, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint param_value_size, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* param_value, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] nuint* param_value_size_ret) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.GetKernelSubGroupInfo(in_kernel, in_device, param_name, input_value_size, in input_value.GetPinnableReference(), param_value_size, param_value, param_value_size_ret);
        }

        [Obsolete("The \"ungrouped\" enums (CLEnum) are deprecated in favour of the \"grouped\" enums (KernelSubGroupInfo). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", false)]
        public static unsafe int GetKernelSubGroupInfo<T0>(this KhrSubgroups thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint in_kernel, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint in_device, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint param_name, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint input_value_size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> input_value, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint param_value_size, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* param_value, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<nuint> param_value_size_ret) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.GetKernelSubGroupInfo(in_kernel, in_device, param_name, input_value_size, in input_value.GetPinnableReference(), param_value_size, param_value, out param_value_size_ret.GetPinnableReference());
        }

        [Obsolete("The \"ungrouped\" enums (CLEnum) are deprecated in favour of the \"grouped\" enums (KernelSubGroupInfo). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", false)]
        public static unsafe int GetKernelSubGroupInfo<T0, T1>(this KhrSubgroups thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint in_kernel, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint in_device, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint param_name, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint input_value_size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> input_value, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint param_value_size, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T1> param_value, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] nuint* param_value_size_ret) where T0 : unmanaged where T1 : unmanaged
        {
            // SpanOverloader
            return thisApi.GetKernelSubGroupInfo(in_kernel, in_device, param_name, input_value_size, in input_value.GetPinnableReference(), param_value_size, out param_value.GetPinnableReference(), param_value_size_ret);
        }

        [Obsolete("The \"ungrouped\" enums (CLEnum) are deprecated in favour of the \"grouped\" enums (KernelSubGroupInfo). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", false)]
        public static unsafe int GetKernelSubGroupInfo<T0, T1>(this KhrSubgroups thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint in_kernel, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint in_device, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint param_name, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint input_value_size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> input_value, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint param_value_size, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T1> param_value, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<nuint> param_value_size_ret) where T0 : unmanaged where T1 : unmanaged
        {
            // SpanOverloader
            return thisApi.GetKernelSubGroupInfo(in_kernel, in_device, param_name, input_value_size, in input_value.GetPinnableReference(), param_value_size, out param_value.GetPinnableReference(), out param_value_size_ret.GetPinnableReference());
        }

    }
}

