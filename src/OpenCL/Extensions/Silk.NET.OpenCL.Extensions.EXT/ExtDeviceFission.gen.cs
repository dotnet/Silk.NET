// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.OpenCL;
using Silk.NET.Core.Native;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.OpenCL.Extensions.EXT
{
    [Extension("EXT_device_fission")]
    public unsafe partial class ExtDeviceFission : NativeExtension<CL>
    {
        public const string ExtensionName = "EXT_device_fission";
        [NativeApi(EntryPoint = "clCreateSubDevicesEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe int CreateSubDevices([Flow(FlowDirection.In)] IntPtr in_device, [Flow(FlowDirection.In)] ulong* properties, [Flow(FlowDirection.In)] uint num_entries, [Flow(FlowDirection.Out)] IntPtr* out_devices, [Flow(FlowDirection.Out)] uint* num_devices)
            => ImplCreateSubDevices(in_device, properties, num_entries, out_devices, num_devices);

        [NativeApi(EntryPoint = "clCreateSubDevicesEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public int CreateSubDevices([Flow(FlowDirection.In)] IntPtr in_device, [Flow(FlowDirection.In)] Span<ulong> properties, [Flow(FlowDirection.In)] uint num_entries, [Flow(FlowDirection.Out)] Span<IntPtr> out_devices, [Flow(FlowDirection.Out)] Span<uint> num_devices)
            => ImplCreateSubDevices(in_device, properties, num_entries, out_devices, num_devices);

        [NativeApi(EntryPoint = "clReleaseDeviceEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public int ReleaseDevice([Flow(FlowDirection.In)] IntPtr device)
            => ImplReleaseDevice(device);

        [NativeApi(EntryPoint = "clRetainDeviceEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public int RetainDevice([Flow(FlowDirection.In)] IntPtr device)
            => ImplRetainDevice(device);

        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe int CreateSubDevices([Flow(FlowDirection.In)] int in_device, [Flow(FlowDirection.In)] ulong* properties, [Flow(FlowDirection.In)] uint num_entries, [Flow(FlowDirection.Out)] IntPtr* out_devices, [Flow(FlowDirection.Out)] uint* num_devices)
        {
            // IntPtrOverloader
            return CreateSubDevices(new IntPtr(in_device), properties, num_entries, out_devices, num_devices);
        }

        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe int CreateSubDevices([Flow(FlowDirection.In)] int in_device, [Flow(FlowDirection.In)] Span<ulong> properties, [Flow(FlowDirection.In)] uint num_entries, [Flow(FlowDirection.Out)] Span<IntPtr> out_devices, [Flow(FlowDirection.Out)] Span<uint> num_devices)
        {
            // IntPtrOverloader
            return CreateSubDevices(new IntPtr(in_device), properties, num_entries, out_devices, num_devices);
        }

        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe int ReleaseDevice([Flow(FlowDirection.In)] int device)
        {
            // IntPtrOverloader
            return ReleaseDevice(new IntPtr(device));
        }

        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe int RetainDevice([Flow(FlowDirection.In)] int device)
        {
            // IntPtrOverloader
            return RetainDevice(new IntPtr(device));
        }

        public ExtDeviceFission(INativeContext ctx)
            : base(ctx)
        {
            InitializeNative();
        }
    }
}

