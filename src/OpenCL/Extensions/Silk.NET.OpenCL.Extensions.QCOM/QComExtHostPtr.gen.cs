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
        public unsafe partial int GetDeviceImageInfo([Flow(FlowDirection.In)] IntPtr device, [Flow(FlowDirection.In)] UIntPtr image_width, [Flow(FlowDirection.In)] UIntPtr image_height, [Flow(FlowDirection.In)] uint* image_format, [Flow(FlowDirection.In)] uint param_name, [Flow(FlowDirection.In)] UIntPtr param_value_size, [Flow(FlowDirection.Out)] void* param_value, [Flow(FlowDirection.Out)] out UIntPtr param_value_size_ret);

        [NativeApi(EntryPoint = "clGetDeviceImageInfoQCOM")]
        public unsafe partial int GetDeviceImageInfo<T0>([Flow(FlowDirection.In)] IntPtr device, [Flow(FlowDirection.In)] UIntPtr image_width, [Flow(FlowDirection.In)] UIntPtr image_height, [Flow(FlowDirection.In)] uint* image_format, [Flow(FlowDirection.In)] uint param_name, [Flow(FlowDirection.In)] UIntPtr param_value_size, [Flow(FlowDirection.Out)] out T0 param_value, [Flow(FlowDirection.Out)] UIntPtr* param_value_size_ret) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clGetDeviceImageInfoQCOM")]
        public unsafe partial int GetDeviceImageInfo<T0>([Flow(FlowDirection.In)] IntPtr device, [Flow(FlowDirection.In)] UIntPtr image_width, [Flow(FlowDirection.In)] UIntPtr image_height, [Flow(FlowDirection.In)] uint* image_format, [Flow(FlowDirection.In)] uint param_name, [Flow(FlowDirection.In)] UIntPtr param_value_size, [Flow(FlowDirection.Out)] out T0 param_value, [Flow(FlowDirection.Out)] out UIntPtr param_value_size_ret) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clGetDeviceImageInfoQCOM")]
        public unsafe partial int GetDeviceImageInfo([Flow(FlowDirection.In)] IntPtr device, [Flow(FlowDirection.In)] UIntPtr image_width, [Flow(FlowDirection.In)] UIntPtr image_height, [Flow(FlowDirection.In)] in uint image_format, [Flow(FlowDirection.In)] uint param_name, [Flow(FlowDirection.In)] UIntPtr param_value_size, [Flow(FlowDirection.Out)] void* param_value, [Flow(FlowDirection.Out)] UIntPtr* param_value_size_ret);

        [NativeApi(EntryPoint = "clGetDeviceImageInfoQCOM")]
        public unsafe partial int GetDeviceImageInfo([Flow(FlowDirection.In)] IntPtr device, [Flow(FlowDirection.In)] UIntPtr image_width, [Flow(FlowDirection.In)] UIntPtr image_height, [Flow(FlowDirection.In)] in uint image_format, [Flow(FlowDirection.In)] uint param_name, [Flow(FlowDirection.In)] UIntPtr param_value_size, [Flow(FlowDirection.Out)] void* param_value, [Flow(FlowDirection.Out)] out UIntPtr param_value_size_ret);

        [NativeApi(EntryPoint = "clGetDeviceImageInfoQCOM")]
        public unsafe partial int GetDeviceImageInfo<T0>([Flow(FlowDirection.In)] IntPtr device, [Flow(FlowDirection.In)] UIntPtr image_width, [Flow(FlowDirection.In)] UIntPtr image_height, [Flow(FlowDirection.In)] in uint image_format, [Flow(FlowDirection.In)] uint param_name, [Flow(FlowDirection.In)] UIntPtr param_value_size, [Flow(FlowDirection.Out)] out T0 param_value, [Flow(FlowDirection.Out)] UIntPtr* param_value_size_ret) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clGetDeviceImageInfoQCOM")]
        public partial int GetDeviceImageInfo<T0>([Flow(FlowDirection.In)] IntPtr device, [Flow(FlowDirection.In)] UIntPtr image_width, [Flow(FlowDirection.In)] UIntPtr image_height, [Flow(FlowDirection.In)] in uint image_format, [Flow(FlowDirection.In)] uint param_name, [Flow(FlowDirection.In)] UIntPtr param_value_size, [Flow(FlowDirection.Out)] out T0 param_value, [Flow(FlowDirection.Out)] out UIntPtr param_value_size_ret) where T0 : unmanaged;

        public QComExtHostPtr(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

