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

namespace Silk.NET.OpenCL.Extensions.INTEL
{
    [Extension("INTEL_dx9_media_sharing")]
    public unsafe partial class IntelDx9MediaSharing : NativeExtension<CL>
    {
        public const string ExtensionName = "INTEL_dx9_media_sharing";
        [NativeApi(EntryPoint = "clCreateFromDX9MediaSurfaceINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial nint CreateFromDX9MediaSurface([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint context, [Flow(Silk.NET.Core.Native.FlowDirection.In)] MemFlags flags, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* resource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint sharedHandle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint plane, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* errcode_ret);

        [NativeApi(EntryPoint = "clEnqueueAcquireDX9ObjectsINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueAcquireDX9Objects([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint command_queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_objects, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint* mem_objects, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_events_in_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint* event_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] nint* @event);

        [NativeApi(EntryPoint = "clEnqueueReleaseDX9ObjectsINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueReleaseDX9Objects([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint command_queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_objects, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] nint* mem_objects, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_events_in_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint* event_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] nint* @event);

        [NativeApi(EntryPoint = "clGetDeviceIDsFromDX9INTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial int GetDeviceIDsFromDX9([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint platform, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Dx9DeviceSource dx9_device_source, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* dx9_object, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Dx9DeviceSet dx9_device_set, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_entries, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] nint* devices, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* num_devices);

        public IntelDx9MediaSharing(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

