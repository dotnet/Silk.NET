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

#pragma warning disable 1591

namespace Silk.NET.OpenCL.Extensions.INTEL
{
    [Extension("INTEL_va_api_media_sharing")]
    public abstract unsafe partial class IntelVaApiMediaSharing : NativeExtension<CL>
    {
        public const string ExtensionName = "INTEL_va_api_media_sharing";
        [NativeApi(EntryPoint = "clCreateFromVA_APIMediaSurfaceINTEL")]
        public abstract unsafe IntPtr CreateFromVAApimediaSurface([Flow(FlowDirection.In)] IntPtr context, [Flow(FlowDirection.In)] INTEL flags, [Flow(FlowDirection.Out)] IntPtr surface, [Flow(FlowDirection.In)] uint plane, [Flow(FlowDirection.Out)] int* errcode_ret);

        [NativeApi(EntryPoint = "clCreateFromVA_APIMediaSurfaceINTEL")]
        public abstract IntPtr CreateFromVAApimediaSurface([Flow(FlowDirection.In)] IntPtr context, [Flow(FlowDirection.In)] INTEL flags, [Flow(FlowDirection.Out)] IntPtr surface, [Flow(FlowDirection.In)] uint plane, [Flow(FlowDirection.Out)] Span<int> errcode_ret);

        [NativeApi(EntryPoint = "clEnqueueAcquireVA_APIMediaSurfacesINTEL")]
        public abstract unsafe int EnqueueAcquireVAApimediaSurfaces([Flow(FlowDirection.In)] IntPtr command_queue, [Flow(FlowDirection.In)] uint num_objects, [Flow(FlowDirection.In)] IntPtr* mem_objects, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] IntPtr* event_wait_list, [Flow(FlowDirection.Out)] IntPtr* @event);

        [NativeApi(EntryPoint = "clEnqueueAcquireVA_APIMediaSurfacesINTEL")]
        public abstract int EnqueueAcquireVAApimediaSurfaces([Flow(FlowDirection.In)] IntPtr command_queue, [Flow(FlowDirection.In)] uint num_objects, [Flow(FlowDirection.In)] Span<IntPtr> mem_objects, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] Span<IntPtr> event_wait_list, [Flow(FlowDirection.Out)] Span<IntPtr> @event);

        [NativeApi(EntryPoint = "clEnqueueReleaseVA_APIMediaSurfacesINTEL")]
        public abstract unsafe int EnqueueReleaseVAApimediaSurfaces([Flow(FlowDirection.In)] IntPtr command_queue, [Flow(FlowDirection.In)] uint num_objects, [Flow(FlowDirection.In)] IntPtr* mem_objects, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] IntPtr* event_wait_list, [Flow(FlowDirection.Out)] IntPtr* @event);

        [NativeApi(EntryPoint = "clEnqueueReleaseVA_APIMediaSurfacesINTEL")]
        public abstract int EnqueueReleaseVAApimediaSurfaces([Flow(FlowDirection.In)] IntPtr command_queue, [Flow(FlowDirection.In)] uint num_objects, [Flow(FlowDirection.In)] Span<IntPtr> mem_objects, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] Span<IntPtr> event_wait_list, [Flow(FlowDirection.Out)] Span<IntPtr> @event);

        [NativeApi(EntryPoint = "clGetDeviceIDsFromVA_APIMediaAdapterINTEL")]
        public abstract unsafe int GetDeviceIDsFromVAApimediaAdapter([Flow(FlowDirection.In)] IntPtr platform, [Flow(FlowDirection.In)] uint media_adapter_type, [Flow(FlowDirection.Out)] void* media_adapter, [Flow(FlowDirection.In)] uint media_adapter_set, [Flow(FlowDirection.In)] uint num_entries, [Flow(FlowDirection.Out)] IntPtr* devices, [Flow(FlowDirection.Out)] uint* num_devices);

        [NativeApi(EntryPoint = "clGetDeviceIDsFromVA_APIMediaAdapterINTEL")]
        public abstract int GetDeviceIDsFromVAApimediaAdapter<T0>([Flow(FlowDirection.In)] IntPtr platform, [Flow(FlowDirection.In)] uint media_adapter_type, [Flow(FlowDirection.Out)] Span<T0> media_adapter, [Flow(FlowDirection.In)] uint media_adapter_set, [Flow(FlowDirection.In)] uint num_entries, [Flow(FlowDirection.Out)] Span<IntPtr> devices, [Flow(FlowDirection.Out)] Span<uint> num_devices) where T0 : unmanaged;

        public unsafe IntPtr CreateFromVAApimediaSurface([Flow(FlowDirection.In)] int context, [Flow(FlowDirection.In)] INTEL flags, [Flow(FlowDirection.Out)] int surface, [Flow(FlowDirection.In)] uint plane, [Flow(FlowDirection.Out)] int* errcode_ret)
        {
            // IntPtrOverloader
            return CreateFromVAApimediaSurface(new IntPtr(context), flags, new IntPtr(surface), plane, errcode_ret);
        }

        public unsafe IntPtr CreateFromVAApimediaSurface([Flow(FlowDirection.In)] int context, [Flow(FlowDirection.In)] INTEL flags, [Flow(FlowDirection.Out)] int surface, [Flow(FlowDirection.In)] uint plane, [Flow(FlowDirection.Out)] Span<int> errcode_ret)
        {
            // IntPtrOverloader
            return CreateFromVAApimediaSurface(new IntPtr(context), flags, new IntPtr(surface), plane, errcode_ret);
        }

        public unsafe int EnqueueAcquireVAApimediaSurfaces([Flow(FlowDirection.In)] int command_queue, [Flow(FlowDirection.In)] uint num_objects, [Flow(FlowDirection.In)] IntPtr* mem_objects, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] IntPtr* event_wait_list, [Flow(FlowDirection.Out)] IntPtr* @event)
        {
            // IntPtrOverloader
            return EnqueueAcquireVAApimediaSurfaces(new IntPtr(command_queue), num_objects, mem_objects, num_events_in_wait_list, event_wait_list, @event);
        }

        public unsafe int EnqueueAcquireVAApimediaSurfaces([Flow(FlowDirection.In)] int command_queue, [Flow(FlowDirection.In)] uint num_objects, [Flow(FlowDirection.In)] Span<IntPtr> mem_objects, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] Span<IntPtr> event_wait_list, [Flow(FlowDirection.Out)] Span<IntPtr> @event)
        {
            // IntPtrOverloader
            return EnqueueAcquireVAApimediaSurfaces(new IntPtr(command_queue), num_objects, mem_objects, num_events_in_wait_list, event_wait_list, @event);
        }

        public unsafe int EnqueueReleaseVAApimediaSurfaces([Flow(FlowDirection.In)] int command_queue, [Flow(FlowDirection.In)] uint num_objects, [Flow(FlowDirection.In)] IntPtr* mem_objects, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] IntPtr* event_wait_list, [Flow(FlowDirection.Out)] IntPtr* @event)
        {
            // IntPtrOverloader
            return EnqueueReleaseVAApimediaSurfaces(new IntPtr(command_queue), num_objects, mem_objects, num_events_in_wait_list, event_wait_list, @event);
        }

        public unsafe int EnqueueReleaseVAApimediaSurfaces([Flow(FlowDirection.In)] int command_queue, [Flow(FlowDirection.In)] uint num_objects, [Flow(FlowDirection.In)] Span<IntPtr> mem_objects, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] Span<IntPtr> event_wait_list, [Flow(FlowDirection.Out)] Span<IntPtr> @event)
        {
            // IntPtrOverloader
            return EnqueueReleaseVAApimediaSurfaces(new IntPtr(command_queue), num_objects, mem_objects, num_events_in_wait_list, event_wait_list, @event);
        }

        public unsafe int GetDeviceIDsFromVAApimediaAdapter([Flow(FlowDirection.In)] int platform, [Flow(FlowDirection.In)] uint media_adapter_type, [Flow(FlowDirection.Out)] void* media_adapter, [Flow(FlowDirection.In)] uint media_adapter_set, [Flow(FlowDirection.In)] uint num_entries, [Flow(FlowDirection.Out)] IntPtr* devices, [Flow(FlowDirection.Out)] uint* num_devices)
        {
            // IntPtrOverloader
            return GetDeviceIDsFromVAApimediaAdapter(new IntPtr(platform), media_adapter_type, media_adapter, media_adapter_set, num_entries, devices, num_devices);
        }

        public unsafe int GetDeviceIDsFromVAApimediaAdapter<T0>([Flow(FlowDirection.In)] int platform, [Flow(FlowDirection.In)] uint media_adapter_type, [Flow(FlowDirection.Out)] Span<T0> media_adapter, [Flow(FlowDirection.In)] uint media_adapter_set, [Flow(FlowDirection.In)] uint num_entries, [Flow(FlowDirection.Out)] Span<IntPtr> devices, [Flow(FlowDirection.Out)] Span<uint> num_devices) where T0 : unmanaged
        {
            // IntPtrOverloader
            return GetDeviceIDsFromVAApimediaAdapter(new IntPtr(platform), media_adapter_type, media_adapter, media_adapter_set, num_entries, devices, num_devices);
        }

        public IntelVaApiMediaSharing(ref NativeApiContext ctx)
            : base(ref ctx)
        {
        }
    }
}

