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
    [Extension("KHR_d3d11_sharing")]
    public unsafe partial class KhrD3d11Sharing : NativeExtension<CL>
    {
        public const string ExtensionName = "KHR_d3d11_sharing";
        [NativeApi(EntryPoint = "clCreateFromD3D11BufferKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial nint CreateFromD3D11Buffer([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint context, [Flow(Silk.NET.Core.Native.FlowDirection.In)] MemFlags flags, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* resource, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* errcode_ret);

        [NativeApi(EntryPoint = "clCreateFromD3D11Texture2DKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial nint CreateFromD3D11Texture2D([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint context, [Flow(Silk.NET.Core.Native.FlowDirection.In)] MemFlags flags, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* resource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint subresource, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* errcode_ret);

        [NativeApi(EntryPoint = "clCreateFromD3D11Texture3DKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial nint CreateFromD3D11Texture3D([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint context, [Flow(Silk.NET.Core.Native.FlowDirection.In)] MemFlags flags, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* resource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint subresource, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* errcode_ret);

        [NativeApi(EntryPoint = "clEnqueueAcquireD3D11ObjectsKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueAcquireD3D11Objects([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint command_queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_objects, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint* mem_objects, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_events_in_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint* event_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] nint* @event);

        [NativeApi(EntryPoint = "clEnqueueReleaseD3D11ObjectsKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueReleaseD3D11Objects([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint command_queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_objects, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint* mem_objects, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_events_in_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint* event_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] nint* @event);

        [NativeApi(EntryPoint = "clGetDeviceIDsFromD3D11KHR", Convention = CallingConvention.Winapi)]
        public unsafe partial int GetDeviceIDsFromD3D11([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint platform, [Flow(Silk.NET.Core.Native.FlowDirection.In)] D3d11DeviceSource d3d_device_source, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* d3d_object, [Flow(Silk.NET.Core.Native.FlowDirection.In)] D3d11DeviceSet d3d_device_set, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_entries, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] nint* devices, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* num_devices);

        public KhrD3d11Sharing(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

