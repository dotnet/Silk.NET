// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.OpenCL.Extensions.KHR
{
    public static class KhrSubgroupsOverloads
    {
        public static unsafe int GetKernelSubGroupInfo(this KhrSubgroups thisApi, [Flow(FlowDirection.In)] IntPtr in_kernel, [Flow(FlowDirection.In)] IntPtr in_device, [Flow(FlowDirection.In)] uint param_name, [Flow(FlowDirection.In)] UIntPtr input_value_size, [Flow(FlowDirection.In)] void* input_value, [Flow(FlowDirection.In)] UIntPtr param_value_size, [Flow(FlowDirection.Out)] void* param_value, [Flow(FlowDirection.Out)] Span<UIntPtr> param_value_size_ret)
        {
            // SpanOverloader
            return thisApi.GetKernelSubGroupInfo(in_kernel, in_device, param_name, input_value_size, input_value, param_value_size, param_value, out param_value_size_ret.GetPinnableReference());
        }

        public static unsafe int GetKernelSubGroupInfo<T0>(this KhrSubgroups thisApi, [Flow(FlowDirection.In)] IntPtr in_kernel, [Flow(FlowDirection.In)] IntPtr in_device, [Flow(FlowDirection.In)] uint param_name, [Flow(FlowDirection.In)] UIntPtr input_value_size, [Flow(FlowDirection.In)] void* input_value, [Flow(FlowDirection.In)] UIntPtr param_value_size, [Flow(FlowDirection.Out)] Span<T0> param_value, [Flow(FlowDirection.Out)] UIntPtr* param_value_size_ret) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.GetKernelSubGroupInfo(in_kernel, in_device, param_name, input_value_size, input_value, param_value_size, out param_value.GetPinnableReference(), param_value_size_ret);
        }

        public static unsafe int GetKernelSubGroupInfo<T0>(this KhrSubgroups thisApi, [Flow(FlowDirection.In)] IntPtr in_kernel, [Flow(FlowDirection.In)] IntPtr in_device, [Flow(FlowDirection.In)] uint param_name, [Flow(FlowDirection.In)] UIntPtr input_value_size, [Flow(FlowDirection.In)] void* input_value, [Flow(FlowDirection.In)] UIntPtr param_value_size, [Flow(FlowDirection.Out)] Span<T0> param_value, [Flow(FlowDirection.Out)] Span<UIntPtr> param_value_size_ret) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.GetKernelSubGroupInfo(in_kernel, in_device, param_name, input_value_size, input_value, param_value_size, out param_value.GetPinnableReference(), out param_value_size_ret.GetPinnableReference());
        }

        public static unsafe int GetKernelSubGroupInfo<T0>(this KhrSubgroups thisApi, [Flow(FlowDirection.In)] IntPtr in_kernel, [Flow(FlowDirection.In)] IntPtr in_device, [Flow(FlowDirection.In)] uint param_name, [Flow(FlowDirection.In)] UIntPtr input_value_size, [Flow(FlowDirection.In)] ReadOnlySpan<T0> input_value, [Flow(FlowDirection.In)] UIntPtr param_value_size, [Flow(FlowDirection.Out)] void* param_value, [Flow(FlowDirection.Out)] UIntPtr* param_value_size_ret) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.GetKernelSubGroupInfo(in_kernel, in_device, param_name, input_value_size, in input_value.GetPinnableReference(), param_value_size, param_value, param_value_size_ret);
        }

        public static unsafe int GetKernelSubGroupInfo<T0>(this KhrSubgroups thisApi, [Flow(FlowDirection.In)] IntPtr in_kernel, [Flow(FlowDirection.In)] IntPtr in_device, [Flow(FlowDirection.In)] uint param_name, [Flow(FlowDirection.In)] UIntPtr input_value_size, [Flow(FlowDirection.In)] ReadOnlySpan<T0> input_value, [Flow(FlowDirection.In)] UIntPtr param_value_size, [Flow(FlowDirection.Out)] void* param_value, [Flow(FlowDirection.Out)] Span<UIntPtr> param_value_size_ret) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.GetKernelSubGroupInfo(in_kernel, in_device, param_name, input_value_size, in input_value.GetPinnableReference(), param_value_size, param_value, out param_value_size_ret.GetPinnableReference());
        }

        public static unsafe int GetKernelSubGroupInfo<T0, T1>(this KhrSubgroups thisApi, [Flow(FlowDirection.In)] IntPtr in_kernel, [Flow(FlowDirection.In)] IntPtr in_device, [Flow(FlowDirection.In)] uint param_name, [Flow(FlowDirection.In)] UIntPtr input_value_size, [Flow(FlowDirection.In)] ReadOnlySpan<T0> input_value, [Flow(FlowDirection.In)] UIntPtr param_value_size, [Flow(FlowDirection.Out)] Span<T1> param_value, [Flow(FlowDirection.Out)] UIntPtr* param_value_size_ret) where T0 : unmanaged where T1 : unmanaged
        {
            // SpanOverloader
            return thisApi.GetKernelSubGroupInfo(in_kernel, in_device, param_name, input_value_size, in input_value.GetPinnableReference(), param_value_size, out param_value.GetPinnableReference(), param_value_size_ret);
        }

        public static unsafe int GetKernelSubGroupInfo<T0, T1>(this KhrSubgroups thisApi, [Flow(FlowDirection.In)] IntPtr in_kernel, [Flow(FlowDirection.In)] IntPtr in_device, [Flow(FlowDirection.In)] uint param_name, [Flow(FlowDirection.In)] UIntPtr input_value_size, [Flow(FlowDirection.In)] ReadOnlySpan<T0> input_value, [Flow(FlowDirection.In)] UIntPtr param_value_size, [Flow(FlowDirection.Out)] Span<T1> param_value, [Flow(FlowDirection.Out)] Span<UIntPtr> param_value_size_ret) where T0 : unmanaged where T1 : unmanaged
        {
            // SpanOverloader
            return thisApi.GetKernelSubGroupInfo(in_kernel, in_device, param_name, input_value_size, in input_value.GetPinnableReference(), param_value_size, out param_value.GetPinnableReference(), out param_value_size_ret.GetPinnableReference());
        }

    }
}

