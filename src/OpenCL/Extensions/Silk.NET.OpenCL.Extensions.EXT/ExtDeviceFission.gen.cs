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

namespace Silk.NET.OpenCL.Extensions.EXT
{
    [Extension("EXT_device_fission")]
    public unsafe partial class ExtDeviceFission : NativeExtension<CL>
    {
        public const string ExtensionName = "EXT_device_fission";
        [NativeApi(EntryPoint = "clCreateSubDevicesEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial int CreateSubDevices([Flow(FlowDirection.In)] nint in_device, [Flow(FlowDirection.In)] ulong* properties, [Flow(FlowDirection.In)] uint num_entries, [Flow(FlowDirection.Out)] nint* out_devices, [Flow(FlowDirection.Out)] uint* num_devices);

        [NativeApi(EntryPoint = "clCreateSubDevicesEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial int CreateSubDevices([Flow(FlowDirection.In)] nint in_device, [Flow(FlowDirection.In)] ulong* properties, [Flow(FlowDirection.In)] uint num_entries, [Flow(FlowDirection.Out)] nint* out_devices, [Flow(FlowDirection.Out)] out uint num_devices);

        [NativeApi(EntryPoint = "clCreateSubDevicesEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial int CreateSubDevices([Flow(FlowDirection.In)] nint in_device, [Flow(FlowDirection.In)] ulong* properties, [Flow(FlowDirection.In)] uint num_entries, [Flow(FlowDirection.Out)] out nint out_devices, [Flow(FlowDirection.Out)] uint* num_devices);

        [NativeApi(EntryPoint = "clCreateSubDevicesEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial int CreateSubDevices([Flow(FlowDirection.In)] nint in_device, [Flow(FlowDirection.In)] ulong* properties, [Flow(FlowDirection.In)] uint num_entries, [Flow(FlowDirection.Out)] out nint out_devices, [Flow(FlowDirection.Out)] out uint num_devices);

        [NativeApi(EntryPoint = "clCreateSubDevicesEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial int CreateSubDevices([Flow(FlowDirection.In)] nint in_device, [Flow(FlowDirection.In)] in ulong properties, [Flow(FlowDirection.In)] uint num_entries, [Flow(FlowDirection.Out)] nint* out_devices, [Flow(FlowDirection.Out)] uint* num_devices);

        [NativeApi(EntryPoint = "clCreateSubDevicesEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial int CreateSubDevices([Flow(FlowDirection.In)] nint in_device, [Flow(FlowDirection.In)] in ulong properties, [Flow(FlowDirection.In)] uint num_entries, [Flow(FlowDirection.Out)] nint* out_devices, [Flow(FlowDirection.Out)] out uint num_devices);

        [NativeApi(EntryPoint = "clCreateSubDevicesEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial int CreateSubDevices([Flow(FlowDirection.In)] nint in_device, [Flow(FlowDirection.In)] in ulong properties, [Flow(FlowDirection.In)] uint num_entries, [Flow(FlowDirection.Out)] out nint out_devices, [Flow(FlowDirection.Out)] uint* num_devices);

        [NativeApi(EntryPoint = "clCreateSubDevicesEXT", Convention = CallingConvention.Winapi)]
        public partial int CreateSubDevices([Flow(FlowDirection.In)] nint in_device, [Flow(FlowDirection.In)] in ulong properties, [Flow(FlowDirection.In)] uint num_entries, [Flow(FlowDirection.Out)] out nint out_devices, [Flow(FlowDirection.Out)] out uint num_devices);

        [NativeApi(EntryPoint = "clReleaseDeviceEXT", Convention = CallingConvention.Winapi)]
        public partial int ReleaseDevice([Flow(FlowDirection.In)] nint device);

        [NativeApi(EntryPoint = "clRetainDeviceEXT", Convention = CallingConvention.Winapi)]
        public partial int RetainDevice([Flow(FlowDirection.In)] nint device);

        public ExtDeviceFission(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

