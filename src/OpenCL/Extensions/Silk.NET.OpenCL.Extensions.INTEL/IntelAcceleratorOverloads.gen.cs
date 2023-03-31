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
    public static class IntelAcceleratorOverloads
    {
        public static unsafe nint CreateAccelerator(this IntelAccelerator thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint context, [Flow(Silk.NET.Core.Native.FlowDirection.In)] AcceleratorType accelerator_type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint descriptor_size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* descriptor, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<int> errcode_ret)
        {
            // SpanOverloader
            return thisApi.CreateAccelerator(context, accelerator_type, descriptor_size, descriptor, out errcode_ret.GetPinnableReference());
        }

        public static unsafe nint CreateAccelerator<T0>(this IntelAccelerator thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint context, [Flow(Silk.NET.Core.Native.FlowDirection.In)] AcceleratorType accelerator_type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint descriptor_size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> descriptor, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* errcode_ret) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.CreateAccelerator(context, accelerator_type, descriptor_size, in descriptor.GetPinnableReference(), errcode_ret);
        }

        public static unsafe nint CreateAccelerator<T0>(this IntelAccelerator thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint context, [Flow(Silk.NET.Core.Native.FlowDirection.In)] AcceleratorType accelerator_type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint descriptor_size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> descriptor, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<int> errcode_ret) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.CreateAccelerator(context, accelerator_type, descriptor_size, in descriptor.GetPinnableReference(), out errcode_ret.GetPinnableReference());
        }

        [Obsolete("The \"ungrouped\" enums (INTEL) are deprecated in favour of the \"grouped\" enums (AcceleratorType). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", false)]
        public static unsafe nint CreateAccelerator(this IntelAccelerator thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint context, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint accelerator_type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint descriptor_size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* descriptor, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<int> errcode_ret)
        {
            // SpanOverloader
            return thisApi.CreateAccelerator(context, accelerator_type, descriptor_size, descriptor, out errcode_ret.GetPinnableReference());
        }

        [Obsolete("The \"ungrouped\" enums (INTEL) are deprecated in favour of the \"grouped\" enums (AcceleratorType). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", false)]
        public static unsafe nint CreateAccelerator<T0>(this IntelAccelerator thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint context, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint accelerator_type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint descriptor_size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> descriptor, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* errcode_ret) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.CreateAccelerator(context, accelerator_type, descriptor_size, in descriptor.GetPinnableReference(), errcode_ret);
        }

        [Obsolete("The \"ungrouped\" enums (INTEL) are deprecated in favour of the \"grouped\" enums (AcceleratorType). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", false)]
        public static unsafe nint CreateAccelerator<T0>(this IntelAccelerator thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint context, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint accelerator_type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint descriptor_size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> descriptor, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<int> errcode_ret) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.CreateAccelerator(context, accelerator_type, descriptor_size, in descriptor.GetPinnableReference(), out errcode_ret.GetPinnableReference());
        }

        public static unsafe int GetAcceleratorInfo(this IntelAccelerator thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint accelerator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] AcceleratorInfo param_name, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint param_value_size, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* param_value, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<nuint> param_value_size_ret)
        {
            // SpanOverloader
            return thisApi.GetAcceleratorInfo(accelerator, param_name, param_value_size, param_value, out param_value_size_ret.GetPinnableReference());
        }

        public static unsafe int GetAcceleratorInfo<T0>(this IntelAccelerator thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint accelerator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] AcceleratorInfo param_name, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint param_value_size, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T0> param_value, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] nuint* param_value_size_ret) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.GetAcceleratorInfo(accelerator, param_name, param_value_size, out param_value.GetPinnableReference(), param_value_size_ret);
        }

        public static unsafe int GetAcceleratorInfo<T0>(this IntelAccelerator thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint accelerator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] AcceleratorInfo param_name, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint param_value_size, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T0> param_value, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<nuint> param_value_size_ret) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.GetAcceleratorInfo(accelerator, param_name, param_value_size, out param_value.GetPinnableReference(), out param_value_size_ret.GetPinnableReference());
        }

        [Obsolete("The \"ungrouped\" enums (INTEL) are deprecated in favour of the \"grouped\" enums (AcceleratorInfo). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", false)]
        public static unsafe int GetAcceleratorInfo(this IntelAccelerator thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint accelerator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint param_name, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint param_value_size, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* param_value, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<nuint> param_value_size_ret)
        {
            // SpanOverloader
            return thisApi.GetAcceleratorInfo(accelerator, param_name, param_value_size, param_value, out param_value_size_ret.GetPinnableReference());
        }

        [Obsolete("The \"ungrouped\" enums (INTEL) are deprecated in favour of the \"grouped\" enums (AcceleratorInfo). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", false)]
        public static unsafe int GetAcceleratorInfo<T0>(this IntelAccelerator thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint accelerator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint param_name, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint param_value_size, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T0> param_value, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] nuint* param_value_size_ret) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.GetAcceleratorInfo(accelerator, param_name, param_value_size, out param_value.GetPinnableReference(), param_value_size_ret);
        }

        [Obsolete("The \"ungrouped\" enums (INTEL) are deprecated in favour of the \"grouped\" enums (AcceleratorInfo). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", false)]
        public static unsafe int GetAcceleratorInfo<T0>(this IntelAccelerator thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint accelerator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint param_name, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint param_value_size, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T0> param_value, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<nuint> param_value_size_ret) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.GetAcceleratorInfo(accelerator, param_name, param_value_size, out param_value.GetPinnableReference(), out param_value_size_ret.GetPinnableReference());
        }

    }
}

