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
        public static unsafe int GetLayerInfo(this LoaderLayers thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] LayerInfo param_name, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint param_value_size, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* param_value, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<nuint> param_value_size_ret)
        {
            // SpanOverloader
            return thisApi.GetLayerInfo(param_name, param_value_size, param_value, out param_value_size_ret.GetPinnableReference());
        }

        public static unsafe int GetLayerInfo<T0>(this LoaderLayers thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] LayerInfo param_name, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint param_value_size, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T0> param_value, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] nuint* param_value_size_ret) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.GetLayerInfo(param_name, param_value_size, out param_value.GetPinnableReference(), param_value_size_ret);
        }

        public static unsafe int GetLayerInfo<T0>(this LoaderLayers thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] LayerInfo param_name, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint param_value_size, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T0> param_value, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<nuint> param_value_size_ret) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.GetLayerInfo(param_name, param_value_size, out param_value.GetPinnableReference(), out param_value_size_ret.GetPinnableReference());
        }

        [Obsolete("The \"ungrouped\" enums (LOADER) are deprecated in favour of the \"grouped\" enums (LayerInfo). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", false)]
        public static unsafe int GetLayerInfo(this LoaderLayers thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint param_name, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint param_value_size, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* param_value, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<nuint> param_value_size_ret)
        {
            // SpanOverloader
            return thisApi.GetLayerInfo(param_name, param_value_size, param_value, out param_value_size_ret.GetPinnableReference());
        }

        [Obsolete("The \"ungrouped\" enums (LOADER) are deprecated in favour of the \"grouped\" enums (LayerInfo). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", false)]
        public static unsafe int GetLayerInfo<T0>(this LoaderLayers thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint param_name, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint param_value_size, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T0> param_value, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] nuint* param_value_size_ret) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.GetLayerInfo(param_name, param_value_size, out param_value.GetPinnableReference(), param_value_size_ret);
        }

        [Obsolete("The \"ungrouped\" enums (LOADER) are deprecated in favour of the \"grouped\" enums (LayerInfo). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", false)]
        public static unsafe int GetLayerInfo<T0>(this LoaderLayers thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint param_name, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint param_value_size, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T0> param_value, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<nuint> param_value_size_ret) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.GetLayerInfo(param_name, param_value_size, out param_value.GetPinnableReference(), out param_value_size_ret.GetPinnableReference());
        }

        public static unsafe int InitLayer(this LoaderLayers thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_entries, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* target_dispatch, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> num_entries_ret, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void** layer_dispatch_ret)
        {
            // SpanOverloader
            return thisApi.InitLayer(num_entries, target_dispatch, out num_entries_ret.GetPinnableReference(), layer_dispatch_ret);
        }

        public static unsafe int InitLayer(this LoaderLayers thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_entries, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* target_dispatch, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> num_entries_ret, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in void* layer_dispatch_ret)
        {
            // SpanOverloader
            return thisApi.InitLayer(num_entries, target_dispatch, out num_entries_ret.GetPinnableReference(), in layer_dispatch_ret);
        }

        public static unsafe int InitLayer<T0>(this LoaderLayers thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_entries, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> target_dispatch, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* num_entries_ret, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void** layer_dispatch_ret) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.InitLayer(num_entries, in target_dispatch.GetPinnableReference(), num_entries_ret, layer_dispatch_ret);
        }

        public static unsafe int InitLayer<T0>(this LoaderLayers thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_entries, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> target_dispatch, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* num_entries_ret, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in void* layer_dispatch_ret) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.InitLayer(num_entries, in target_dispatch.GetPinnableReference(), num_entries_ret, in layer_dispatch_ret);
        }

        public static unsafe int InitLayer<T0>(this LoaderLayers thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_entries, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> target_dispatch, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> num_entries_ret, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void** layer_dispatch_ret) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.InitLayer(num_entries, in target_dispatch.GetPinnableReference(), out num_entries_ret.GetPinnableReference(), layer_dispatch_ret);
        }

        public static unsafe int InitLayer<T0>(this LoaderLayers thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_entries, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> target_dispatch, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> num_entries_ret, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in void* layer_dispatch_ret) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.InitLayer(num_entries, in target_dispatch.GetPinnableReference(), out num_entries_ret.GetPinnableReference(), in layer_dispatch_ret);
        }

    }
}

