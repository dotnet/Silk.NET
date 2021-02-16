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
using Silk.NET.OpenCL;
using Extension = Silk.NET.Core.Attributes.ExtensionAttribute;

#pragma warning disable 1591

namespace Silk.NET.OpenCL.Extensions.LOADER
{
    [Extension("LOADER_layers")]
    public unsafe partial class LoaderLayers : NativeExtension<CL>
    {
        public const string ExtensionName = "LOADER_layers";
        [NativeApi(EntryPoint = "clGetLayerInfo")]
        public unsafe partial int GetLayerInfo([Flow(FlowDirection.In)] nuint param_value_size, [Flow(FlowDirection.In)] cl_layer_info param_name, [Flow(FlowDirection.Out)] void* param_value, [Flow(FlowDirection.Out)] nuint* param_value_size_ret);

        [NativeApi(EntryPoint = "clGetLayerInfo")]
        public unsafe partial int GetLayerInfo([Flow(FlowDirection.In)] nuint param_value_size, [Flow(FlowDirection.In)] cl_layer_info param_name, [Flow(FlowDirection.Out)] void* param_value, [Flow(FlowDirection.Out)] out nuint param_value_size_ret);

        [NativeApi(EntryPoint = "clGetLayerInfo")]
        public unsafe partial int GetLayerInfo<T0>([Flow(FlowDirection.In)] nuint param_value_size, [Flow(FlowDirection.In)] cl_layer_info param_name, [Flow(FlowDirection.Out)] out T0 param_value, [Flow(FlowDirection.Out)] nuint* param_value_size_ret) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clGetLayerInfo")]
        public partial int GetLayerInfo<T0>([Flow(FlowDirection.In)] nuint param_value_size, [Flow(FlowDirection.In)] cl_layer_info param_name, [Flow(FlowDirection.Out)] out T0 param_value, [Flow(FlowDirection.Out)] out nuint param_value_size_ret) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clInitLayer")]
        public unsafe partial int InitLayer([Flow(FlowDirection.In)] uint num_entries, [Flow(FlowDirection.In)] cl_icd_dispatch* target_dispatch, [Flow(FlowDirection.Out)] uint* num_entries_ret, [Flow(FlowDirection.In)] cl_icd_dispatch** layer_dispatch);

        [NativeApi(EntryPoint = "clInitLayer")]
        public unsafe partial int InitLayer([Flow(FlowDirection.In)] uint num_entries, [Flow(FlowDirection.In)] cl_icd_dispatch* target_dispatch, [Flow(FlowDirection.Out)] uint* num_entries_ret, [Flow(FlowDirection.In)] in cl_icd_dispatch* layer_dispatch);

        [NativeApi(EntryPoint = "clInitLayer")]
        public unsafe partial int InitLayer([Flow(FlowDirection.In)] uint num_entries, [Flow(FlowDirection.In)] cl_icd_dispatch* target_dispatch, [Flow(FlowDirection.Out)] out uint num_entries_ret, [Flow(FlowDirection.In)] cl_icd_dispatch** layer_dispatch);

        [NativeApi(EntryPoint = "clInitLayer")]
        public unsafe partial int InitLayer([Flow(FlowDirection.In)] uint num_entries, [Flow(FlowDirection.In)] cl_icd_dispatch* target_dispatch, [Flow(FlowDirection.Out)] out uint num_entries_ret, [Flow(FlowDirection.In)] in cl_icd_dispatch* layer_dispatch);

        [NativeApi(EntryPoint = "clInitLayer")]
        public unsafe partial int InitLayer([Flow(FlowDirection.In)] uint num_entries, [Flow(FlowDirection.In)] in cl_icd_dispatch target_dispatch, [Flow(FlowDirection.Out)] uint* num_entries_ret, [Flow(FlowDirection.In)] cl_icd_dispatch** layer_dispatch);

        [NativeApi(EntryPoint = "clInitLayer")]
        public unsafe partial int InitLayer([Flow(FlowDirection.In)] uint num_entries, [Flow(FlowDirection.In)] in cl_icd_dispatch target_dispatch, [Flow(FlowDirection.Out)] uint* num_entries_ret, [Flow(FlowDirection.In)] in cl_icd_dispatch* layer_dispatch);

        [NativeApi(EntryPoint = "clInitLayer")]
        public unsafe partial int InitLayer([Flow(FlowDirection.In)] uint num_entries, [Flow(FlowDirection.In)] in cl_icd_dispatch target_dispatch, [Flow(FlowDirection.Out)] out uint num_entries_ret, [Flow(FlowDirection.In)] cl_icd_dispatch** layer_dispatch);

        [NativeApi(EntryPoint = "clInitLayer")]
        public unsafe partial int InitLayer([Flow(FlowDirection.In)] uint num_entries, [Flow(FlowDirection.In)] in cl_icd_dispatch target_dispatch, [Flow(FlowDirection.Out)] out uint num_entries_ret, [Flow(FlowDirection.In)] in cl_icd_dispatch* layer_dispatch);

        public LoaderLayers(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

