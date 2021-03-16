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
        public static unsafe int GetKernelSubGroupInfo(this KhrSubgroups thisApi, [Flow(FlowDirection.In)] nint in_kernel, [Flow(FlowDirection.In)] nint in_device, [Flow(FlowDirection.In)] uint param_name, [Flow(FlowDirection.In)] nuint input_value_size, [Flow(FlowDirection.In)] void* input_value, [Flow(FlowDirection.In)] nuint param_value_size, [Flow(FlowDirection.Out)] void* param_value, [Flow(FlowDirection.Out)] Span<nuint> param_value_size_ret)
        {
            // SpanOverloader
            return thisApi.GetKernelSubGroupInfo(in_kernel, in_device, param_name, input_value_size, input_value, param_value_size, param_value, out param_value_size_ret.GetPinnableReference());
        }

        public static unsafe int GetKernelSubGroupInfo<T0>(this KhrSubgroups thisApi, [Flow(FlowDirection.In)] nint in_kernel, [Flow(FlowDirection.In)] nint in_device, [Flow(FlowDirection.In)] uint param_name, [Flow(FlowDirection.In)] nuint input_value_size, [Flow(FlowDirection.In)] void* input_value, [Flow(FlowDirection.In)] nuint param_value_size, [Flow(FlowDirection.Out)] Span<T0> param_value, [Flow(FlowDirection.Out)] nuint* param_value_size_ret) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.GetKernelSubGroupInfo(in_kernel, in_device, param_name, input_value_size, input_value, param_value_size, out param_value.GetPinnableReference(), param_value_size_ret);
        }

        public static unsafe int GetKernelSubGroupInfo<T0>(this KhrSubgroups thisApi, [Flow(FlowDirection.In)] nint in_kernel, [Flow(FlowDirection.In)] nint in_device, [Flow(FlowDirection.In)] uint param_name, [Flow(FlowDirection.In)] nuint input_value_size, [Flow(FlowDirection.In)] void* input_value, [Flow(FlowDirection.In)] nuint param_value_size, [Flow(FlowDirection.Out)] Span<T0> param_value, [Flow(FlowDirection.Out)] Span<nuint> param_value_size_ret) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.GetKernelSubGroupInfo(in_kernel, in_device, param_name, input_value_size, input_value, param_value_size, out param_value.GetPinnableReference(), out param_value_size_ret.GetPinnableReference());
        }

        public static unsafe int GetKernelSubGroupInfo<T0>(this KhrSubgroups thisApi, [Flow(FlowDirection.In)] nint in_kernel, [Flow(FlowDirection.In)] nint in_device, [Flow(FlowDirection.In)] uint param_name, [Flow(FlowDirection.In)] nuint input_value_size, [Flow(FlowDirection.In)] ReadOnlySpan<T0> input_value, [Flow(FlowDirection.In)] nuint param_value_size, [Flow(FlowDirection.Out)] void* param_value, [Flow(FlowDirection.Out)] nuint* param_value_size_ret) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.GetKernelSubGroupInfo(in_kernel, in_device, param_name, input_value_size, in input_value.GetPinnableReference(), param_value_size, param_value, param_value_size_ret);
        }

        public static unsafe int GetKernelSubGroupInfo<T0>(this KhrSubgroups thisApi, [Flow(FlowDirection.In)] nint in_kernel, [Flow(FlowDirection.In)] nint in_device, [Flow(FlowDirection.In)] uint param_name, [Flow(FlowDirection.In)] nuint input_value_size, [Flow(FlowDirection.In)] ReadOnlySpan<T0> input_value, [Flow(FlowDirection.In)] nuint param_value_size, [Flow(FlowDirection.Out)] void* param_value, [Flow(FlowDirection.Out)] Span<nuint> param_value_size_ret) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.GetKernelSubGroupInfo(in_kernel, in_device, param_name, input_value_size, in input_value.GetPinnableReference(), param_value_size, param_value, out param_value_size_ret.GetPinnableReference());
        }

        public static unsafe int GetKernelSubGroupInfo<T0, T1>(this KhrSubgroups thisApi, [Flow(FlowDirection.In)] nint in_kernel, [Flow(FlowDirection.In)] nint in_device, [Flow(FlowDirection.In)] uint param_name, [Flow(FlowDirection.In)] nuint input_value_size, [Flow(FlowDirection.In)] ReadOnlySpan<T0> input_value, [Flow(FlowDirection.In)] nuint param_value_size, [Flow(FlowDirection.Out)] Span<T1> param_value, [Flow(FlowDirection.Out)] nuint* param_value_size_ret) where T0 : unmanaged where T1 : unmanaged
        {
            // SpanOverloader
            return thisApi.GetKernelSubGroupInfo(in_kernel, in_device, param_name, input_value_size, in input_value.GetPinnableReference(), param_value_size, out param_value.GetPinnableReference(), param_value_size_ret);
        }

        public static unsafe int GetKernelSubGroupInfo<T0, T1>(this KhrSubgroups thisApi, [Flow(FlowDirection.In)] nint in_kernel, [Flow(FlowDirection.In)] nint in_device, [Flow(FlowDirection.In)] uint param_name, [Flow(FlowDirection.In)] nuint input_value_size, [Flow(FlowDirection.In)] ReadOnlySpan<T0> input_value, [Flow(FlowDirection.In)] nuint param_value_size, [Flow(FlowDirection.Out)] Span<T1> param_value, [Flow(FlowDirection.Out)] Span<nuint> param_value_size_ret) where T0 : unmanaged where T1 : unmanaged
        {
            // SpanOverloader
            return thisApi.GetKernelSubGroupInfo(in_kernel, in_device, param_name, input_value_size, in input_value.GetPinnableReference(), param_value_size, out param_value.GetPinnableReference(), out param_value_size_ret.GetPinnableReference());
        }

    }
}

