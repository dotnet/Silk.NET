// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;
using Silk.NET.OpenCL;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;
using Extension = Silk.NET.Core.Attributes.ExtensionAttribute;

#pragma warning disable 1591

namespace Silk.NET.OpenCL.Extensions.EXT
{
    [Extension("EXT_device_fission")]
    public unsafe partial class ExtDeviceFission : NativeExtension<CL>
    {
        public const string ExtensionName = "EXT_device_fission";
        [NativeApi(EntryPoint = "clCreateSubDevicesEXT")]
        public unsafe partial int CreateSubDevices([Flow(FlowDirection.In)] IntPtr in_device, [Flow(FlowDirection.In)] ulong* properties, [Flow(FlowDirection.In)] uint num_entries, [Flow(FlowDirection.Out)] IntPtr* out_devices, [Flow(FlowDirection.Out)] uint* num_devices);

        [NativeApi(EntryPoint = "clCreateSubDevicesEXT")]
        public unsafe partial int CreateSubDevices([Flow(FlowDirection.In)] IntPtr in_device, [Flow(FlowDirection.In)] ulong* properties, [Flow(FlowDirection.In)] uint num_entries, [Flow(FlowDirection.Out)] IntPtr* out_devices, [Flow(FlowDirection.Out)] out uint num_devices);

        [NativeApi(EntryPoint = "clCreateSubDevicesEXT")]
        public unsafe partial int CreateSubDevices([Flow(FlowDirection.In)] IntPtr in_device, [Flow(FlowDirection.In)] ulong* properties, [Flow(FlowDirection.In)] uint num_entries, [Flow(FlowDirection.Out)] out IntPtr out_devices, [Flow(FlowDirection.Out)] uint* num_devices);

        [NativeApi(EntryPoint = "clCreateSubDevicesEXT")]
        public unsafe partial int CreateSubDevices([Flow(FlowDirection.In)] IntPtr in_device, [Flow(FlowDirection.In)] ulong* properties, [Flow(FlowDirection.In)] uint num_entries, [Flow(FlowDirection.Out)] out IntPtr out_devices, [Flow(FlowDirection.Out)] out uint num_devices);

        [NativeApi(EntryPoint = "clCreateSubDevicesEXT")]
        public unsafe partial int CreateSubDevices([Flow(FlowDirection.In)] IntPtr in_device, [Flow(FlowDirection.In)] in ulong properties, [Flow(FlowDirection.In)] uint num_entries, [Flow(FlowDirection.Out)] IntPtr* out_devices, [Flow(FlowDirection.Out)] uint* num_devices);

        [NativeApi(EntryPoint = "clCreateSubDevicesEXT")]
        public unsafe partial int CreateSubDevices([Flow(FlowDirection.In)] IntPtr in_device, [Flow(FlowDirection.In)] in ulong properties, [Flow(FlowDirection.In)] uint num_entries, [Flow(FlowDirection.Out)] IntPtr* out_devices, [Flow(FlowDirection.Out)] out uint num_devices);

        [NativeApi(EntryPoint = "clCreateSubDevicesEXT")]
        public unsafe partial int CreateSubDevices([Flow(FlowDirection.In)] IntPtr in_device, [Flow(FlowDirection.In)] in ulong properties, [Flow(FlowDirection.In)] uint num_entries, [Flow(FlowDirection.Out)] out IntPtr out_devices, [Flow(FlowDirection.Out)] uint* num_devices);

        [NativeApi(EntryPoint = "clCreateSubDevicesEXT")]
        public partial int CreateSubDevices([Flow(FlowDirection.In)] IntPtr in_device, [Flow(FlowDirection.In)] in ulong properties, [Flow(FlowDirection.In)] uint num_entries, [Flow(FlowDirection.Out)] out IntPtr out_devices, [Flow(FlowDirection.Out)] out uint num_devices);

        [NativeApi(EntryPoint = "clReleaseDeviceEXT")]
        public partial int ReleaseDevice([Flow(FlowDirection.In)] IntPtr device);

        [NativeApi(EntryPoint = "clRetainDeviceEXT")]
        public partial int RetainDevice([Flow(FlowDirection.In)] IntPtr device);

        public ExtDeviceFission(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

