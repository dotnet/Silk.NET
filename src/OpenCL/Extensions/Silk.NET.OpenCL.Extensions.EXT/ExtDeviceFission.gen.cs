// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.OpenCL;
using Silk.NET.Core.Loader;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Ultz.SuperInvoke;

namespace Silk.NET.OpenCL.Extensions.EXT
{
    [Extension("EXT_device_fission")]
    public abstract unsafe partial class ExtDeviceFission : NativeExtension<CL>
    {
        /// <inheritdoc />
        [NativeApi(EntryPoint = "clCreateSubDevicesEXT")]
        public abstract unsafe int CreateSubDevices([Flow(FlowDirection.In)] IntPtr in_device, [Flow(FlowDirection.In)] ulong* properties, [Flow(FlowDirection.In)] uint num_entries, [Flow(FlowDirection.Out)] IntPtr* out_devices, [Flow(FlowDirection.Out)] uint* num_devices);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "clCreateSubDevicesEXT")]
        public abstract int CreateSubDevices([Flow(FlowDirection.In)] IntPtr in_device, [Flow(FlowDirection.In)] Span<ulong> properties, [Flow(FlowDirection.In)] uint num_entries, [Flow(FlowDirection.Out)] Span<IntPtr> out_devices, [Flow(FlowDirection.Out)] Span<uint> num_devices);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "clReleaseDeviceEXT")]
        public abstract int ReleaseDevice([Flow(FlowDirection.In)] IntPtr device);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "clRetainDeviceEXT")]
        public abstract int RetainDevice([Flow(FlowDirection.In)] IntPtr device);

        public unsafe int CreateSubDevices([Flow(FlowDirection.In)] int in_device, [Flow(FlowDirection.In)] ulong* properties, [Flow(FlowDirection.In)] uint num_entries, [Flow(FlowDirection.Out)] IntPtr* out_devices, [Flow(FlowDirection.Out)] uint* num_devices)
        {
            // IntPtrOverloader
            return CreateSubDevices(new IntPtr(in_device), properties, num_entries, out_devices, num_devices);
        }

        public unsafe int CreateSubDevices([Flow(FlowDirection.In)] int in_device, [Flow(FlowDirection.In)] Span<ulong> properties, [Flow(FlowDirection.In)] uint num_entries, [Flow(FlowDirection.Out)] Span<IntPtr> out_devices, [Flow(FlowDirection.Out)] Span<uint> num_devices)
        {
            // IntPtrOverloader
            return CreateSubDevices(new IntPtr(in_device), properties, num_entries, out_devices, num_devices);
        }

        public unsafe int ReleaseDevice([Flow(FlowDirection.In)] int device)
        {
            // IntPtrOverloader
            return ReleaseDevice(new IntPtr(device));
        }

        public unsafe int RetainDevice([Flow(FlowDirection.In)] int device)
        {
            // IntPtrOverloader
            return RetainDevice(new IntPtr(device));
        }

        public ExtDeviceFission(ref NativeApiContext ctx)
            : base(ref ctx)
        {
        }
    }
}

