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
        public unsafe partial int GetLayerInfo([Flow(FlowDirection.In)] nuint param_value_size, [Flow(FlowDirection.In)] uint param_name, [Flow(FlowDirection.Out)] void* param_value, [Flow(FlowDirection.Out)] nuint* param_value_size_ret);

        [NativeApi(EntryPoint = "clGetLayerInfo", Convention = CallingConvention.Winapi)]
        public unsafe partial int GetLayerInfo([Flow(FlowDirection.In)] nuint param_value_size, [Flow(FlowDirection.In)] uint param_name, [Flow(FlowDirection.Out)] void* param_value, [Flow(FlowDirection.Out)] out nuint param_value_size_ret);

        [NativeApi(EntryPoint = "clGetLayerInfo", Convention = CallingConvention.Winapi)]
        public unsafe partial int GetLayerInfo<T0>([Flow(FlowDirection.In)] nuint param_value_size, [Flow(FlowDirection.In)] uint param_name, [Flow(FlowDirection.Out)] out T0 param_value, [Flow(FlowDirection.Out)] nuint* param_value_size_ret) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clGetLayerInfo", Convention = CallingConvention.Winapi)]
        public partial int GetLayerInfo<T0>([Flow(FlowDirection.In)] nuint param_value_size, [Flow(FlowDirection.In)] uint param_name, [Flow(FlowDirection.Out)] out T0 param_value, [Flow(FlowDirection.Out)] out nuint param_value_size_ret) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clInitLayer", Convention = CallingConvention.Winapi)]
        public unsafe partial int InitLayer([Flow(FlowDirection.In)] uint num_entries, [Flow(FlowDirection.In)] void* target_dispatch, [Flow(FlowDirection.Out)] uint* num_entries_ret, [Flow(FlowDirection.In)] void** layer_dispatch);

        [NativeApi(EntryPoint = "clInitLayer", Convention = CallingConvention.Winapi)]
        public unsafe partial int InitLayer([Flow(FlowDirection.In)] uint num_entries, [Flow(FlowDirection.In)] void* target_dispatch, [Flow(FlowDirection.Out)] uint* num_entries_ret, [Flow(FlowDirection.In)] in void* layer_dispatch);

        [NativeApi(EntryPoint = "clInitLayer", Convention = CallingConvention.Winapi)]
        public unsafe partial int InitLayer([Flow(FlowDirection.In)] uint num_entries, [Flow(FlowDirection.In)] void* target_dispatch, [Flow(FlowDirection.Out)] out uint num_entries_ret, [Flow(FlowDirection.In)] void** layer_dispatch);

        [NativeApi(EntryPoint = "clInitLayer", Convention = CallingConvention.Winapi)]
        public unsafe partial int InitLayer([Flow(FlowDirection.In)] uint num_entries, [Flow(FlowDirection.In)] void* target_dispatch, [Flow(FlowDirection.Out)] out uint num_entries_ret, [Flow(FlowDirection.In)] in void* layer_dispatch);

        [NativeApi(EntryPoint = "clInitLayer", Convention = CallingConvention.Winapi)]
        public unsafe partial int InitLayer<T0>([Flow(FlowDirection.In)] uint num_entries, [Flow(FlowDirection.In)] in T0 target_dispatch, [Flow(FlowDirection.Out)] uint* num_entries_ret, [Flow(FlowDirection.In)] void** layer_dispatch) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clInitLayer", Convention = CallingConvention.Winapi)]
        public unsafe partial int InitLayer<T0>([Flow(FlowDirection.In)] uint num_entries, [Flow(FlowDirection.In)] in T0 target_dispatch, [Flow(FlowDirection.Out)] uint* num_entries_ret, [Flow(FlowDirection.In)] in void* layer_dispatch) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clInitLayer", Convention = CallingConvention.Winapi)]
        public unsafe partial int InitLayer<T0>([Flow(FlowDirection.In)] uint num_entries, [Flow(FlowDirection.In)] in T0 target_dispatch, [Flow(FlowDirection.Out)] out uint num_entries_ret, [Flow(FlowDirection.In)] void** layer_dispatch) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clInitLayer", Convention = CallingConvention.Winapi)]
        public unsafe partial int InitLayer<T0>([Flow(FlowDirection.In)] uint num_entries, [Flow(FlowDirection.In)] in T0 target_dispatch, [Flow(FlowDirection.Out)] out uint num_entries_ret, [Flow(FlowDirection.In)] in void* layer_dispatch) where T0 : unmanaged;

        public LoaderLayers(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

