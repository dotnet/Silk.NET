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
using Silk.NET.OpenCL;
using Extension = Silk.NET.Core.Attributes.ExtensionAttribute;

#pragma warning disable 1591

namespace Silk.NET.OpenCL.Extensions.KHR
{
    [Extension("KHR_command_buffer_mutable_dispatch")]
    public unsafe partial class KhrCommandBufferMutableDispatch : NativeExtension<CL>
    {
        public const string ExtensionName = "KHR_command_buffer_mutable_dispatch";
        [NativeApi(EntryPoint = "clGetMutableCommandInfoKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial int GetMutableCommandInfo([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint command, [Flow(Silk.NET.Core.Native.FlowDirection.In)] MutableCommandInfo param_name, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint param_value_size, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* param_value, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] nuint* param_value_size_ret);

        [NativeApi(EntryPoint = "clGetMutableCommandInfoKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial int GetMutableCommandInfo([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint command, [Flow(Silk.NET.Core.Native.FlowDirection.In)] MutableCommandInfo param_name, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint param_value_size, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* param_value, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out nuint param_value_size_ret);

        [NativeApi(EntryPoint = "clGetMutableCommandInfoKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial int GetMutableCommandInfo<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint command, [Flow(Silk.NET.Core.Native.FlowDirection.In)] MutableCommandInfo param_name, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint param_value_size, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T0 param_value, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] nuint* param_value_size_ret) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clGetMutableCommandInfoKHR", Convention = CallingConvention.Winapi)]
        public partial int GetMutableCommandInfo<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint command, [Flow(Silk.NET.Core.Native.FlowDirection.In)] MutableCommandInfo param_name, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint param_value_size, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T0 param_value, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out nuint param_value_size_ret) where T0 : unmanaged;

        [Obsolete("The \"ungrouped\" enums (KHR) are deprecated in favour of the \"grouped\" enums (MutableCommandInfo). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", false)]
        [NativeApi(EntryPoint = "clGetMutableCommandInfoKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial int GetMutableCommandInfo([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint command, [Flow(Silk.NET.Core.Native.FlowDirection.In)] KHR param_name, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint param_value_size, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* param_value, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] nuint* param_value_size_ret);

        [Obsolete("The \"ungrouped\" enums (KHR) are deprecated in favour of the \"grouped\" enums (MutableCommandInfo). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", false)]
        [NativeApi(EntryPoint = "clGetMutableCommandInfoKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial int GetMutableCommandInfo([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint command, [Flow(Silk.NET.Core.Native.FlowDirection.In)] KHR param_name, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint param_value_size, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* param_value, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out nuint param_value_size_ret);

        [Obsolete("The \"ungrouped\" enums (KHR) are deprecated in favour of the \"grouped\" enums (MutableCommandInfo). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", false)]
        [NativeApi(EntryPoint = "clGetMutableCommandInfoKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial int GetMutableCommandInfo<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint command, [Flow(Silk.NET.Core.Native.FlowDirection.In)] KHR param_name, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint param_value_size, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T0 param_value, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] nuint* param_value_size_ret) where T0 : unmanaged;

        [Obsolete("The \"ungrouped\" enums (KHR) are deprecated in favour of the \"grouped\" enums (MutableCommandInfo). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", false)]
        [NativeApi(EntryPoint = "clGetMutableCommandInfoKHR", Convention = CallingConvention.Winapi)]
        public partial int GetMutableCommandInfo<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint command, [Flow(Silk.NET.Core.Native.FlowDirection.In)] KHR param_name, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint param_value_size, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T0 param_value, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out nuint param_value_size_ret) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clUpdateMutableCommandsKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial int UpdateMutableCommands([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint command_buffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_configs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CommandBufferUpdateType* config_types, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void** configs);

        [NativeApi(EntryPoint = "clUpdateMutableCommandsKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial int UpdateMutableCommands([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint command_buffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_configs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CommandBufferUpdateType* config_types, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in void* configs);

        [NativeApi(EntryPoint = "clUpdateMutableCommandsKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial int UpdateMutableCommands([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint command_buffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_configs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in CommandBufferUpdateType config_types, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void** configs);

        [NativeApi(EntryPoint = "clUpdateMutableCommandsKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial int UpdateMutableCommands([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint command_buffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_configs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in CommandBufferUpdateType config_types, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in void* configs);

        [Obsolete("The \"ungrouped\" enums (KHR) are deprecated in favour of the \"grouped\" enums (CommandBufferUpdateType). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", false)]
        [NativeApi(EntryPoint = "clUpdateMutableCommandsKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial int UpdateMutableCommands([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint command_buffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_configs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] KHR* config_types, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void** configs);

        [Obsolete("The \"ungrouped\" enums (KHR) are deprecated in favour of the \"grouped\" enums (CommandBufferUpdateType). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", false)]
        [NativeApi(EntryPoint = "clUpdateMutableCommandsKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial int UpdateMutableCommands([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint command_buffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_configs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] KHR* config_types, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in void* configs);

        [Obsolete("The \"ungrouped\" enums (KHR) are deprecated in favour of the \"grouped\" enums (CommandBufferUpdateType). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", false)]
        [NativeApi(EntryPoint = "clUpdateMutableCommandsKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial int UpdateMutableCommands([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint command_buffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_configs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in KHR config_types, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void** configs);

        [Obsolete("The \"ungrouped\" enums (KHR) are deprecated in favour of the \"grouped\" enums (CommandBufferUpdateType). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", false)]
        [NativeApi(EntryPoint = "clUpdateMutableCommandsKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial int UpdateMutableCommands([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint command_buffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_configs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in KHR config_types, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in void* configs);

        public KhrCommandBufferMutableDispatch(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

