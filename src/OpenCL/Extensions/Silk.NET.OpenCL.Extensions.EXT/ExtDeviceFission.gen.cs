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
        public unsafe partial int CreateSubDevices([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint in_device, [Flow(Silk.NET.Core.Native.FlowDirection.In)] DevicePartitionProperty* properties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_entries, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] nint* out_devices, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* num_devices);

        [NativeApi(EntryPoint = "clCreateSubDevicesEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial int CreateSubDevices([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint in_device, [Flow(Silk.NET.Core.Native.FlowDirection.In)] DevicePartitionProperty* properties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_entries, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] nint* out_devices, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out uint num_devices);

        [NativeApi(EntryPoint = "clCreateSubDevicesEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial int CreateSubDevices([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint in_device, [Flow(Silk.NET.Core.Native.FlowDirection.In)] DevicePartitionProperty* properties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_entries, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out nint out_devices, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* num_devices);

        [NativeApi(EntryPoint = "clCreateSubDevicesEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial int CreateSubDevices([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint in_device, [Flow(Silk.NET.Core.Native.FlowDirection.In)] DevicePartitionProperty* properties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_entries, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out nint out_devices, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out uint num_devices);

        [NativeApi(EntryPoint = "clCreateSubDevicesEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial int CreateSubDevices([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint in_device, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in DevicePartitionProperty properties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_entries, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] nint* out_devices, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* num_devices);

        [NativeApi(EntryPoint = "clCreateSubDevicesEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial int CreateSubDevices([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint in_device, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in DevicePartitionProperty properties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_entries, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] nint* out_devices, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out uint num_devices);

        [NativeApi(EntryPoint = "clCreateSubDevicesEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial int CreateSubDevices([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint in_device, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in DevicePartitionProperty properties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_entries, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out nint out_devices, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* num_devices);

        [NativeApi(EntryPoint = "clCreateSubDevicesEXT", Convention = CallingConvention.Winapi)]
        public partial int CreateSubDevices([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint in_device, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in DevicePartitionProperty properties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_entries, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out nint out_devices, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out uint num_devices);

        [Obsolete("The \"ungrouped\" enums (EXT) are deprecated in favour of the \"grouped\" enums (DevicePartitionProperty). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", true)]
        [NativeApi(EntryPoint = "clCreateSubDevicesEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial int CreateSubDevices([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint in_device, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ulong* properties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_entries, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] nint* out_devices, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* num_devices);

        [Obsolete("The \"ungrouped\" enums (EXT) are deprecated in favour of the \"grouped\" enums (DevicePartitionProperty). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", true)]
        [NativeApi(EntryPoint = "clCreateSubDevicesEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial int CreateSubDevices([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint in_device, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ulong* properties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_entries, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] nint* out_devices, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out uint num_devices);

        [Obsolete("The \"ungrouped\" enums (EXT) are deprecated in favour of the \"grouped\" enums (DevicePartitionProperty). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", true)]
        [NativeApi(EntryPoint = "clCreateSubDevicesEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial int CreateSubDevices([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint in_device, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ulong* properties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_entries, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out nint out_devices, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* num_devices);

        [Obsolete("The \"ungrouped\" enums (EXT) are deprecated in favour of the \"grouped\" enums (DevicePartitionProperty). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", true)]
        [NativeApi(EntryPoint = "clCreateSubDevicesEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial int CreateSubDevices([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint in_device, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ulong* properties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_entries, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out nint out_devices, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out uint num_devices);

        [Obsolete("The \"ungrouped\" enums (EXT) are deprecated in favour of the \"grouped\" enums (DevicePartitionProperty). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", true)]
        [NativeApi(EntryPoint = "clCreateSubDevicesEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial int CreateSubDevices([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint in_device, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ulong properties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_entries, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] nint* out_devices, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* num_devices);

        [Obsolete("The \"ungrouped\" enums (EXT) are deprecated in favour of the \"grouped\" enums (DevicePartitionProperty). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", true)]
        [NativeApi(EntryPoint = "clCreateSubDevicesEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial int CreateSubDevices([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint in_device, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ulong properties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_entries, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] nint* out_devices, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out uint num_devices);

        [Obsolete("The \"ungrouped\" enums (EXT) are deprecated in favour of the \"grouped\" enums (DevicePartitionProperty). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", true)]
        [NativeApi(EntryPoint = "clCreateSubDevicesEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial int CreateSubDevices([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint in_device, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ulong properties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_entries, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out nint out_devices, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* num_devices);

        [Obsolete("The \"ungrouped\" enums (EXT) are deprecated in favour of the \"grouped\" enums (DevicePartitionProperty). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", true)]
        [NativeApi(EntryPoint = "clCreateSubDevicesEXT", Convention = CallingConvention.Winapi)]
        public partial int CreateSubDevices([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint in_device, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ulong properties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_entries, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out nint out_devices, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out uint num_devices);

        [NativeApi(EntryPoint = "clReleaseDeviceEXT", Convention = CallingConvention.Winapi)]
        public partial int ReleaseDevice([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint device);

        [NativeApi(EntryPoint = "clRetainDeviceEXT", Convention = CallingConvention.Winapi)]
        public partial int RetainDevice([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint device);

        public ExtDeviceFission(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

