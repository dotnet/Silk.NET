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

namespace Silk.NET.OpenCL.Extensions.LOADER
{
    [Extension("LOADER_layers")]
    public unsafe partial class LoaderLayers : NativeExtension<CL>
    {
        public const string ExtensionName = "LOADER_layers";
        [NativeApi(EntryPoint = "clGetLayerInfo", Convention = CallingConvention.Winapi)]
        public unsafe partial int GetLayerInfo([Flow(Silk.NET.Core.Native.FlowDirection.In)] LayerInfo param_name, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint param_value_size, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* param_value, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] nuint* param_value_size_ret);

        [NativeApi(EntryPoint = "clGetLayerInfo", Convention = CallingConvention.Winapi)]
        public unsafe partial int GetLayerInfo([Flow(Silk.NET.Core.Native.FlowDirection.In)] LayerInfo param_name, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint param_value_size, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* param_value, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out nuint param_value_size_ret);

        [NativeApi(EntryPoint = "clGetLayerInfo", Convention = CallingConvention.Winapi)]
        public unsafe partial int GetLayerInfo<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] LayerInfo param_name, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint param_value_size, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T0 param_value, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] nuint* param_value_size_ret) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clGetLayerInfo", Convention = CallingConvention.Winapi)]
        public partial int GetLayerInfo<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] LayerInfo param_name, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint param_value_size, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T0 param_value, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out nuint param_value_size_ret) where T0 : unmanaged;

        [Obsolete("The \"ungrouped\" enums (LOADER) are deprecated in favour of the \"grouped\" enums (LayerInfo). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", false)]
        [NativeApi(EntryPoint = "clGetLayerInfo", Convention = CallingConvention.Winapi)]
        public unsafe partial int GetLayerInfo([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint param_name, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint param_value_size, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* param_value, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] nuint* param_value_size_ret);

        [Obsolete("The \"ungrouped\" enums (LOADER) are deprecated in favour of the \"grouped\" enums (LayerInfo). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", false)]
        [NativeApi(EntryPoint = "clGetLayerInfo", Convention = CallingConvention.Winapi)]
        public unsafe partial int GetLayerInfo([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint param_name, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint param_value_size, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* param_value, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out nuint param_value_size_ret);

        [Obsolete("The \"ungrouped\" enums (LOADER) are deprecated in favour of the \"grouped\" enums (LayerInfo). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", false)]
        [NativeApi(EntryPoint = "clGetLayerInfo", Convention = CallingConvention.Winapi)]
        public unsafe partial int GetLayerInfo<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint param_name, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint param_value_size, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T0 param_value, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] nuint* param_value_size_ret) where T0 : unmanaged;

        [Obsolete("The \"ungrouped\" enums (LOADER) are deprecated in favour of the \"grouped\" enums (LayerInfo). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", false)]
        [NativeApi(EntryPoint = "clGetLayerInfo", Convention = CallingConvention.Winapi)]
        public partial int GetLayerInfo<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint param_name, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint param_value_size, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T0 param_value, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out nuint param_value_size_ret) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clInitLayer", Convention = CallingConvention.Winapi)]
        public unsafe partial int InitLayer([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_entries, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* target_dispatch, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* num_entries_ret, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void** layer_dispatch_ret);

        [NativeApi(EntryPoint = "clInitLayer", Convention = CallingConvention.Winapi)]
        public unsafe partial int InitLayer([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_entries, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* target_dispatch, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* num_entries_ret, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in void* layer_dispatch_ret);

        [NativeApi(EntryPoint = "clInitLayer", Convention = CallingConvention.Winapi)]
        public unsafe partial int InitLayer([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_entries, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* target_dispatch, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out uint num_entries_ret, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void** layer_dispatch_ret);

        [NativeApi(EntryPoint = "clInitLayer", Convention = CallingConvention.Winapi)]
        public unsafe partial int InitLayer([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_entries, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* target_dispatch, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out uint num_entries_ret, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in void* layer_dispatch_ret);

        [NativeApi(EntryPoint = "clInitLayer", Convention = CallingConvention.Winapi)]
        public unsafe partial int InitLayer<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_entries, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 target_dispatch, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* num_entries_ret, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void** layer_dispatch_ret) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clInitLayer", Convention = CallingConvention.Winapi)]
        public unsafe partial int InitLayer<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_entries, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 target_dispatch, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* num_entries_ret, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in void* layer_dispatch_ret) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clInitLayer", Convention = CallingConvention.Winapi)]
        public unsafe partial int InitLayer<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_entries, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 target_dispatch, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out uint num_entries_ret, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void** layer_dispatch_ret) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clInitLayer", Convention = CallingConvention.Winapi)]
        public unsafe partial int InitLayer<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_entries, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 target_dispatch, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out uint num_entries_ret, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in void* layer_dispatch_ret) where T0 : unmanaged;

        public LoaderLayers(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

