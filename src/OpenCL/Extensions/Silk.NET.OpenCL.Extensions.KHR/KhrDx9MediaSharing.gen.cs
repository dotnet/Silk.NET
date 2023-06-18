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

namespace Silk.NET.OpenCL.Extensions.KHR
{
    [Extension("KHR_dx9_media_sharing")]
    public unsafe partial class KhrDx9MediaSharing : NativeExtension<CL>
    {
        public const string ExtensionName = "KHR_dx9_media_sharing";
        [NativeApi(EntryPoint = "clCreateFromDX9MediaSurfaceKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial nint CreateFromDX9MediaSurface([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint context, [Flow(Silk.NET.Core.Native.FlowDirection.In)] MemFlags flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint adapter_type, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* surface_info, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint plane, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* errcode_ret);

        [NativeApi(EntryPoint = "clEnqueueAcquireDX9MediaSurfacesKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueAcquireDX9MediaSurfaces([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint command_queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_objects, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint* mem_objects, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_events_in_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint* event_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] nint* @event);

        [NativeApi(EntryPoint = "clEnqueueReleaseDX9MediaSurfacesKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueReleaseDX9MediaSurfaces([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint command_queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_objects, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint* mem_objects, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_events_in_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint* event_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] nint* @event);

        [NativeApi(EntryPoint = "clGetDeviceIDsFromDX9MediaAdapterKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial int GetDeviceIDsFromDX9MediaAdapter([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint platform, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_media_adapters, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* media_adapter_type, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* media_adapters, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint media_adapter_set, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_entries, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] nint* devices, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* num_devices);

        public KhrDx9MediaSharing(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

