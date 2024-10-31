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
    public static class KhrCommandBufferMutableDispatchOverloads
    {
        public static unsafe int GetMutableCommandInfo(this KhrCommandBufferMutableDispatch thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint command, [Flow(Silk.NET.Core.Native.FlowDirection.In)] MutableCommandInfo param_name, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint param_value_size, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* param_value, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<nuint> param_value_size_ret)
        {
            // SpanOverloader
            return thisApi.GetMutableCommandInfo(command, param_name, param_value_size, param_value, out param_value_size_ret.GetPinnableReference());
        }

        public static unsafe int GetMutableCommandInfo<T0>(this KhrCommandBufferMutableDispatch thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint command, [Flow(Silk.NET.Core.Native.FlowDirection.In)] MutableCommandInfo param_name, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint param_value_size, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T0> param_value, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] nuint* param_value_size_ret) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.GetMutableCommandInfo(command, param_name, param_value_size, out param_value.GetPinnableReference(), param_value_size_ret);
        }

        public static unsafe int GetMutableCommandInfo<T0>(this KhrCommandBufferMutableDispatch thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint command, [Flow(Silk.NET.Core.Native.FlowDirection.In)] MutableCommandInfo param_name, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint param_value_size, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T0> param_value, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<nuint> param_value_size_ret) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.GetMutableCommandInfo(command, param_name, param_value_size, out param_value.GetPinnableReference(), out param_value_size_ret.GetPinnableReference());
        }

        [Obsolete("The \"ungrouped\" enums (KHR) are deprecated in favour of the \"grouped\" enums (MutableCommandInfo). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", false)]
        public static unsafe int GetMutableCommandInfo(this KhrCommandBufferMutableDispatch thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint command, [Flow(Silk.NET.Core.Native.FlowDirection.In)] KHR param_name, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint param_value_size, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* param_value, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<nuint> param_value_size_ret)
        {
            // SpanOverloader
            return thisApi.GetMutableCommandInfo(command, param_name, param_value_size, param_value, out param_value_size_ret.GetPinnableReference());
        }

        [Obsolete("The \"ungrouped\" enums (KHR) are deprecated in favour of the \"grouped\" enums (MutableCommandInfo). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", false)]
        public static unsafe int GetMutableCommandInfo<T0>(this KhrCommandBufferMutableDispatch thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint command, [Flow(Silk.NET.Core.Native.FlowDirection.In)] KHR param_name, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint param_value_size, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T0> param_value, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] nuint* param_value_size_ret) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.GetMutableCommandInfo(command, param_name, param_value_size, out param_value.GetPinnableReference(), param_value_size_ret);
        }

        [Obsolete("The \"ungrouped\" enums (KHR) are deprecated in favour of the \"grouped\" enums (MutableCommandInfo). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", false)]
        public static unsafe int GetMutableCommandInfo<T0>(this KhrCommandBufferMutableDispatch thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint command, [Flow(Silk.NET.Core.Native.FlowDirection.In)] KHR param_name, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint param_value_size, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T0> param_value, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<nuint> param_value_size_ret) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.GetMutableCommandInfo(command, param_name, param_value_size, out param_value.GetPinnableReference(), out param_value_size_ret.GetPinnableReference());
        }

        public static unsafe int UpdateMutableCommands(this KhrCommandBufferMutableDispatch thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint command_buffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_configs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<CommandBufferUpdateType> config_types, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void** configs)
        {
            // SpanOverloader
            return thisApi.UpdateMutableCommands(command_buffer, num_configs, in config_types.GetPinnableReference(), configs);
        }

        public static unsafe int UpdateMutableCommands(this KhrCommandBufferMutableDispatch thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint command_buffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_configs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<CommandBufferUpdateType> config_types, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in void* configs)
        {
            // SpanOverloader
            return thisApi.UpdateMutableCommands(command_buffer, num_configs, in config_types.GetPinnableReference(), in configs);
        }

        [Obsolete("The \"ungrouped\" enums (KHR) are deprecated in favour of the \"grouped\" enums (CommandBufferUpdateType). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", false)]
        public static unsafe int UpdateMutableCommands(this KhrCommandBufferMutableDispatch thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint command_buffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_configs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<KHR> config_types, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void** configs)
        {
            // SpanOverloader
            return thisApi.UpdateMutableCommands(command_buffer, num_configs, in config_types.GetPinnableReference(), configs);
        }

        [Obsolete("The \"ungrouped\" enums (KHR) are deprecated in favour of the \"grouped\" enums (CommandBufferUpdateType). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", false)]
        public static unsafe int UpdateMutableCommands(this KhrCommandBufferMutableDispatch thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint command_buffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_configs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<KHR> config_types, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in void* configs)
        {
            // SpanOverloader
            return thisApi.UpdateMutableCommands(command_buffer, num_configs, in config_types.GetPinnableReference(), in configs);
        }

    }
}

