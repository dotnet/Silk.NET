// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.OpenCL;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.OpenCL.Extensions.QCOM
{
    [Extension("QCOM_ext_host_ptr")]
    public unsafe partial class QComExtHostPtr : NativeExtension<CL>
    {
        public const string ExtensionName = "QCOM_ext_host_ptr";
        [NativeApi(EntryPoint = "clGetDeviceImageInfoQCOM")]
        public unsafe partial int GetDeviceImageInfo([Flow(FlowDirection.In)] IntPtr device, [Flow(FlowDirection.In)] UIntPtr image_width, [Flow(FlowDirection.In)] UIntPtr image_height, [Flow(FlowDirection.In)] uint* image_format, [Flow(FlowDirection.In)] uint param_name, [Flow(FlowDirection.In)] UIntPtr param_value_size, [Flow(FlowDirection.Out)] void* param_value, [Flow(FlowDirection.Out)] UIntPtr* param_value_size_ret);

        [NativeApi(EntryPoint = "clGetDeviceImageInfoQCOM")]
        public partial int GetDeviceImageInfo<T0>([Flow(FlowDirection.In)] IntPtr device, [Flow(FlowDirection.In)] UIntPtr image_width, [Flow(FlowDirection.In)] UIntPtr image_height, [Flow(FlowDirection.In)] Span<uint> image_format, [Flow(FlowDirection.In)] uint param_name, [Flow(FlowDirection.In)] UIntPtr param_value_size, [Flow(FlowDirection.Out)] Span<T0> param_value, [Flow(FlowDirection.Out)] Span<UIntPtr> param_value_size_ret) where T0 : unmanaged;

        public unsafe int GetDeviceImageInfo([Flow(FlowDirection.In)] int device, [Flow(FlowDirection.In)] uint image_width, [Flow(FlowDirection.In)] uint image_height, [Flow(FlowDirection.In)] uint* image_format, [Flow(FlowDirection.In)] uint param_name, [Flow(FlowDirection.In)] uint param_value_size, [Flow(FlowDirection.Out)] void* param_value, [Flow(FlowDirection.Out)] UIntPtr* param_value_size_ret)
        {
            // IntPtrOverloader
            return GetDeviceImageInfo(new IntPtr(device), new UIntPtr(image_width), new UIntPtr(image_height), image_format, param_name, new UIntPtr(param_value_size), param_value, param_value_size_ret);
        }

        public unsafe int GetDeviceImageInfo<T0>([Flow(FlowDirection.In)] int device, [Flow(FlowDirection.In)] uint image_width, [Flow(FlowDirection.In)] uint image_height, [Flow(FlowDirection.In)] Span<uint> image_format, [Flow(FlowDirection.In)] uint param_name, [Flow(FlowDirection.In)] uint param_value_size, [Flow(FlowDirection.Out)] Span<T0> param_value, [Flow(FlowDirection.Out)] Span<UIntPtr> param_value_size_ret) where T0 : unmanaged
        {
            // IntPtrOverloader
            return GetDeviceImageInfo(new IntPtr(device), new UIntPtr(image_width), new UIntPtr(image_height), image_format, param_name, new UIntPtr(param_value_size), param_value, param_value_size_ret);
        }

        public QComExtHostPtr(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

