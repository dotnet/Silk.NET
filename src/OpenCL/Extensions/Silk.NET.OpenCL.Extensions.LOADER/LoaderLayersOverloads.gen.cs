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

namespace Silk.NET.OpenCL.Extensions.LOADER
{
    public static class LoaderLayersOverloads
    {
        public static unsafe int GetLayerInfo(this LoaderLayers thisApi, [Flow(FlowDirection.In)] nuint param_value_size, [Flow(FlowDirection.In)] cl_layer_info param_name, [Flow(FlowDirection.Out)] void* param_value, [Flow(FlowDirection.Out)] Span<nuint> param_value_size_ret)
        {
            // SpanOverloader
            return thisApi.GetLayerInfo(param_value_size, param_name, param_value, out param_value_size_ret.GetPinnableReference());
        }

        public static unsafe int GetLayerInfo<T0>(this LoaderLayers thisApi, [Flow(FlowDirection.In)] nuint param_value_size, [Flow(FlowDirection.In)] cl_layer_info param_name, [Flow(FlowDirection.Out)] Span<T0> param_value, [Flow(FlowDirection.Out)] nuint* param_value_size_ret) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.GetLayerInfo(param_value_size, param_name, out param_value.GetPinnableReference(), param_value_size_ret);
        }

        public static unsafe int GetLayerInfo<T0>(this LoaderLayers thisApi, [Flow(FlowDirection.In)] nuint param_value_size, [Flow(FlowDirection.In)] cl_layer_info param_name, [Flow(FlowDirection.Out)] Span<T0> param_value, [Flow(FlowDirection.Out)] Span<nuint> param_value_size_ret) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.GetLayerInfo(param_value_size, param_name, out param_value.GetPinnableReference(), out param_value_size_ret.GetPinnableReference());
        }

        public static unsafe int InitLayer(this LoaderLayers thisApi, [Flow(FlowDirection.In)] uint num_entries, [Flow(FlowDirection.In)] cl_icd_dispatch* target_dispatch, [Flow(FlowDirection.Out)] Span<uint> num_entries_ret, [Flow(FlowDirection.In)] cl_icd_dispatch** layer_dispatch)
        {
            // SpanOverloader
            return thisApi.InitLayer(num_entries, target_dispatch, out num_entries_ret.GetPinnableReference(), layer_dispatch);
        }

        public static unsafe int InitLayer(this LoaderLayers thisApi, [Flow(FlowDirection.In)] uint num_entries, [Flow(FlowDirection.In)] cl_icd_dispatch* target_dispatch, [Flow(FlowDirection.Out)] Span<uint> num_entries_ret, [Flow(FlowDirection.In)] in cl_icd_dispatch* layer_dispatch)
        {
            // SpanOverloader
            return thisApi.InitLayer(num_entries, target_dispatch, out num_entries_ret.GetPinnableReference(), in layer_dispatch);
        }

        public static unsafe int InitLayer(this LoaderLayers thisApi, [Flow(FlowDirection.In)] uint num_entries, [Flow(FlowDirection.In)] ReadOnlySpan<cl_icd_dispatch> target_dispatch, [Flow(FlowDirection.Out)] uint* num_entries_ret, [Flow(FlowDirection.In)] cl_icd_dispatch** layer_dispatch)
        {
            // SpanOverloader
            return thisApi.InitLayer(num_entries, in target_dispatch.GetPinnableReference(), num_entries_ret, layer_dispatch);
        }

        public static unsafe int InitLayer(this LoaderLayers thisApi, [Flow(FlowDirection.In)] uint num_entries, [Flow(FlowDirection.In)] ReadOnlySpan<cl_icd_dispatch> target_dispatch, [Flow(FlowDirection.Out)] uint* num_entries_ret, [Flow(FlowDirection.In)] in cl_icd_dispatch* layer_dispatch)
        {
            // SpanOverloader
            return thisApi.InitLayer(num_entries, in target_dispatch.GetPinnableReference(), num_entries_ret, in layer_dispatch);
        }

        public static unsafe int InitLayer(this LoaderLayers thisApi, [Flow(FlowDirection.In)] uint num_entries, [Flow(FlowDirection.In)] ReadOnlySpan<cl_icd_dispatch> target_dispatch, [Flow(FlowDirection.Out)] Span<uint> num_entries_ret, [Flow(FlowDirection.In)] cl_icd_dispatch** layer_dispatch)
        {
            // SpanOverloader
            return thisApi.InitLayer(num_entries, in target_dispatch.GetPinnableReference(), out num_entries_ret.GetPinnableReference(), layer_dispatch);
        }

        public static unsafe int InitLayer(this LoaderLayers thisApi, [Flow(FlowDirection.In)] uint num_entries, [Flow(FlowDirection.In)] ReadOnlySpan<cl_icd_dispatch> target_dispatch, [Flow(FlowDirection.Out)] Span<uint> num_entries_ret, [Flow(FlowDirection.In)] in cl_icd_dispatch* layer_dispatch)
        {
            // SpanOverloader
            return thisApi.InitLayer(num_entries, in target_dispatch.GetPinnableReference(), out num_entries_ret.GetPinnableReference(), in layer_dispatch);
        }

    }
}

