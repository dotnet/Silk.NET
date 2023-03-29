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
        public static unsafe nint CreateAccelerator<T0>(this IntelAccelerator thisApi, [Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] AcceleratorType accelerator_type, [Flow(FlowDirection.In)] nuint descriptor_size, [Flow(FlowDirection.In)] Span<T0> descriptor, [Flow(FlowDirection.Out)] Span<int> errcode_ret) where T0 : struct
        {
            // SpanOverloader
            fixed (void* descriptorSpp = descriptor)
                return thisApi.CreateAccelerator(context, accelerator_type, descriptor_size, descriptorSpp, out errcode_ret.GetPinnableReference());
        }

        [Obsolete("The \"ungrouped\" enums (INTEL) are deprecated in favour of the \"grouped\" enums (AcceleratorType). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", false)]
        public static unsafe nint CreateAccelerator<T0>(this IntelAccelerator thisApi, [Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] uint accelerator_type, [Flow(FlowDirection.In)] nuint descriptor_size, [Flow(FlowDirection.In)] Span<T0> descriptor, [Flow(FlowDirection.Out)] int* errcode_ret) where T0 : struct
        {
            // SpanOverloader
            fixed (void* descriptorSpp = descriptor)
                return thisApi.CreateAccelerator(context, accelerator_type, descriptor_size, descriptorSpp, errcode_ret);
        }

        [Obsolete("The \"ungrouped\" enums (INTEL) are deprecated in favour of the \"grouped\" enums (AcceleratorType). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", false)]
        public static unsafe nint CreateAccelerator<T0>(this IntelAccelerator thisApi, [Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] uint accelerator_type, [Flow(FlowDirection.In)] nuint descriptor_size, [Flow(FlowDirection.In)] Span<T0> descriptor, [Flow(FlowDirection.Out)] Span<int> errcode_ret) where T0 : struct
        {
            // SpanOverloader
            fixed (void* descriptorSpp = descriptor)
                return thisApi.CreateAccelerator(context, accelerator_type, descriptor_size, descriptorSpp, out errcode_ret.GetPinnableReference());
        }

        public static unsafe int GetAcceleratorInfo<T0>(this IntelAccelerator thisApi, [Flow(FlowDirection.In)] nint accelerator, [Flow(FlowDirection.In)] AcceleratorInfo param_name, [Flow(FlowDirection.In)] nuint param_value_size, [Flow(FlowDirection.Out)] Span<T0> param_value, [Flow(FlowDirection.Out)] Span<nuint> param_value_size_ret) where T0 : struct
        {
            // SpanOverloader
            fixed (void* param_valueSpp = param_value)
                return thisApi.GetAcceleratorInfo(accelerator, param_name, param_value_size, param_valueSpp, out param_value_size_ret.GetPinnableReference());
        }

        [Obsolete("The \"ungrouped\" enums (INTEL) are deprecated in favour of the \"grouped\" enums (AcceleratorInfo). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", false)]
        public static unsafe int GetAcceleratorInfo<T0>(this IntelAccelerator thisApi, [Flow(FlowDirection.In)] nint accelerator, [Flow(FlowDirection.In)] uint param_name, [Flow(FlowDirection.In)] nuint param_value_size, [Flow(FlowDirection.Out)] Span<T0> param_value, [Flow(FlowDirection.Out)] nuint* param_value_size_ret) where T0 : struct
        {
            // SpanOverloader
            fixed (void* param_valueSpp = param_value)
                return thisApi.GetAcceleratorInfo(accelerator, param_name, param_value_size, param_valueSpp, param_value_size_ret);
        }

        [Obsolete("The \"ungrouped\" enums (INTEL) are deprecated in favour of the \"grouped\" enums (AcceleratorInfo). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", false)]
        public static unsafe int GetAcceleratorInfo<T0>(this IntelAccelerator thisApi, [Flow(FlowDirection.In)] nint accelerator, [Flow(FlowDirection.In)] uint param_name, [Flow(FlowDirection.In)] nuint param_value_size, [Flow(FlowDirection.Out)] Span<T0> param_value, [Flow(FlowDirection.Out)] Span<nuint> param_value_size_ret) where T0 : struct
        {
            // SpanOverloader
            fixed (void* param_valueSpp = param_value)
                return thisApi.GetAcceleratorInfo(accelerator, param_name, param_value_size, param_valueSpp, out param_value_size_ret.GetPinnableReference());
        }

    }
}

