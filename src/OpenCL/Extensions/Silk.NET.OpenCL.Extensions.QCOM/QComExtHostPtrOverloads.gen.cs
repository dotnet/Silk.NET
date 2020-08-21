// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.OpenCL.Extensions.QCOM
{
    public static class QComExtHostPtrOverloads
    {
        public static unsafe int GetDeviceImageInfo(this QComExtHostPtr thisApi, [Flow(FlowDirection.In)] IntPtr device, [Flow(FlowDirection.In)] UIntPtr image_width, [Flow(FlowDirection.In)] UIntPtr image_height, [Flow(FlowDirection.In)] uint* image_format, [Flow(FlowDirection.In)] uint param_name, [Flow(FlowDirection.In)] UIntPtr param_value_size, [Flow(FlowDirection.Out)] void* param_value, [Flow(FlowDirection.Out)] Span<UIntPtr> param_value_size_ret)
        {
            // SpanOverloader
            return thisApi.GetDeviceImageInfo(device, image_width, image_height, image_format, param_name, param_value_size, param_value, out param_value_size_ret.GetPinnableReference());
        }

        public static unsafe int GetDeviceImageInfo<T0>(this QComExtHostPtr thisApi, [Flow(FlowDirection.In)] IntPtr device, [Flow(FlowDirection.In)] UIntPtr image_width, [Flow(FlowDirection.In)] UIntPtr image_height, [Flow(FlowDirection.In)] uint* image_format, [Flow(FlowDirection.In)] uint param_name, [Flow(FlowDirection.In)] UIntPtr param_value_size, [Flow(FlowDirection.Out)] Span<T0> param_value, [Flow(FlowDirection.Out)] UIntPtr* param_value_size_ret) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.GetDeviceImageInfo(device, image_width, image_height, image_format, param_name, param_value_size, out param_value.GetPinnableReference(), param_value_size_ret);
        }

        public static unsafe int GetDeviceImageInfo<T0>(this QComExtHostPtr thisApi, [Flow(FlowDirection.In)] IntPtr device, [Flow(FlowDirection.In)] UIntPtr image_width, [Flow(FlowDirection.In)] UIntPtr image_height, [Flow(FlowDirection.In)] uint* image_format, [Flow(FlowDirection.In)] uint param_name, [Flow(FlowDirection.In)] UIntPtr param_value_size, [Flow(FlowDirection.Out)] Span<T0> param_value, [Flow(FlowDirection.Out)] Span<UIntPtr> param_value_size_ret) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.GetDeviceImageInfo(device, image_width, image_height, image_format, param_name, param_value_size, out param_value.GetPinnableReference(), out param_value_size_ret.GetPinnableReference());
        }

        public static unsafe int GetDeviceImageInfo(this QComExtHostPtr thisApi, [Flow(FlowDirection.In)] IntPtr device, [Flow(FlowDirection.In)] UIntPtr image_width, [Flow(FlowDirection.In)] UIntPtr image_height, [Flow(FlowDirection.In)] ReadOnlySpan<uint> image_format, [Flow(FlowDirection.In)] uint param_name, [Flow(FlowDirection.In)] UIntPtr param_value_size, [Flow(FlowDirection.Out)] void* param_value, [Flow(FlowDirection.Out)] UIntPtr* param_value_size_ret)
        {
            // SpanOverloader
            return thisApi.GetDeviceImageInfo(device, image_width, image_height, in image_format.GetPinnableReference(), param_name, param_value_size, param_value, param_value_size_ret);
        }

        public static unsafe int GetDeviceImageInfo(this QComExtHostPtr thisApi, [Flow(FlowDirection.In)] IntPtr device, [Flow(FlowDirection.In)] UIntPtr image_width, [Flow(FlowDirection.In)] UIntPtr image_height, [Flow(FlowDirection.In)] ReadOnlySpan<uint> image_format, [Flow(FlowDirection.In)] uint param_name, [Flow(FlowDirection.In)] UIntPtr param_value_size, [Flow(FlowDirection.Out)] void* param_value, [Flow(FlowDirection.Out)] Span<UIntPtr> param_value_size_ret)
        {
            // SpanOverloader
            return thisApi.GetDeviceImageInfo(device, image_width, image_height, in image_format.GetPinnableReference(), param_name, param_value_size, param_value, out param_value_size_ret.GetPinnableReference());
        }

        public static unsafe int GetDeviceImageInfo<T0>(this QComExtHostPtr thisApi, [Flow(FlowDirection.In)] IntPtr device, [Flow(FlowDirection.In)] UIntPtr image_width, [Flow(FlowDirection.In)] UIntPtr image_height, [Flow(FlowDirection.In)] ReadOnlySpan<uint> image_format, [Flow(FlowDirection.In)] uint param_name, [Flow(FlowDirection.In)] UIntPtr param_value_size, [Flow(FlowDirection.Out)] Span<T0> param_value, [Flow(FlowDirection.Out)] UIntPtr* param_value_size_ret) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.GetDeviceImageInfo(device, image_width, image_height, in image_format.GetPinnableReference(), param_name, param_value_size, out param_value.GetPinnableReference(), param_value_size_ret);
        }

        public static unsafe int GetDeviceImageInfo<T0>(this QComExtHostPtr thisApi, [Flow(FlowDirection.In)] IntPtr device, [Flow(FlowDirection.In)] UIntPtr image_width, [Flow(FlowDirection.In)] UIntPtr image_height, [Flow(FlowDirection.In)] ReadOnlySpan<uint> image_format, [Flow(FlowDirection.In)] uint param_name, [Flow(FlowDirection.In)] UIntPtr param_value_size, [Flow(FlowDirection.Out)] Span<T0> param_value, [Flow(FlowDirection.Out)] Span<UIntPtr> param_value_size_ret) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.GetDeviceImageInfo(device, image_width, image_height, in image_format.GetPinnableReference(), param_name, param_value_size, out param_value.GetPinnableReference(), out param_value_size_ret.GetPinnableReference());
        }

    }
}

