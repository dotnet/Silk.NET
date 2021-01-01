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

namespace Silk.NET.OpenCL.Extensions.INTEL
{
    public static class IntelAcceleratorOverloads
    {
        public static unsafe nint CreateAccelerator(this IntelAccelerator thisApi, [Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] uint accelerator_type, [Flow(FlowDirection.In)] nuint descriptor_size, [Flow(FlowDirection.In)] void* descriptor, [Flow(FlowDirection.Out)] Span<int> errcode_ret)
        {
            // SpanOverloader
            return thisApi.CreateAccelerator(context, accelerator_type, descriptor_size, descriptor, out errcode_ret.GetPinnableReference());
        }

        public static unsafe nint CreateAccelerator<T0>(this IntelAccelerator thisApi, [Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] uint accelerator_type, [Flow(FlowDirection.In)] nuint descriptor_size, [Flow(FlowDirection.In)] ReadOnlySpan<T0> descriptor, [Flow(FlowDirection.Out)] int* errcode_ret) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.CreateAccelerator(context, accelerator_type, descriptor_size, in descriptor.GetPinnableReference(), errcode_ret);
        }

        public static unsafe nint CreateAccelerator<T0>(this IntelAccelerator thisApi, [Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] uint accelerator_type, [Flow(FlowDirection.In)] nuint descriptor_size, [Flow(FlowDirection.In)] ReadOnlySpan<T0> descriptor, [Flow(FlowDirection.Out)] Span<int> errcode_ret) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.CreateAccelerator(context, accelerator_type, descriptor_size, in descriptor.GetPinnableReference(), out errcode_ret.GetPinnableReference());
        }

        public static unsafe int GetAcceleratorInfo(this IntelAccelerator thisApi, [Flow(FlowDirection.In)] nint accelerator, [Flow(FlowDirection.In)] uint param_name, [Flow(FlowDirection.In)] nuint param_value_size, [Flow(FlowDirection.Out)] void* param_value, [Flow(FlowDirection.Out)] Span<nuint> param_value_size_ret)
        {
            // SpanOverloader
            return thisApi.GetAcceleratorInfo(accelerator, param_name, param_value_size, param_value, out param_value_size_ret.GetPinnableReference());
        }

        public static unsafe int GetAcceleratorInfo<T0>(this IntelAccelerator thisApi, [Flow(FlowDirection.In)] nint accelerator, [Flow(FlowDirection.In)] uint param_name, [Flow(FlowDirection.In)] nuint param_value_size, [Flow(FlowDirection.Out)] Span<T0> param_value, [Flow(FlowDirection.Out)] nuint* param_value_size_ret) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.GetAcceleratorInfo(accelerator, param_name, param_value_size, out param_value.GetPinnableReference(), param_value_size_ret);
        }

        public static unsafe int GetAcceleratorInfo<T0>(this IntelAccelerator thisApi, [Flow(FlowDirection.In)] nint accelerator, [Flow(FlowDirection.In)] uint param_name, [Flow(FlowDirection.In)] nuint param_value_size, [Flow(FlowDirection.Out)] Span<T0> param_value, [Flow(FlowDirection.Out)] Span<nuint> param_value_size_ret) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.GetAcceleratorInfo(accelerator, param_name, param_value_size, out param_value.GetPinnableReference(), out param_value_size_ret.GetPinnableReference());
        }

    }
}

