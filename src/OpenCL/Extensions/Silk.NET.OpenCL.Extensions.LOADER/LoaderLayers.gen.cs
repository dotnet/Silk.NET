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

        [NativeApi(EntryPoint = "clInitLayer", Convention = CallingConvention.Winapi)]
        public unsafe partial int InitLayer([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_entries, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* target_dispatch, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* num_entries_ret, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void** layer_dispatch_ret);

        public LoaderLayers(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

